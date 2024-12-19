using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class AdminForm : Form
    {
       string authorityLevel;
       int employeeId;
       string employeePosition;

        public AdminForm(string employeePosition, int employeeId)
        {
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
            InitializeComponent();
        }

        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee(employeePosition);
            this.Hide();
            manageEmployee.Show();
        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
           
        }

        private void btnManageImport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManagerProduct managerProduct = new ManagerProduct(this.authorityLevel, this.employeeId);
            this.Hide();
            managerProduct.Show();
        }

        private void btnViewStatistic_Click(object sender, EventArgs e)
        {

        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();

        }

        private void gbAdminFeature_Enter(object sender, EventArgs e)
        {

        }
    }
}
