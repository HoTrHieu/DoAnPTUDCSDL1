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
    public partial class frmKetQuaDangKyChuyenDeGiaoVu : Form
    {
        public frmKetQuaDangKyChuyenDeGiaoVu()
        {
            InitializeComponent();
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

        private void frmKetQuaDangKyChuyenDeGiaoVu_Load(object sender, EventArgs e)
        {
            // load dữ liệu vào cbHocKy va cbNamHoc
            cmbHocKy.DataSource = HocKyBUS.Instance.GetHocKy();
            cmbNamHoc.DataSource = HocKyBUS.Instance.GetNienHoc();

            // load dữ liệu vào cmbChuyenDe
            foreach (var item in ChuyenDeBUS.Instance.GetAll())
            {
                cmbChuyenDe.Items.Add(new Item(item.tenCDe, item.maCDe));
            }
            cmbChuyenDe.SelectedIndex = 0;
        }

        private void btnTimTheoYeuCau_Click_1(object sender, EventArgs e)
        {
            int hocKy = (int)cmbHocKy.SelectedItem;
            string nienHoc = cmbNamHoc.SelectedItem.ToString();

            Item chuyenDe = (Item)cmbChuyenDe.SelectedItem;
            string maCD = chuyenDe.Value;
            string tenCD = chuyenDe.Name;

            dgvDSSinhVienDangKyChuyenDe.DataSource = ThongTinDangKyBUS.Instance.GetAllThongTinDangKyChuyenDeSinhVienTheoDieuKien(hocKy, nienHoc, maCD);
            dgvDSSinhVienDangKyChuyenDe.Columns[0].HeaderText = "Học Kỳ";
            dgvDSSinhVienDangKyChuyenDe.Columns[1].HeaderText = "Niên Học";
            dgvDSSinhVienDangKyChuyenDe.Columns[2].HeaderText = "Tên Lớp";
            dgvDSSinhVienDangKyChuyenDe.Columns[3].HeaderText = "MSSV";
            dgvDSSinhVienDangKyChuyenDe.Columns[4].HeaderText = "Tên SV";
            dgvDSSinhVienDangKyChuyenDe.Columns[5].HeaderText = "Tên GVQL";
            dgvDSSinhVienDangKyChuyenDe.Columns[6].HeaderText = "Tên Chuyên Đề";

            if (dgvDSSinhVienDangKyChuyenDe.RowCount == 0)
            {
                MessageBox.Show("Không có sinh viên nào đăng ký \nChuyên đề " + tenCD + "\nVào học kì : " + hocKy + " năm : " + nienHoc);
            }
        }

        private void btnHienThiTatCaChuyenDe_Click_1(object sender, EventArgs e)
        {
            dgvDSSinhVienDangKyChuyenDe.DataSource = ThongTinDangKyBUS.Instance.GetAllThongTinDangKyChuyenDeSinhVien();
            dgvDSSinhVienDangKyChuyenDe.Columns[0].HeaderText = "Học Kỳ";
            dgvDSSinhVienDangKyChuyenDe.Columns[1].HeaderText = "Niên Học";
            dgvDSSinhVienDangKyChuyenDe.Columns[2].HeaderText = "Tên Lớp";
            dgvDSSinhVienDangKyChuyenDe.Columns[3].HeaderText = "MSSV";
            dgvDSSinhVienDangKyChuyenDe.Columns[4].HeaderText = "Tên SV";
            dgvDSSinhVienDangKyChuyenDe.Columns[5].HeaderText = "Tên GVQL";
            dgvDSSinhVienDangKyChuyenDe.Columns[6].HeaderText = "Tên Chuyên Đề";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
