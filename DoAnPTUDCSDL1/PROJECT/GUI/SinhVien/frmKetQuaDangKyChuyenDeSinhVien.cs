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
    public partial class frmKetQuaDangKyChuyenDeSinhVien : Form
    {
        public frmKetQuaDangKyChuyenDeSinhVien()
        {
            InitializeComponent();
        }
        private string _maSV;
        public frmKetQuaDangKyChuyenDeSinhVien(string maSV)
        {
            _maSV = maSV;
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

        private void frmKetQuaDangKyChuyenDeSinhVien_Load(object sender, EventArgs e)
        {
            // load dữ liệu vào cbHocKy va cbNamHoc
            cmbHocKy.DataSource = HocKyBUS.Instance.GetHocKy();
            cmbNamHoc.DataSource = HocKyBUS.Instance.GetNienHoc();

            //string maSV = lblMaSV.Text;
            SINHVIEN sv = SinhVienBUS.Instance.GetByID(_maSV);
            string tenSV = sv.tenSinhVien;

            dgvKetQuaDangKy.DataSource = ThongTinDangKyBUS.Instance.GetTTDKCDeSinhVien(_maSV);
            dgvKetQuaDangKy.Columns[0].HeaderText = "Mã CĐ";
            dgvKetQuaDangKy.Columns[1].HeaderText = "Tên Chuyên Đề";
            dgvKetQuaDangKy.Columns[2].HeaderText = "Ngày Bắt Đầu";
            dgvKetQuaDangKy.Columns[3].HeaderText = "Ngày Kết Thúc";
            dgvKetQuaDangKy.Columns[4].HeaderText = "Tên Lớp";

            if (dgvKetQuaDangKy.RowCount == 0)
            {
                MessageBox.Show("Không có chuyên đề nào được đăng ký");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string nienHoc = cmbNamHoc.SelectedItem.ToString();
            int hocKy = int.Parse(cmbHocKy.SelectedItem.ToString());

            dgvKetQuaDangKy.DataSource = ThongTinDangKyBUS.Instance.GetTTDKCDeSinhVien(_maSV, hocKy, nienHoc);
            dgvKetQuaDangKy.Columns[0].HeaderText = "Mã CĐ";
            dgvKetQuaDangKy.Columns[1].HeaderText = "Tên Chuyên Đề";
            dgvKetQuaDangKy.Columns[2].HeaderText = "Ngày Bắt Đầu";
            dgvKetQuaDangKy.Columns[3].HeaderText = "Ngày Kết Thúc";
            dgvKetQuaDangKy.Columns[4].HeaderText = "Tên Lớp";

            if (dgvKetQuaDangKy.RowCount == 0)
            {
                MessageBox.Show("Không có chuyên đề nào được đăng ký \nVào học kì : " + hocKy + " năm : " + nienHoc);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            frmKetQuaDangKyChuyenDeSinhVien_Load(sender,  e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
