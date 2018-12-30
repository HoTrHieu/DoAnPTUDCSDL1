using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DTO;
using PROJECT.BUS;

namespace PROJECT.GUI
{
    public partial class frmThemTaiKhoanSinhVien : Form
    {
        public frmThemTaiKhoanSinhVien()
        {
            InitializeComponent();
        }
        private string _maGVT;
        public frmThemTaiKhoanSinhVien(string MaGVu)
        {
            _maGVT = MaGVu;
            InitializeComponent();

            txtMatKhau.PasswordChar = (char)0x2022;
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string maTaiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string maGVT = _maGVT;
            TAIKHOAN taikhoan = new TAIKHOAN(maTaiKhoan, matKhau, "SV", maGVT);
            try {
                TaiKhoanBUS.Instance.Insert(taikhoan);
                MessageBox.Show("Thêm tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm tài khoản không thành công.\nTài khoản đã tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
               
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
