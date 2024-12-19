using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class ManageEmployee : Form
    {
        int employeeId;
        string employeePosition;
       string authorityLevel;

        public ManageEmployee(string employeePosition)
        {
            InitializeComponent();
            this.employeePosition = employeePosition;
            employeeId = 0;
            InitializeCombobox();
            LoadEmployeeData();
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            // You can add any additional initialization logic here if needed
        }

        private bool ValidateData(string employeeCode,
                          string employeeName,
                          string employeePosition,
                          string authorityLevel,
                          string username,
                          string password)
        {
            if (string.IsNullOrEmpty(employeeCode))
            {
                MessageBox.Show("Employee Code cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeCode.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(employeeName))
            {
                MessageBox.Show("Employee Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(employeePosition))
            {
                MessageBox.Show("Employee Position cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeePosition.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(authorityLevel))
            {
                MessageBox.Show("Authority Level cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAuthorityLevel.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            return true;
        }


        private void FlushEmployeeId()
        {
            employeeId = 0;
          
        }

        private void LoadEmployeeData()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    connection.Open();
                    string sql = "SELECT * FROM Employee";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgEmployee.DataSource = table;
                }
            }
        }

        private void ClearData()
        {
            FlushEmployeeId();
            txtEmployeeCode.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmployeePosition.Text = string.Empty;
            cbAuthorityLevel.SelectedIndex = 0;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmployeeCode.Focus();
        }

        public void InitializeCombobox()
        {
            cbAuthorityLevel.Items.Clear();
            cbAuthorityLevel.Items.Add("Admin");
            cbAuthorityLevel.Items.Add("Warehouse Manager");
            cbAuthorityLevel.Items.Add("Sale");
            cbAuthorityLevel.SelectedIndex = 0;
        }

        private bool CheckUserExistence(int employeeId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    connection.Open();
                    string checkQuery = "SELECT * FROM Employee WHERE EmployeeID = @employeeId";
                    using (SqlCommand command = new SqlCommand(checkQuery, connection))
                    {
                        command.Parameters.AddWithValue("employeeId", employeeId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }
                }
            }
            return false;
        }

        private void AddUser(string employeeCode,
                             string employeeName,
                             string employeePosition,
                             string authorityLevel,
                             string username,
                             string password)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    connection.Open();
                    string sql = "INSERT INTO Employee VALUES (@employeeCode, @employeeName, @employeePosition, @authorityLevel, @username, @password, 0)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("employeeCode", employeeCode);
                        command.Parameters.AddWithValue("employeeName", employeeName);
                        command.Parameters.AddWithValue("employeePosition", employeePosition);
                        command.Parameters.AddWithValue("authorityLevel", authorityLevel);
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("password", password);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Successfully added new user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                            LoadEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("Cannot add new user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void UpdateUser(int employeeId,
                                string employeeCode,
                                string employeeName,
                                string employeePosition,
                                string authorityLevel,
                                string username,
                                string password)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    connection.Open();
                    string sql = "UPDATE Employee SET EmployeeCode = @employeeCode, " +
                                 "EmployeeName = @employeeName, " +
                                 "Position = @employeePosition, " +
                                 "AuthorityLevel = @authorityLevel, " +
                                 "Username = @username, " +
                                 "Password = @password " +
                                 "WHERE EmployeeID = @employeeId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("employeeCode", employeeCode);
                        command.Parameters.AddWithValue("employeeName", employeeName);
                        command.Parameters.AddWithValue("employeePosition", employeePosition);
                        command.Parameters.AddWithValue("authorityLevel", authorityLevel);
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("password", password);
                        command.Parameters.AddWithValue("employeeId", employeeId);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Successfully updated user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                            LoadEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("Cannot update user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void DeleteUser(int employeeId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    connection.Open();
                    string sql = "DELETE Employee WHERE EmployeeID = @employeeId";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("employeeId", employeeId);
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Successfully deleted user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                            LoadEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("Cannot delete user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void SearchUser(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadEmployeeData();
            }
            else
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    if (connection != null)
                    {
                        connection.Open();
                        string query = "SELECT * FROM Employee WHERE EmployeeCode LIKE @search " +
                                       "OR EmployeeName LIKE @search " +
                                       "OR Position LIKE @search " +
                                       "OR AuthorityLevel LIKE @search " +
                                       "OR Username LIKE @search " +
                                       "OR Password LIKE @search";

                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dtgEmployee.DataSource = table;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string employeeCode = txtEmployeeCode.Text;
            string employeeName = txtEmployeeName.Text;
            string employeePosition = txtEmployeePosition.Text;
            string authorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateData(employeeCode, employeeName, employeePosition, authorityLevel, username, password))
            {
                AddUser(employeeCode, employeeName, employeePosition, authorityLevel, username, password);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string employeeCode = txtEmployeeCode.Text;
            string employeeName = txtEmployeeName.Text;
            string employeePosition = txtEmployeePosition.Text;
            string authorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateData(employeeCode, employeeName, employeePosition, authorityLevel, username, password))
            {
                UpdateUser(employeeId, employeeCode, employeeName, employeePosition, authorityLevel, username, password);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to delete this user?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteUser(employeeId);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            SearchUser(search);
        }

        private void dtgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgEmployee.CurrentCell.RowIndex;

            if (index != -1)
            {
                employeeId = Convert.ToInt32(dtgEmployee.Rows[index].Cells[0].Value);
              

                txtEmployeeCode.Text = dtgEmployee.Rows[index].Cells[1].Value.ToString();
                txtEmployeeName.Text = dtgEmployee.Rows[index].Cells[2].Value.ToString();
                txtEmployeePosition.Text = dtgEmployee.Rows[index].Cells[3].Value.ToString();

                string authorityLevel = dtgEmployee.Rows[index].Cells[4].Value.ToString();
                switch (authorityLevel)
                {
                    case "Admin":
                        cbAuthorityLevel.SelectedIndex = 0;
                        break;
                    case "Warehouse Manager":
                        cbAuthorityLevel.SelectedIndex = 1;
                        break;
                    case "Sale":
                        cbAuthorityLevel.SelectedIndex = 2;
                        break;
                }

                txtUsername.Text = dtgEmployee.Rows[index].Cells[5].Value.ToString();
                txtPassword.Text = dtgEmployee.Rows[index].Cells[6].Value.ToString();
            }
        }
    }
}