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
    public partial class Changepassword : Form
    {
        string role;
        int employeeId;  // Đảm bảo biến này được khai báo đúng tên

        // Constructor nhận employeeId và role làm tham số
        public Changepassword(int employeeId, string role)
        {
            this.employeeId = employeeId;  // Sử dụng 'employeeId' đúng tên
            this.role = role;
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
