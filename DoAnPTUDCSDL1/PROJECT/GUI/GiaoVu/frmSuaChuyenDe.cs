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
    public partial class frmSuaChuyenDe : Form
    {
        public frmSuaChuyenDe()
        {
            InitializeComponent();
        }

        private class Item
        {
            public string Name, Value;
            public Item(string name, string value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        private string _maCD;
        private int _vitri;
        public frmSuaChuyenDe(string maCD)
        {
            _maCD = maCD;
            InitializeComponent();
        }

        private void frmSuaChuyenDe_Load(object sender, EventArgs e)
        {
            foreach (var item in NganhBUS.Instance.GetAll())
            {
                cmbNganh.Items.Add(new Item(item.tenNganh, item.maNganh));
            }

            CHUYENDE cd = ChuyenDeBUS.Instance.GetByID(_maCD);
           // string maNganh = 
            int vitri = int.Parse(cd.maNganh.Substring(1, 1));

            cmbNganh.SelectedIndex = vitri-1;
            txtTenChuyenDe.Text = cd.tenCDe;
            txtSVToiDa.Text = cd.soSV.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tenCD = txtTenChuyenDe.Text;
            int soSVMAX = int.Parse(txtSVToiDa.Text);

            Item nganh = (Item)cmbNganh.SelectedItem;
            string maNganh = nganh.Value.Trim();

            string maCD = _maCD;
            
            CHUYENDE cd = new CHUYENDE(maCD, tenCD, soSVMAX, maNganh);

            if (ChuyenDeBUS.Instance.Update(maCD , cd))
            {
                MessageBox.Show("Cập nhật chuyên đề thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật chuyên đề không thành công");
            }
        }
    }
}
