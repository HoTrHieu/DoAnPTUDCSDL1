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

        private class Item
        {
            public string Name, Value;
            public Item(string name, string value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string maTaiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string maGVT = _maGVT.Trim();
            Item nganh = (Item)cmbNganh.SelectedItem;
            string maNganh = nganh.Value.Trim();
            DateTime ngaySinh = DateTime.Now;

            TAIKHOAN taikhoan = new TAIKHOAN(maTaiKhoan, matKhau, "SV", maGVT);
            //SINHVIEN sinhvien = new SINHVIEN(maTaiKhoan, "", null, ngaySinh, "", maNganh);
            try
            {
                TaiKhoanBUS.Instance.Insert(taikhoan);
                SinhVienBUS.Instance.InsertDefault(maTaiKhoan, maNganh);
                MessageBox.Show("Thêm tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm tài khoản không thành công.\nTài khoản đã tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //MessageBox.Show("MaTaiKhoan: " + maTaiKhoan + "\nMatKhau : " + matKhau + "\nMaNganh : " + maCD);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemTaiKhoanSinhVien_Load(object sender, EventArgs e)
        {
            foreach (var item in NganhBUS.Instance.GetAll())
            {
                cmbNganh.Items.Add(new Item(item.tenNganh, item.maNganh));
            }
            cmbNganh.SelectedIndex = 0;
        }
    }
}
