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
using PROJECT.DAO;
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

        }
    }
}
