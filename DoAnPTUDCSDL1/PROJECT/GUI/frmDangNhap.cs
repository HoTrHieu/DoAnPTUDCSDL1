using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;//dung de dong form cu mo form moi?
using PROJECT.BUS;
using PROJECT.DTO;

namespace PROJECT.GUI
{
    public partial class frmDangNhap : Form
    {
        Thread th;//dong from cu mo form moi  
        TAIKHOAN tk;
        public frmDangNhap()
        {
            InitializeComponent();

            txtMatKhau.PasswordChar = (char)0x2022;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            try
            {
                if (tenDN == "" || matKhau == "")
                {
                    MessageBox.Show("PHẢI ĐIỀN THÔNG TIN ĐĂNG NHẬP", "THÔNG BÁO");
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                }
                else
                {

                    tk = TaiKhoanBUS.Instance.GetByID(tenDN);
                    if (tk == null || tk.matKhau.TrimEnd() != matKhau)
                    {
                        MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng", "Thông Báo");
                        txtTenDangNhap.Clear();
                        txtMatKhau.Clear();
                    }
                    else
                    {
                        string loai = tk.loaiTaiKhoan.TrimEnd();
                        if (loai == "SV")
                        {
                            this.Close();
                            th = new Thread(OpenFROMsv);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            //Visible = false;
                        }
                        if (loai == "GVU")
                        {
                            this.Close();
                            th = new Thread(OpenFROMgv);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng", "Thông Báo");
            }
        }


        private void OpenFROMsv(object obj)
        {
            Application.Run(new frmGiaoDienChinhSV(tk));
        }
        private void OpenFROMgv(object obj)
        {
            Application.Run(new frmGiaoDienChinhGV(tk));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
