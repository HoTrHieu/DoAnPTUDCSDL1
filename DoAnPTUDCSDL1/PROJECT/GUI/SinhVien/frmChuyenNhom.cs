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

namespace PROJECT.GUI
{
    public partial class frmChuyenNhom : Form
    {
        public frmChuyenNhom()
        {
            InitializeComponent();
        }
        string _maSV, _maMCD,_maDK;
        NHOM nhom;
        public frmChuyenNhom(string MaSV,string MaMo,string maDK)
        {
            InitializeComponent();
            _maSV = MaSV;
            _maMCD = MaMo;
            _maDK = maDK;
        }

        private void btnChuyenNhom_Click(object sender, EventArgs e)
        {
            if (ThanhVienBUS.Instance.insertThanhVien(_maDK, nhom.maNhom, "thành viên"))
            {
                MessageBox.Show("Chuyển Thành Công", "Thông Báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Chuyển Thất Bại", "Thông Báo");
                this.Close();
            }
        }

        private void frmChuyenNhom_Load(object sender, EventArgs e)
        {
            cbxMaNhom.DataSource = NhomBUS.Instance.GetListMaNhom(_maMCD);
            nhom = NhomBUS.Instance.GetByID(cbxMaNhom.Text);
            lblTenNhom.Text = nhom.tenNhom;

        }
    }
}
