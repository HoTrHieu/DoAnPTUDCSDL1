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

namespace PROJECT.GUI
{
    public partial class frmDangKyChuyenDe : Form
    {
        public frmDangKyChuyenDe()
        {
            InitializeComponent();
        }

        private void frmDangKyChuyenDe_Load(object sender, EventArgs e)
        {
            SinhVienBUS.Instance.GetAll(dgvChuyenDe);
           
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (SinhVienBUS.Instance.Update(dgvChuyenDe))
            {
                MessageBox.Show("Sửa thành công");
                         //load lại data
            }
            else
                MessageBox.Show("Lỗi");
        }
    }
}
