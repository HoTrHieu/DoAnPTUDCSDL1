using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT.GUI
{
    public partial class frmGiaoDienChinhGV : Form
    {
        public frmGiaoDienChinhGV()
        {
            InitializeComponent();
        }

        private void btnThemTKSV_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoanSinhVien frm = new frmThemTaiKhoanSinhVien();
            frm.ShowDialog();
        }

        private void btnDsSV_Click(object sender, EventArgs e)
        {
            //xuất danh sách sinh vien, sau nay sẽ them vào
        }

        private void btnMoCD_Click(object sender, EventArgs e)
        {
            frmMoChuyenDe frm = new frmMoChuyenDe();
            frm.ShowDialog();
        }

        private void btnDsCDMo_Click(object sender, EventArgs e)
        {
            //tạo frm ds chuyen de da mo
        }

        private void btnDsSVDK_Click(object sender, EventArgs e)
        {
            frmKetQuaDangKyChuyenDeGiaoVu frm = new frmKetQuaDangKyChuyenDeGiaoVu();
            frm.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
