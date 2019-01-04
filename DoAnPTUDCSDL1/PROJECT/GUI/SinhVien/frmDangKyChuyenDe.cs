using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.BUS;
using PROJECT.DTO;

namespace PROJECT.GUI
{
    public partial class frmDangKyChuyenDe : Form
    {
        
        public frmDangKyChuyenDe()
        {
            InitializeComponent();
        }
        //public frmDangKyChuyenDe(SINHVIEN S)
        //{
        //    InitializeComponent();
        //    sv = S;
        //}
        private string _maSV;
        public frmDangKyChuyenDe(string maSV)
        {
            _maSV = maSV;
            InitializeComponent();
        }
        

        private void frmDangKyChuyenDe_Load(object sender, EventArgs e)
        {
            SINHVIEN sv = SinhVienBUS.Instance.GetByID(_maSV);
            //SinhVienBUS.Instance.GetAll(dgvChuyenDe);
            lblMaSV.Text = sv.maSinhVien;
            lblTen.Text = sv.tenSinhVien;
            // tạo checkbox
            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            CheckboxColumn.TrueValue = true;
            CheckboxColumn.FalseValue = false;
            CheckboxColumn.Width = 20;
            dgvChuyenDe.Columns.Add(CheckboxColumn);
            //tạo combox
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.HeaderText = "MaLop";
            
            dgvCmb.Items.Add("L1");
            dgvCmb.Items.Add("L2");
            dgvCmb.Items.Add("L3");
            dgvCmb.Items.Add("L4");
            dgvCmb.Items.Add("L5");
            dgvCmb.Name = "cmbMaLop";
            dgvChuyenDe.Columns.Add(dgvCmb);

            //lấy các chuyen de mở theo ngành
            string maN = sv.maNganh;
            dgvChuyenDe.DataSource = ChuyenDeBUS.Instance.ChuyenDeMo(maN);


            //mặc định cho lớp là L1
            foreach (DataGridViewRow row in dgvChuyenDe.Rows)
            {
                if (row.Cells[1].Value == null)
                {
                    row.Cells[1].Value = "L1";
                }
            }

            string maCD;
            //kiểm tra đã đăng ký hay chưa
            List<THONGTINDANGKY> ThongTins = ThongTinDangKyBUS.Instance.GetAllByIDSV(sv.maSinhVien);
            foreach (DataGridViewRow row in dgvChuyenDe.Rows)
            {                            
                    
                //string masv = sv.maSinhVien;
                //string maLop = row.Cells[1].Value.ToString();
                maCD = row.Cells[2].Value.ToString();
                //lay thong tin mo chuyen de cho chuyen de với trang thái đang mo
                THONGTINMOCHUYENDE temp = ThongTinMoChuyenDeBUS.Instance.GetMoChuyenDeByMaCD(maCD);
                foreach(THONGTINDANGKY ThongT in ThongTins)
                {
                    if (temp.maThongTinMoChuyenDe == ThongT.maThongTimMoChuyenDe)
                    {
                        row.Cells[0].ReadOnly = true;
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            //lblhocky, lbl nien hoa
            DataGridViewRow rowT = dgvChuyenDe.Rows[0];
            string maCDT= rowT.Cells[2].Value.ToString();
            THONGTINMOCHUYENDE tp = ThongTinMoChuyenDeBUS.Instance.GetMoChuyenDeByMaCD(maCDT);
            lblHocKi.Text = tp.hocKy.ToString();
            lblNienKhoa.Text = tp.nienHoc;

        }

        bool HaveCheck()
        {
            foreach (DataGridViewRow row in dgvChuyenDe.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value == chk.TrueValue)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            SINHVIEN sv = SinhVienBUS.Instance.GetByID(_maSV);
            if (HaveCheck())
            {
                //
                bool kq = false;
                foreach (DataGridViewRow row in dgvChuyenDe.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value == chk.TrueValue)
                    {
                        string maDK = ThongTinDangKyBUS.Instance.CreateMaDK();
                        string masv = sv.maSinhVien;
                        string maLop = row.Cells[1].Value.ToString();
                        string maCD = row.Cells[2].Value.ToString();

                        THONGTINMOCHUYENDE ttmcd = ThongTinMoChuyenDeBUS.Instance.GetMoChuyenDeByMaCD(maCD);
                        int hkCheck = ttmcd.hocKy;
                        string nienHocCheck = ttmcd.nienHoc;

                        int soLuongDaDangKy = ThongTinDangKyBUS.Instance.countByMSSV_HK_NienHoc(_maSV, hkCheck, nienHocCheck);

                       if(soLuongDaDangKy >= 3)
                        {
                            MessageBox.Show("Chỉ được đăng ký tối đa 3 chuyên đề trong một học kỳ niên học");
                        }
                        else
                        {
                            THONGTINMOCHUYENDE temp = ThongTinMoChuyenDeBUS.Instance.GetMoChuyenDeByMaCD(maCD);

                            THONGTINDANGKY ttDK = new THONGTINDANGKY(maDK, masv, temp.maThongTinMoChuyenDe, maLop);
                            //insert
                            kq = ThongTinDangKyBUS.Instance.Insert(ttDK);
                        }
                       
                    }
                }
                if (kq == true)
                {
                    btnDangKy.Enabled = false;
                    MessageBox.Show("Bạn Đã Đăng Ký thành công!");
                }
            }
            else
            {
                MessageBox.Show("Đã Đăng ký hoặc chưa chọn đăng ký!!", "Thông Báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
