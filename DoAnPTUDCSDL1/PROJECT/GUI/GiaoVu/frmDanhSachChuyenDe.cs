using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.BUS;
using PROJECT.DTO;

namespace PROJECT.GUI.GiaoVu
{
    public partial class frmDanhSachChuyenDe : Form
    {
        public frmDanhSachChuyenDe()
        {
            InitializeComponent();
        }

        private void frmDanhSachChuyenDe_Load(object sender, EventArgs e)
        {
            dgvChuyenDe.DataSource = ChuyenDeBUS.Instance.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemChuyenDe themchuyende = new frmThemChuyenDe();
            themchuyende.ShowDialog();
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvChuyenDe.CurrentCell.RowIndex;

            // lấy mã chuyên đề từ ô 0 của row đang chọn
            string maCD = dgvChuyenDe.Rows[rowIndex].Cells[0].Value.ToString();

            try
            {
                if (ChuyenDeBUS.Instance.deleteChuyenDe(maCD))
                {
                    MessageBox.Show("Xoá chuyên đề " + maCD.Trim() + " thành công!");
                }
                else
                {
                    MessageBox.Show("Xoá chuyên đề " + maCD.Trim() + " không thành công!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể xoá chuyên đề do có sinh viên đăng ký");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvChuyenDe.CurrentCell.RowIndex;

            // lấy mã chuyên đề từ ô 0 của row đang chọn
            string maCD = dgvChuyenDe.Rows[rowIndex].Cells[0].Value.ToString();

            frmSuaChuyenDe suaChuyenDe = new frmSuaChuyenDe(maCD);
            suaChuyenDe.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
