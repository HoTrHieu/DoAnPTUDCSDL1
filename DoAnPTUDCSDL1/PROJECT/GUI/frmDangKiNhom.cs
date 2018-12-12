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
    public partial class frmDangKiNhom : Form
    {
        SINHVIEN SV = SinhVienBUS.Instance.GetByID("SV01");
        public frmDangKiNhom()
        {
            InitializeComponent();
        }

        public frmDangKiNhom(SINHVIEN sv)
        {
            InitializeComponent();
            SV = sv;
        }
        private void frmDangKiNhom_Load(object sender, EventArgs e)
        {
            lblMSSV.Text = SV.maSinhVien;
            lblTEN.Text = SV.tenSinhVien;

            //List<CHUYENDE> lstCD = ChuyenDeBUS.Instance.GetAll();


            ////lblMaChuyenDe.Text = db.CHUYENDEs.First(p => p.TenChuyenDe == cbTenChuyenDe.Text).MaChuyenDe;

            //cbMaDKChuyenDe.DataSource = from mdk in db.THONGTINDANGKies
            //                            where (
            //                                     mdk.MaSinhVien == sv.MaSinhVien
            //                                 )
            //                            select mdk.MaDangKy;

            ////lblMaChuyenDe.Text = db.THONGTINMOCHUYENDEs.First(p => p.MaThongTinMoChuyenDe == cbMaDKChuyenDe.Text).MaChuyenDe;

        }

        private void cbMaDKChuyenDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LINQDataContext db = new LINQDataContext();
            //THONGTINDANGKY dk = db.THONGTINDANGKies.First(p => p.MaDangKy == cbMaDKChuyenDe.Text);
            //string maMCD = db.THONGTINDANGKies.First(p => p.MaDangKy == cbMaDKChuyenDe.Text).MaThongTinMoChuyenDe;
            //lblMaChuyenDe.Text = db.THONGTINMOCHUYENDEs.First(p => p.MaThongTinMoChuyenDe == maMCD).MaChuyenDe;

            ////ten chuyen de
            //lblTenChuyenDe.Text = db.CHUYENDEs.First(p => p.MaChuyenDe == lblMaChuyenDe.Text).TenChuyenDe;
            ////ma lop
            //lblMaLop.Text = db.LOPHOCs.First(p => p.MaLop == dk.MaLop).MaLop;

            //lblHocKi.Text = db.THONGTINMOCHUYENDEs.First(p => p.MaThongTinMoChuyenDe == maMCD).HocKy.ToString();

            //lblNienKhoa.Text = db.THONGTINMOCHUYENDEs.First(p => p.MaThongTinMoChuyenDe == maMCD).NienHoc;

        }

        private void btnDKNhom_Click(object sender, EventArgs e)
        {
            //if (txtTenNhom.Text == "")
            //{

            //}
        }
    }
}
