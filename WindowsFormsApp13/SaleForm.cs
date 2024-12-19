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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            ManagerCustomer saleForm = new ManagerCustomer();
            this.Hide();
            saleForm.Show();
        }
    }
}
