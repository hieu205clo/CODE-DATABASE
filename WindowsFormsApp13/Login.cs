using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public void InitializeCombobox()
        {
            // Setup for combobox
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Warehouse Manager");
            cbRole.Items.Add("Sale");

            // Set the selected index to the first item of the array (Admin)
            cbRole.SelectedIndex = 0;
        }
        
        public Form1()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        // Phương thức kiểm tra dữ liệu đầu vào
        private bool ValidateData(string username, string password, string role)
        {
            bool isValid = true;

            // Kiểm tra trường username
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                txtUsername.Focus();
            }
            // Kiểm tra trường password
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                txtPassword.Focus();
            }
            // Kiểm tra trường role
            else if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("No role selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                cbRole.Focus();
            }

            return isValid;
        }

        // Xử lý sự kiện khi người dùng click vào nút đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cbRole.SelectedItem?.ToString();  // Kiểm tra null

            // Kiểm tra tính hợp lệ của dữ liệu
            bool isValid = ValidateData(username, password, role);
            if (isValid)
            {
                // Mở kết nối với cơ sở dữ liệu
                SqlConnection connection = DatabaseConnection.GetConnection();

                // Kiểm tra kết nối
                if (connection != null)
                {
                    // Định nghĩa câu lệnh SQL để truy vấn
                    string query = "SELECT EmployeeID, PasswordChanged FROM Employee WHERE Username = @username " +
                                   "AND Password = @password AND AuthorityLevel = @role";

                    connection.Open();

                    // Khởi tạo SqlCommand
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("role", role);

                    // Thực thi câu lệnh và lấy kết quả
                    SqlDataReader reader = command.ExecuteReader();
                    int employeeID = 0;
                    bool passwordChanged = false;

                    while (reader.Read())
                    {
                        employeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                        passwordChanged = reader.GetBoolean(reader.GetOrdinal("PasswordChanged"));
                    }

                    // Kiểm tra kết quả
                    if (employeeID > 0)
                    {
                        MessageBox.Show("Login success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RedirectPage(role, employeeID, passwordChanged); // Điều hướng người dùng
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearData(); // Xóa dữ liệu đã nhập
                    }

                    // Đóng kết nối
                    connection.Close();
                }
            }
        }

        // Phương thức điều hướng trang sau khi đăng nhập thành công
       private void RedirectPage(string selectedRole, int employeeId, bool isChangePassword)
{
    // Check if isChangePassword = true (1 in database)
    // so that application does not need to redirect user to ChangePassword Form
    if (isChangePassword)
    {
        if (selectedRole != null)
        {
            // Redirect user based on role
            if (selectedRole == "Admin")
            {
                AdminForm adminForm = new AdminForm(selectedRole, employeeId);
                this.Hide();
                adminForm.Show();
            }
            else if (selectedRole == "Warehouse Manager")
            {
                WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(selectedRole, employeeId);
                this.Hide();
                warehouseManagerForm.Show();
            }
            else if (selectedRole == "Sale")
            {
                SaleForm saleForm = new SaleForm();
                this.Hide();
                saleForm.Show();
            }
        }
    }
   
}


        // Phương thức xóa dữ liệu đã nhập
        private void ClearData()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cbRole.SelectedIndex = -1; // Reset ComboBox
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbRole.SelectedIndex = 0;
            txtUsername.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
