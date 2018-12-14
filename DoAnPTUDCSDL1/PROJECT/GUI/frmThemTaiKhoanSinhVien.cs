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
    public partial class frmThemTaiKhoanSinhVien : Form
    {
        GIAOVU gvu;

        public frmThemTaiKhoanSinhVien()
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
        string maSV;
        private void frmThemTaiKhoanSinhVien_Load(object sender, EventArgs e)
        {
            // load dữ liệu vào cbNganh
            foreach (var item in NganhBUS.Instance.GetAll())
            {
                cbNganh.Items.Add(new Item(item.tenNganh, item.maNganh));
            }
            cbNganh.SelectedIndex = 0;

            maSV = SinhVienBUS.Instance.CreateMaSinhVien();

            txtMSSV.ReadOnly = true;
            txtMSSV.Text = maSV;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Item nganh = (Item)cbNganh.SelectedItem;
            string maNganh = nganh.Value;
            string tenNganh = nganh.Name;

            string tenSV = txtHoTenSV.Text;
            int phai = 1;
            if (rdbNam.Checked)
            {
                phai = 1;
            }
            else if (rdbNu.Checked)
            {
                phai = 0;
            }

            string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            MessageBox.Show("Ma SV : " + maSV + "\nTenSV : " + tenSV + "\nPhai : " + int.Parse(phai.ToString()) +
                "\nNgay sinh : " + ngaySinh + "\nMa nganh : " + maNganh + "\nTen nganh : " + tenNganh);
        }
    }
}
