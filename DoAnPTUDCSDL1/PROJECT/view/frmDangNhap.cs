using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT.view
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string username = txtDangNhap.Text;
            string password = txtMatKhau.Text;
            if (true)
            {
                MessageBox.Show("Dang Nhap Thanh Cong");
            }
            else
            {
                //txtDangNhap.Clear;
                //txtMatKhau.Clear;
            }
        }
    }
}
