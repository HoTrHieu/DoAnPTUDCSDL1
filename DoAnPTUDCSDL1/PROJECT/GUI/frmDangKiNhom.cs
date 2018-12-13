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

            //ma dang ky
            cbMaDKChuyenDe.DataSource = ThongTinDangKyBUS.Instance.GetMaDangKyByIDSV(SV.maSinhVien);

                        
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


            //lấy thông tin đăng ký
            THONGTINDANGKY thongTDK = ThongTinDangKyBUS.Instance.GetByID(cbMaDKChuyenDe.Text);
            //lấy Thongtinmochuyende từ đăng ký
            THONGTINMOCHUYENDE ttMoCD = ThongTinMoChuyenDeBUS.Instance.GetByID(thongTDK.maThongTimMoChuyenDe);
            //lấy ma chuyen de tu thong tin mo chuyen de
            lblMaChuyenDe.Text = ChuyenDeBUS.Instance.GetByID(ttMoCD.maChuyenDe).maCDe;
            //lấy dữ liệu tên chuyen de:
            lblTenChuyenDe.Text = ChuyenDeBUS.Instance.GetByID(ttMoCD.maChuyenDe).tenCDe;

            //mã lớp học
            lblMaLop.Text = thongTDK.maLop;

            //học kỳ
            lblHocKi.Text = ttMoCD.hocKy.ToString();
            //niên học
            lblNienKhoa.Text = ttMoCD.nienHoc;
        }

        private void btnDKNhom_Click(object sender, EventArgs e)
        {
            if (txtTenNhom.Text == "" && cbMaNhom.Text == null)
            {
                MessageBox.Show("Bạn phải nhập tên nhóm!", "Thông báo");
            }
            if (txtTenNhom.Text != "" && cbMaNhom.Text != "")
            {
                MessageBox.Show("Bạn đã chọn nhóm! Bỏ chọn để đăng ký!", "Thông Báo");
            }

            string maNhom = cbMaDKChuyenDe.Text+"_N";
            string tenNhom = txtTenNhom.Text;
            bool trThai = false;           

            //them thành viên đầu tiên: là người đăng ký
            NhomBUS.Instance.insertNhom(maNhom, tenNhom, false);
        }
    }
}
