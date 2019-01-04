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
using Timer = System.Windows.Forms.Timer;
using PROJECT.GUI.GiaoVu;

namespace PROJECT.GUI
{
    public partial class frmGiaoDienChinhGV : Form
    {
        Thread th;//dong from cu mo form moi  
        GIAOVU gvu;
        Timer t = new Timer();
        public frmGiaoDienChinhGV(TAIKHOAN tk)
        {
            InitializeComponent();
            TRaGVU(tk);
        }
        public frmGiaoDienChinhGV()
        {
            InitializeComponent();
        }
        private void btnThemTKSV_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoanSinhVien frm = new frmThemTaiKhoanSinhVien(gvu.maGVu);
            frm.ShowDialog();
        }

        private void btnDsSV_Click(object sender, EventArgs e)
        {
            //xuất danh sách sinh vien, sau nay sẽ them vào
            frmDSSinhVien frm = new frmDSSinhVien();
            frm.ShowDialog();
        }

        private void btnMoCD_Click(object sender, EventArgs e)
        {
            frmMoChuyenDe frm = new frmMoChuyenDe(gvu.maGVu);
            frm.ShowDialog();
        }

        private void btnDsCDMo_Click(object sender, EventArgs e)
        {
            frmDanhSachChuyenDeDaMo dscdm = new frmDanhSachChuyenDeDaMo();
            dscdm.ShowDialog();
        }

        private void btnDsSVDK_Click(object sender, EventArgs e)
        {
            frmKetQuaDangKyChuyenDeGiaoVu frm = new frmKetQuaDangKyChuyenDeGiaoVu();
            frm.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
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
        private void frmGiaoDienChinhGV_Load(object sender, EventArgs e)
        {
            lblMaGV.Text = gvu.maGVu;
            lblTenGVU.Text = gvu.tenGVu;

            // đồng hồ
            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method
        }

        public bool TRaGVU(TAIKHOAN tk)
        {
            gvu = GiaoVuBUS.Instance.GetByID(tk.maTaiKhoan);
            if (gvu != null)
                return true;
            return false;
        }


        // thêm đồng hồ

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            lblClock.Text = time;
        }
    }
}
