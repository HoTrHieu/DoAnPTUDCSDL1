﻿using System;
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
    public partial class frmMoChuyenDe : Form
    {
        public frmMoChuyenDe()
        {
            InitializeComponent();
        }
        private string _maGVT;
        public frmMoChuyenDe(string MaGVu)
        {
            _maGVT = MaGVu;
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
        private void frmMoChuyenDe_Load(object sender, EventArgs e)
        {
            // load dữ liệu vào cbHocKy va cbNamHoc
            cbHocKy.DataSource = HocKyBUS.Instance.GetHocKy();
            cbNamHoc.DataSource = HocKyBUS.Instance.GetNienHoc();

            // load dữ liệu vào cbChuyenDeCanMo
            foreach (var item in ChuyenDeBUS.Instance.GetAll())
            {
                cbChuyenDeCanMo.Items.Add(new Item(item.tenCDe, item.maCDe));
            }

            // gán giá trị đang được chọn cho cbChuyenDeCanMo là phần tử đầu tiên
            cbChuyenDeCanMo.SelectedIndex = 0;
        }

        private void btnMoChuyenDe_Click(object sender, EventArgs e)
        {
            string nienHoc = cbNamHoc.SelectedItem.ToString();
            int hocKy = int.Parse(cbHocKy.SelectedItem.ToString());

            Item chuyenDe = (Item)cbChuyenDeCanMo.SelectedItem;
            string maCD = chuyenDe.Value;

            string ngayBD = dtpNgayBatDau.Value.ToString("yyyy-MM-dd");
            string ngayKT = dtpNgayKetThuc.Value.ToString("yyyy-MM-dd");

            string maTTMCDNew = ThongTinMoChuyenDeBUS.Instance.CreateMaTTMCD();

            //MessageBox.Show(hocKy + "\n" + nienHoc + "\n" + maGVu + "\n" + maCD + "\n" + maTTMCDNew);
            try
            {
                ThongTinMoChuyenDeBUS.Instance.insertThongTinMoChuyenDe(maTTMCDNew, hocKy, nienHoc, _maGVT, maCD, false);
                MessageBox.Show("Thêm Thông Tin Mở Chuyên Đề Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Mở chuyên đề không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
