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
    public partial class frmThemChuyenDe : Form
    {
        public frmThemChuyenDe()
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

        private void btnTaoChuyenDe_Click(object sender, EventArgs e)
        {
            string tenCD = txtTenChuyenDe.Text;
            int soSVMAX = int.Parse(txtSVToiDa.Text);

            Item nganh = (Item)cmbNganh.SelectedItem;
            string maNganh = nganh.Value.Trim();

            string maCD = ChuyenDeBUS.Instance.CreateMaCD();
            MessageBox.Show(tenCD + "\n" + soSVMAX + "\n" + maNganh + "\n" + maCD);
            CHUYENDE cd = new CHUYENDE(maCD, tenCD, soSVMAX, maNganh);

            if (ChuyenDeBUS.Instance.Insert(cd))
            {
                MessageBox.Show("Thêm chuyên đề thành công");
            }
            else
            {
                MessageBox.Show("Thêm chuyên đề không thành công");
            }



        }

        private void frmThemChuyenDe_Load(object sender, EventArgs e)
        {
            foreach (var item in NganhBUS.Instance.GetAll())
            {
                cmbNganh.Items.Add(new Item(item.tenNganh, item.maNganh));
            }
            cmbNganh.SelectedIndex = 0;


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
