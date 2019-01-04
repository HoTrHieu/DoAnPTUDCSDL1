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
    public partial class frmDSSinhVien : Form
    {
        public frmDSSinhVien()
        {
            InitializeComponent();
        }

        private void frmDSSinhVien_Load(object sender, EventArgs e)
        {
            //cbNganh.DataSource = NganhBUS.Instance.GetAll();
            SinhVienBUS.Instance.GetAll(dgvDSSV);
        }
    }
}
