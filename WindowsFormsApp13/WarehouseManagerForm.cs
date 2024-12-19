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
    public partial class WarehouseManagerForm : Form
    {
        int employeeId;
        string authorityLevel;
        public WarehouseManagerForm(string authorityLevel,int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }



        private void WarehouseManagerForm_Load(object sender, EventArgs e)
        {
    
        }


        private void btnManagerProduct_Click(object sender, EventArgs e)
        {
            ManagerProduct managerProduct = new ManagerProduct(this.authorityLevel, this.employeeId);
            this.Hide();
            managerProduct.Show();
        }
    }
}
