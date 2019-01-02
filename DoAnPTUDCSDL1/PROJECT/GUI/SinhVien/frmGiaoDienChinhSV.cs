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
using PROJECT.DTO;
using PROJECT.BUS;

namespace PROJECT.GUI
{
    public partial class frmGiaoDienChinhSV : Form
    {
        Thread th;//dong from cu mo form moi  
        SINHVIEN sv;
        public frmGiaoDienChinhSV(TAIKHOAN tk)
        {
            InitializeComponent();
            TRaSV(tk);
        }

        public bool TRaSV(TAIKHOAN tk)
        {
            sv = SinhVienBUS.Instance.GetByID(tk.maTaiKhoan);
            if (sv != null)
                return true;
            return false;
        }

        private void frmGiaoDienChinhSV_Load(object sender, EventArgs e)
        {
            lblMaSinhVien.Text = sv.maSinhVien.Trim();
            lblHoTen.Text = sv.tenSinhVien;

            string tenNganh = NganhBUS.Instance.GetByID(sv.maNganh).tenNganh;
            lblNganh.Text = tenNganh;
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKQ_HuyDKy_Click_1(object sender, EventArgs e)
        {
            frmKetQuaDangKyChuyenDeSinhVien frm = new frmKetQuaDangKyChuyenDeSinhVien(sv.maSinhVien);
            frm.ShowDialog();
        }

        private void btnDangKyCD_Click_1(object sender, EventArgs e)
        {
            frmDangKyChuyenDe frm = new frmDangKyChuyenDe(sv.maSinhVien);
            frm.ShowDialog();
        }

        private void btnDKyNhom_Click_1(object sender, EventArgs e)
        {
            frmDangKiNhom frm = new frmDangKiNhom(sv.maSinhVien);
            frm.ShowDialog();
        }

        private void btnKQ_Sua_Nhom_Click_1(object sender, EventArgs e)
        {
            frmKetQuaDangKyNhom frm = new frmKetQuaDangKyNhom(sv.maSinhVien);
            frm.ShowDialog();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenFROMLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenFROMLogin(object obj)
        {
            Application.Run(new frmDangNhap());
        }

        private void btnThonTinSinhVien_Click(object sender, EventArgs e)
        {
            frmThongTinSinhVien frmThongTinSV = new frmThongTinSinhVien(sv);
            frmThongTinSV.ShowDialog();
        }
    }
}
