using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class ManagerProduct : Form
    {
        private int productId;
        private string authorityLevel;
        private int userId;
        private string cbAuthorityLevel;
        private string txtProductPosition;
        private object txtUsername;

        public ManagerProduct(string authorityLevel, int userId)
        {
            this.authorityLevel = authorityLevel;
            this.userId = userId;
            productId = 0;
            InitializeComponent();
            LoadProductData();
        }

        private void ManagerProduct_Load(object sender, EventArgs e)
        {
            LoadProductData();
            LoadCategoryCombobox();
            ChangeButtonStatus(false);
        }

        private void LoadCategoryCombobox()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT CategoryID, CategoryName FROM Category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbCategory.DataSource = dataTable;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";
                connection.Close();
            }
        }

        private bool ValidateData(string productCode, string productName, string productPrice, string productQuantity)
        {
            double temp;
            int temp2;
            if (string.IsNullOrEmpty(productCode)) return false;
            if (string.IsNullOrEmpty(productPrice)) return false;
            if (!double.TryParse(productPrice, out temp)) return false;
            if (string.IsNullOrEmpty(productQuantity)) return false;
            return int.TryParse(productQuantity, out temp2);
        }

        private void UploadFile(string filter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = filter,
                Title = "Select a file to upload"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Upload");
                string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(sourceFilePath));
                try
                {
                    if (!Directory.Exists(targetDirectory))
                    {
                        Directory.CreateDirectory(targetDirectory);
                    }
                    File.Copy(sourceFilePath, targetFilePath, true);
                    txtProductImg.Text = targetFilePath;
                    MessageBox.Show("File uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProductData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT * FROM Product";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgProduct.DataSource = dataTable;
                connection.Close();
            }
        }

        private void ClearData()
        {
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductImg.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void ChangeButtonStatus(bool buttonStatus)
        {
            btnUpdate.Enabled = buttonStatus;
            btnClear.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnAdd.Enabled = buttonStatus;
        }

        private void AddProduct()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                string productImg = txtProductImg.Text;
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);

                if (ValidateData(productCode, productName, price, quantity))
                {
                    string sql = "INSERT INTO Product VALUES (@productCode, @productName, @productPrice, @productImg, @productQuantity, @categoryId)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("productCode", productCode);
                    command.Parameters.AddWithValue("productName", productName);
                    command.Parameters.AddWithValue("productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("productImg", productImg);
                    command.Parameters.AddWithValue("categoryId", categoryId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully added new product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add new product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                connection.Close();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadFile("Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (authorityLevel)
            {
                case "Admin":
                    {
                        AdminForm adminForm = new AdminForm(this.authorityLevel, this.userId);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(this.authorityLevel, this.userId);
                        this.Hide();
                        warehouseManagerForm.Show();
                        break;
                    }
                case "Sale":
                    {
                        ManagerCustomer saleForm = new ManagerCustomer(this.authorityLevel, this.userId);
                        this.Hide();
                        saleForm.Show();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get row index based on current cell (cell clicked)
            int index = dtgProduct.CurrentCell.RowIndex;

            // Check index validity
            if (index != -1)
            {
                // Get value of each cell based on row index
                // You have to check the SQL query which is used to load data from database (LoadEmployeeData function)
                // Use this query and execute it in SSMS to imagine the datagridview
                // The order of the column header is as follows: 
                // ID | Code | Name | Position | AuthorityLevel | Username | Password | PasswordChanged
                // And the index is from 0 to 7

                // Get the employeeID (index is 0)
                productId = Convert.ToInt32(dtgProduct.Rows[index].Cells[0].Value);

                // Change the button status (update, delete, clear is enabled when employeeId > 0)
                ChangeButtonStatus(true);

                // Get the EmployeeCode (index is 1)
                txtProductCode.Text = dtgProduct.Rows[index].Cells[1].Value.ToString();

                // Get the EmployeeName (index is 2)
                txtProductName.Text = dtgProduct.Rows[index].Cells[2].Value.ToString();

                // Get the EmployeePosition (index is 3)
                txtProductPrice.Text = dtgProduct.Rows[index].Cells[3].Value.ToString();
                txtProductQuantity.Text = dtgProduct.Rows[index].Cells[4].Value.ToString();
                txtProductImg.Text = dtgProduct.Rows[index].Cells[5].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void UpdateProduct()
        {
            // Open connection by call the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();
            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();
                // get input data
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                string productImg = txtProductImg.Text;
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                // validate data
                if (ValidateData(productCode, productName, price, quantity))
                {
                    // declare query
                    string sql = "UPDATE Product SET ProductCode = @productCode, " +
                                 "ProductName = @productName, " +
                                 "Price = @productPrice, " +
                                 "InventoryQuantity = @productQuantity, " +
                                 "ProductImage = @productImg, " +
                                 "CategoryID = @categoryId " +
                                 "WHERE ProductID = @productId";
                    // declare sqlcommand variable to manipulate query
                    SqlCommand command = new SqlCommand(sql, connection);
                    // add params
                    command.Parameters.AddWithValue("productCode", productCode);
                    command.Parameters.AddWithValue("productName", productName);
                    command.Parameters.AddWithValue("productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("productImg", productImg);
                    command.Parameters.AddWithValue("categoryId", categoryId);
                    command.Parameters.AddWithValue("productId", this.productId);
                    // execute query and get the result
                    int result = command.ExecuteNonQuery();
                    // check result
                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Successfully update product",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cannot update product",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                // close the connection
                connection.Close();
            }
        }

        private void DeleteProduct()
        {
            // Ask for confirmation
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the product",
                "Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Check if product in any order
                // if it have, deny this action because this can cause exception while running
                if (!IsProductInOrder(this.productId))
                {
                    // Open connection by call the GetConnection function in DatabaseConnection class
                    SqlConnection connection = DatabaseConnection.GetConnection();
                    // Check connection
                    if (connection != null)
                    {
                        // Open the connection
                        connection.Open();
                        // declare query
                        string sql = "DELETE Product WHERE ProductID = @productId";
                        // declare sqlcommand variable to manipulate query
                        SqlCommand command = new SqlCommand(sql, connection);
                        // add params
                        command.Parameters.AddWithValue("productId", this.productId);
                        // execute query and get the result
                        int result = command.ExecuteNonQuery();
                        // check result
                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Successfully delete product",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearData();
                            LoadProductData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Cannot delete product",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        // close the connection
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Product is in another order\nCannot delete",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private bool IsProductInOrder(int productId)
        {
            // Open connection by call the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();
            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();
                // declare query to get number of record have productId equal productId
                string sql = "SELECT COUNT(*) FROM OrderDetail WHERE ProductID = @productId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("productId", productId);
                int result = (int)command.ExecuteScalar();
                connection.Close();
                return result > 0;
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

    }
}
