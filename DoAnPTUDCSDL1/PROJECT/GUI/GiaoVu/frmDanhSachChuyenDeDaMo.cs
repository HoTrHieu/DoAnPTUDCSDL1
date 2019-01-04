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

namespace PROJECT.GUI.GiaoVu
{
    public partial class frmDanhSachChuyenDeDaMo : Form
    {
        public frmDanhSachChuyenDeDaMo()
        {
            InitializeComponent();
        }

        private void frmDanhSachChuyenDeDaMo_Load(object sender, EventArgs e)
        {
            ThongTinMoChuyenDeBUS.Instance.GetAll(dgvDSCDMo);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // lấy vị trí dòng đang chọn
            int rowIndex = dgvDSCDMo.CurrentCell.RowIndex;

            //string mattmcd = dgvDSCDMo.Rows[rowIndex].Cells[0].Value.ToString();

            try {
                foreach (DataGridViewRow row in dgvDSCDMo.Rows)
                {
                    string mattmcd = row.Cells[0].Value.ToString();
                    bool trangThai = (bool)row.Cells[5].Value;
                    ThongTinMoChuyenDeBUS.Instance.updateTrangThai(mattmcd, trangThai);
                };
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi");
            }

            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
