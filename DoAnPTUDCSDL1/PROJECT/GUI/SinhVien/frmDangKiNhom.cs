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
       
        string MaMoCD, MaLop;
        string tenN;
        public frmDangKiNhom()
        {
            InitializeComponent();
        }
        private string _maSV;
        public frmDangKiNhom(string maSV)
        {
            _maSV = maSV;
            InitializeComponent();
        }

        //public frmDangKiNhom(SINHVIEN sv)
        //{
        //    InitializeComponent();
        //    SV = sv;
        //}
        private void frmDangKiNhom_Load(object sender, EventArgs e)
        {
            SINHVIEN SV = SinhVienBUS.Instance.GetByID(_maSV);
            lblMSSV.Text = SV.maSinhVien;
            lblTEN.Text = SV.tenSinhVien;
            //ma dang ky
            cbMaDKChuyenDe.DataSource = ThongTinDangKyBUS.Instance.GetMaDangKyByIDSV(SV.maSinhVien);                        
        }

        private void cbMaDKChuyenDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lấy thông tin đăng ký
            THONGTINDANGKY thongTDK = ThongTinDangKyBUS.Instance.GetByID(cbMaDKChuyenDe.Text);
            MaLop = thongTDK.maLop;
            MaMoCD = thongTDK.maThongTimMoChuyenDe;
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
            //thông tin thêm thành vien
            cbxMaSVDK.DataSource = ThongTinDangKyBUS.Instance.GetMaSVByIDMoCD(thongTDK.maThongTimMoChuyenDe);
            //tên của thêm thành viên
            lblTenSVDK.Text = SinhVienBUS.Instance.GetByID(cbxMaSVDK.Text).tenSinhVien;
        }

        private void btnDKNhom_Click(object sender, EventArgs e)
        {
            //trường hợp chưa thuộc nhóm nào
            if (txtTenNhom.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhóm!", "Thông báo");            
            }
          
            string maNhom = cbMaDKChuyenDe.Text.TrimEnd()+"_N";
            string tenNhom = txtTenNhom.Text;
            tenN = tenNhom;
            //bool trThai = false;           

            //them thành viên đầu tiên: là người đăng ký
            NhomBUS.Instance.insertNhom(maNhom, tenNhom, false);
            //tạo nhóm xong, mặc định thằng đầu tiên là trưởng nhóm
            ThanhVienBUS.Instance.insertThanhVien(cbMaDKChuyenDe.Text, maNhom, "trưởng nhóm");
            //sau khi đăng ký xong thì mã nhóm và tên nhóm sẽ ở trong group chọn thông tin nhóm
            lblMaNhom.Text = maNhom;
            //hiện thành viên đầu tiên là trưởng nhóm trong datagirdview
            dgvThanhVien.DataSource = ThanhVienBUS.Instance.GetAllByIDN(maNhom);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (chkDuSoLuong.Checked)
            {
                NHOM nh = new NHOM(lblMaNhom.Text, tenN, true);
                NhomBUS.Instance.updateNhom(lblMaNhom.Text, nh);
            }

            this.Close();
        }

        private void btnThemTV_Click(object sender, EventArgs e)
        {
            string maDK = ThongTinDangKyBUS.Instance.GetMaDangKyByMMML(cbxMaSVDK.Text, MaMoCD, MaLop);
            //them thanh vien
            ThanhVienBUS.Instance.insertThanhVien(maDK, lblMaNhom.Text, "thành viên");

            dgvThanhVien.Update();
            dgvThanhVien.Refresh();

        }
    }
}
