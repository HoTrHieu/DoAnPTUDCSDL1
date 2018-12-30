using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.BUS;
using PROJECT.DTO;

namespace PROJECT.GUI
{
    public partial class frmThongTinSinhVien : Form
    {
        SINHVIEN sv;//=SinhVienBUS.Instance.GetByID("SV01");
        public frmThongTinSinhVien(SINHVIEN S)
        {
            InitializeComponent();
            sv = S;
        }
        public frmThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {
            lblMaSinhVien.Text = sv.maSinhVien;
            txtHoTen.Text = sv.tenSinhVien;
            txtPhai.Text = (sv.phai==true?"Nam":"Nữ");
            dateTimePick.Value = sv.ngaySinh.Value;
            txtDiaChi.Text = sv.diaChi;
            lblMaNganh.Text = sv.maNganh;
            lblTenNganh.Text = NganhBUS.Instance.GetByID(sv.maNganh).tenNganh;

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaTen_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
        }

        private void btnSuaPhai_Click(object sender, EventArgs e)
        {
            txtPhai.Enabled = true;
        }

        private void btnSuaNgaySinh_Click(object sender, EventArgs e)
        {
            dateTimePick.Enabled = true;
        }

        private void btnSuaDiaChi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = true;
        }

        private void btnSuaHinh_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            sv.tenSinhVien = txtHoTen.Text;
            sv.phai = (txtPhai.Text == "Nam" ? true : false);
            sv.ngaySinh = dateTimePick.Value;
            sv.diaChi = txtDiaChi.Text;

            bool capNhat = SinhVienBUS.Instance.Update(sv);
            if (capNhat == true)
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
            else
                MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
        }
    }
}
