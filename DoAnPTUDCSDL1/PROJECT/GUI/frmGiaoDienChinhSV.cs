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
    public partial class frmGiaoDienChinhSV : Form
    {
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
            lblMaSinhVien.Text = sv.maSinhVien;
            lblHoTen.Text = sv.tenSinhVien;
            lblNganh.Text =NganhBUS.Instance.GetByID(sv.maNganh).ToString();
        }
        private void btnDangKyCD_Click(object sender, EventArgs e)
        {
            frmDangKyChuyenDe frm = new frmDangKyChuyenDe();
            frm.ShowDialog();
        }
        private void btnKQ_HuyDKy_Click(object sender, EventArgs e)
        {
            frmKetQuaDangKyChuyenDeSinhVien frm = new frmKetQuaDangKyChuyenDeSinhVien();
            frm.ShowDialog();
        }
        private void btnDKyNhom_Click(object sender, EventArgs e)
        {
            frmDangKiNhom frm = new frmDangKiNhom();
            frm.ShowDialog();
        }
        private void btnKQ_Sua_Nhom_Click(object sender, EventArgs e)
        {
            frmKetQuaDangKyNhom frm = new frmKetQuaDangKyNhom();
            frm.ShowDialog();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
