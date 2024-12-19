using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class ManagerCustomer : Form
    {
        private int customerId;
        private int employeeId;
        private string authorityLevel;
        private int userId;

        public ManagerCustomer(string AuthorityLevel, int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.authorityLevel = AuthorityLevel;
        }

        public ManagerCustomer()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            txtCustomerCode.Clear();
            txtCustomerName.Clear();
            txtCustomerAddress.Clear();
            txtPhonenumber.Clear();
            customerId = 0; // Reset customerId
            ChangeButtonStatus(false); // Disable buttons after clearing
        }

        private void ChangeButtonStatus(bool buttonStatus)
        {
            btnUpdate.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnClearr.Enabled = buttonStatus;
            btnAdd.Enabled = buttonStatus;
        }

        private bool ValidateData(string customerCode, string customerName, string customerAddress, string phonenumber)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(customerCode))
            {
                MessageBox.Show("Customer Code cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                txtCustomerCode.Focus();
            }
            else if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer Name cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                txtCustomerName.Focus();
            }
            else if (string.IsNullOrEmpty(customerAddress))
            {
                MessageBox.Show("Customer Address cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                txtCustomerAddress.Focus();
            }
            else if (string.IsNullOrEmpty(phonenumber))
            {
                MessageBox.Show("Phone number cannot be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                txtPhonenumber.Focus();
            }

            return isValid;
        }

        private void LoadCustomerData()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT * FROM Customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgCustomer.DataSource = table;
                }
            }
        }

        private void AddCustomer(string customerCode, string customerName, string customerAddress, string phoneNumber)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    connection.Open();
                    string query = "INSERT INTO Customer (CustomerCode, CustomerName, PhoneNumber, Address) VALUES (@customerCode, @customerName, @phoneNumber, @customerAddress)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("customerCode", customerCode);
                    command.Parameters.AddWithValue("customerName", customerName);
                    command.Parameters.AddWithValue("phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("customerAddress", customerAddress);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully added a new customer", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadCustomerData();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while adding customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerCode = txtCustomerCode.Text;
            string customerName = txtCustomerName.Text;
            string customerAddress = txtCustomerAddress.Text;
            string phonenumber = txtPhonenumber.Text;

            if (ValidateData(customerCode, customerName, customerAddress, phonenumber))
            {
                AddCustomer(customerCode, customerName, customerAddress, phonenumber);
            }
        }

        private void btnClear(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
        private void updateCustomer(int customerId, string customerCode, string customerName, string customerAddress, string phoneNumber)
        {
            // Initialize database connection by call GetConnection function from DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();
            // Check the connection
            if (connection != null)
            {
                connection.Open();
                string query = "UPDATE Customer SET " +
                              "CustomerCode = @customerCode, " +
                              "CustomerName = @customerName, " +
                              "Address = @customerAddress, " +
                              "Phonenumber = @phoneNumber " +
                              "WHERE CustomerID = @customerId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("customerCode", customerCode);
                command.Parameters.AddWithValue("customerName", customerName);
                command.Parameters.AddWithValue("customerAddress", customerAddress);
                command.Parameters.AddWithValue("phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("customerId", customerId);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while updating customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                connection.Close();
                // Clear all user input data and flush customerID
                ClearData();
                // Reload the data gridview
                LoadCustomerData();
            }
        }
        private void DeleteCustomer(int customerId)
        {
            // Initialize database connection by call GetConnection function from DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();
            // Check the connection
            if (connection != null)
            {
                connection.Open();
                string deleteOrderDetailQuery = "DELETE OrderDetail WHERE OrderDetailID IN " +
                    "(SELECT OrderID FROM Orders WHERE CustomerID = @customerId)";

                // declare SqlCommand to add params and execute query
                SqlCommand command = new SqlCommand(deleteOrderDetailQuery, connection);
                // add parameters
                command.Parameters.AddWithValue("customerId", customerId);
                // execute query (We do not need to know the result because this step is used to ensure no execution occur)
                command.ExecuteNonQuery();

                // Declare query to delete Orders records
                string deleteOrderQuery = "DELETE Orders WHERE CustomerID = @customerId";
                // re-declare SqlCommand with different query
                command = new SqlCommand(deleteOrderQuery, connection);
                // add parameters
                command.Parameters.AddWithValue("customerId", customerId);
                // execute query (We do not need to know the result because this step is used to ensure no execution occur)
                command.ExecuteNonQuery();

                // Declare query to delete Customer records (Now we can delete Customer record because it is not refered by other records in Order table)
                string deleteCustomerQuery = "DELETE Customer WHERE CustomerID = @customerId";
                // re-declare SqlCommand with different query
                command = new SqlCommand(deleteCustomerQuery, connection);
                // add parameters
                command.Parameters.AddWithValue("customerId", customerId);
                // execute query
                int deleteCustomerResult = command.ExecuteNonQuery();
                // Check the result
                if (deleteCustomerResult > 0)
                {
                    MessageBox.Show(
                        "Successfully delete customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while deleting customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                connection.Close();
                // Clear all user input data and flush customerID
                ClearData();
                // Reload the data gridview
                LoadCustomerData();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check customerID
            if (customerId > 0)
            {
                
                    string customerCode = txtCustomerCode.Text;
                    string customerName = txtCustomerName.Text;
                    string customerAddress = txtCustomerAddress.Text;
                    string phoneNumber = txtPhonenumber.Text;
                    // Validate data 
                    bool isValid = ValidateData(customerCode, customerName, customerAddress, phoneNumber);
                    if (isValid)
                    {
                        updateCustomer(customerId, customerCode, customerName, customerAddress, phoneNumber);
                    }
               
            }
           
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check customer ID
            // if customerId > 0 (a customer is selected)
            if (customerId > 0)
            {
                // Ask user for confirmation
                DialogResult result = MessageBox.Show(
                    "Do you want to delete this customer with all related data?",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    bool isUserExist = CheckUserExistence(customerId);
                    if (isUserExist)
                    {
                        DeleteCustomer(customerId);
                    }
                    else
                    {
                        MessageBox.Show(
                            "No customer found",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }
        private bool CheckUserExistence(int customerId)
        {
            bool isExist = false;
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Customer WHERE CustomerID = @customerId";
                // Declare SqlCommand variable to add parameters to query and execute it
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                // Add parameters
                command.Parameters.AddWithValue("customerId", customerId);
                // Declare SqlDataReader variable to read retrieved data
                SqlDataReader reader = command.ExecuteReader();
                // Check if reader has row (query success and return one row show user information)
                isExist = reader.HasRows;
                // close the connection
                connection.Close();
            }
            return isExist;
        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgCustomer.CurrentCell.RowIndex;
            if (index > -1)
            {
                customerId = (int)dtgCustomer.Rows[index].Cells[0].Value;
                txtCustomerCode.Text = dtgCustomer.Rows[index].Cells[1].Value.ToString();
                txtCustomerName.Text = dtgCustomer.Rows[index].Cells[2].Value.ToString();
                txtPhonenumber.Text = dtgCustomer.Rows[index].Cells[3].Value.ToString();
                txtCustomerAddress.Text = dtgCustomer.Rows[index].Cells[4].Value.ToString();
                ChangeButtonStatus(true);
            }
        }

        private void ManagerCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SaleForm saleform = new SaleForm();
            saleform.ShowDialog();
            this.Close();
        }
    }

}
