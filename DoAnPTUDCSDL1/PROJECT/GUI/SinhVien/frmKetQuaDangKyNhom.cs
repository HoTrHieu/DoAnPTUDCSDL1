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
    public partial class frmKetQuaDangKyNhom : Form
    {

        string MaMoCD, MaLop;
        string tenN;
        public frmKetQuaDangKyNhom()
        {
            InitializeComponent();
        }

        //public frmKetQuaDangKyNhom(SINHVIEN s)
        //{
        //    InitializeComponent();
        //    SV = s;
        //}
        private string _maSV;
        public frmKetQuaDangKyNhom(string maSV)
        {
            InitializeComponent();
            _maSV = maSV;
        }

        private void frmKetQuaDangKyNhom_Load(object sender, EventArgs e)
        {
            SINHVIEN SV = SinhVienBUS.Instance.GetByID(_maSV);
            lblMaSinhVien.Text = SV.maSinhVien;
            lblHoTen.Text = SV.tenSinhVien;
            cbMaDKChuyenDe.DataSource = ThongTinDangKyBUS.Instance.GetMaDangKyByIDSV(SV.maSinhVien);

            THONGTINDANGKY thongTDK = ThongTinDangKyBUS.Instance.GetByID(cbMaDKChuyenDe.Text);
            MaLop = thongTDK.maLop;
            MaMoCD = thongTDK.maThongTimMoChuyenDe;
            //lấy Thongtinmochuyende từ đăng ký
            THONGTINMOCHUYENDE ttMoCD = ThongTinMoChuyenDeBUS.Instance.GetByID(thongTDK.maThongTimMoChuyenDe);
            //lấy ma chuyen de tu thong tin mo chuyen de
            lblMaChuyenDe.Text = ChuyenDeBUS.Instance.GetByID(ttMoCD.maChuyenDe).maCDe;
            //lấy dữ liệu tên chuyen de:
            lblTenChuyenDe.Text = ChuyenDeBUS.Instance.GetByID(ttMoCD.maChuyenDe).tenCDe;

            //mã lớp học
            lblMaLop.Text = thongTDK.maLop;
            //ma nhom
            //THANHVIEN nhom = ThanhVienBUS.Instance.GetByIDDK(cbMaDKChuyenDe.Text);
            if (ThanhVienBUS.Instance.GetByIDDK(cbMaDKChuyenDe.Text) == null)
            {
                lblMaNhom.Text = "Chưa Đăng Ký";
                lblTenNhom.Text = "Chưa Đăng Ký";
                dgvDSThanhVien.DataSource = null;
            }
            else
            {
                NHOM nhom = NhomBUS.Instance.GetByID(ThanhVienBUS.Instance.GetByIDDK(cbMaDKChuyenDe.Text).maNhom);
                lblMaNhom.Text = nhom.maNhom;
                lblTenNhom.Text = nhom.tenNhom;
                dgvDSThanhVien.DataSource = ThanhVienBUS.Instance.GetTVbyNhom(nhom.maNhom);
                dgvDSThanhVien.Columns[0].HeaderText = "MSSV";
                dgvDSThanhVien.Columns[1].HeaderText = "Họ và tên";
                dgvDSThanhVien.Columns[2].HeaderText = "Vai trò";
            }
        }

        //private void btnChuyenNhom_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK);
        //}

        private void cbMaDKChuyenDe_SelectedValueChanged(object sender, EventArgs e)
        {

            THONGTINDANGKY thongTDK = ThongTinDangKyBUS.Instance.GetByID(cbMaDKChuyenDe.Text);
            MaLop = thongTDK.maLop;
            MaMoCD = thongTDK.maThongTimMoChuyenDe;
            //lấy Thongtinmochuyende từ đăng ký
            THONGTINMOCHUYENDE ttMoCD = ThongTinMoChuyenDeBUS.Instance.GetByID(thongTDK.maThongTimMoChuyenDe);
            //lấy ma chuyen de tu thong tin mo chuyen de
            lblMaChuyenDe.Text = ChuyenDeBUS.Instance.GetByID(ttMoCD.maChuyenDe).maCDe;
            //lấy dữ liệu tên chuyen de:
            lblTenChuyenDe.Text = ChuyenDeBUS.Instance.GetByID(ttMoCD.maChuyenDe).tenCDe;

            //mã lớp học
            lblMaLop.Text = thongTDK.maLop;
            //ma nhom
            //THANHVIEN nhom = ThanhVienBUS.Instance.GetByIDDK(cbMaDKChuyenDe.Text);
            if (ThanhVienBUS.Instance.GetByIDDK(cbMaDKChuyenDe.Text) == null)
            {
                lblMaNhom.Text = "Chưa Đăng Ký";
                lblTenNhom.Text = "Chưa Đăng Ký";
                dgvDSThanhVien.DataSource = null;
            }
            else
            {
                NHOM nhom = NhomBUS.Instance.GetByID(ThanhVienBUS.Instance.GetByIDDK(cbMaDKChuyenDe.Text).maNhom);
                lblMaNhom.Text = nhom.maNhom;
                lblTenNhom.Text = nhom.tenNhom;
                dgvDSThanhVien.DataSource = ThanhVienBUS.Instance.GetTVbyNhom(nhom.maNhom);
                //dgvDSThanhVien.DataSource = ThanhVienBUS.Instance.GetTVbyNhom(nhom.maNhom);
                dgvDSThanhVien.Columns[0].HeaderText = "MSSV";
                dgvDSThanhVien.Columns[1].HeaderText = "Họ và tên";
                dgvDSThanhVien.Columns[2].HeaderText = "Vai trò";
            }
        }

        private void btnHuyDangKy_Click_1(object sender, EventArgs e)
        {
            SINHVIEN SV = SinhVienBUS.Instance.GetByID(_maSV);
            if (ThanhVienBUS.Instance.checkTruongNhom(SV.maSinhVien, cbMaDKChuyenDe.Text))
            {
                //if (ThanhVienBUS.Instance.deleteThanhVienbyHai(cbMaDKChuyenDe.Text, lblMaNhom.Text))
                if (ThanhVienBUS.Instance.deleteThanhVienByMaNhom(lblMaNhom.Text))//xóa thành viên
                {
                    if (NhomBUS.Instance.deleteNhom(lblMaNhom.Text))//xóa nhóm
                    {
                        //ThanhVienBUS.Instance.deleteThanhVienByMaNhom(lblMaNhom.Text);
                        MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                        loadinfo();
                    }
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Bạn không phải nhóm trưởng", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnRutKhoiNhom_Click_1(object sender, EventArgs e)
        {
            SINHVIEN SV = SinhVienBUS.Instance.GetByID(_maSV);
            if (lblMaNhom.Text == "Chưa Đăng Ký")
            {
                MessageBox.Show("Không có nhóm", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (ThanhVienBUS.Instance.GetTVbyNhom(lblMaNhom.Text).Count == 1)
                {
                    if (MessageBox.Show("Nhóm có 1 thành viên, Nhóm sẽ bị xóa", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (ThanhVienBUS.Instance.deleteThanhVienbyHai(cbMaDKChuyenDe.Text, lblMaNhom.Text))//xóa thành viên
                        {
                            if (NhomBUS.Instance.deleteNhom(lblMaNhom.Text))//xóa nhóm
                            {
                                MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                                loadinfo();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    if (ThanhVienBUS.Instance.checkTruongNhom(SV.maSinhVien, cbMaDKChuyenDe.Text))
                    {
                        //ThanhVienBUS.Instance.updateTrgNhom();
                        MessageBox.Show("Trưởng nhóm không được phép rời nhóm", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        ThanhVienBUS.Instance.deleleThanhVien(cbMaDKChuyenDe.Text, lblMaNhom.Text);
                        //sau khi rút khỏi nhóm thì ds thành vien là null
                        lblMaNhom.Text = "Chưa Đăng Ký";
                        lblTenNhom.Text = "Chưa Đăng Ký";
                        dgvDSThanhVien.DataSource = null;
                    }
                }
            }
        }
        //cai nay ko xai dc, cha hieu sao
        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            //if(ThanhVienBUS.Instance.checkTruongNhom(SV.maSinhVien, cbMaDKChuyenDe.Text))
            //{
            //    if (ThanhVienBUS.Instance.deleleThanhVien(cbMaDKChuyenDe.Text, lblMaNhom.Text))
            //    {
            //        MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK);
            //    }
            //    else
            //        MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK);
            //}
            //else
            //    MessageBox.Show("Bạn không phải nhóm trưởng", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnChuyenNhom_Click_1(object sender, EventArgs e)
        {
            SINHVIEN SV = SinhVienBUS.Instance.GetByID(_maSV);
            if (lblMaNhom.Text == "Chưa Đăng Ký")
            {
                MessageBox.Show("Không có nhóm", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (ThanhVienBUS.Instance.GetTVbyNhom(lblMaNhom.Text).Count == 1)
                {
                    if (MessageBox.Show("Nhóm có 1 thành viên, Nhóm sẽ bị xóa", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (ThanhVienBUS.Instance.deleteThanhVienbyHai(cbMaDKChuyenDe.Text, lblMaNhom.Text))
                        {
                            MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                            frmChuyenNhom frmChuyenNhom = new frmChuyenNhom(_maSV, MaMoCD,cbMaDKChuyenDe.Text);
                            frmChuyenNhom.ShowDialog();
                            loadinfo();
                        }
                        else
                        {
                            MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    if (ThanhVienBUS.Instance.checkTruongNhom(SV.maSinhVien, cbMaDKChuyenDe.Text))
                    {
                        //ThanhVienBUS.Instance.updateTrgNhom();
                        MessageBox.Show("Trưởng nhóm không được phép rời nhóm", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        ThanhVienBUS.Instance.deleleThanhVien(cbMaDKChuyenDe.Text, lblMaNhom.Text);
                        loadinfo();
                      
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadinfo()
        {
            SINHVIEN SV = SinhVienBUS.Instance.GetByID(_maSV);
            cbMaDKChuyenDe.DataSource = ThongTinDangKyBUS.Instance.GetMaDangKyByIDSV(SV.maSinhVien);

            THONGTINDANGKY thongTDK = ThongTinDangKyBUS.Instance.GetByID(cbMaDKChuyenDe.Text);
            MaLop = thongTDK.maLop;
            MaMoCD = thongTDK.maThongTimMoChuyenDe;
            //lấy Thongtinmochuyende từ đăng ký
            THONGTINMOCHUYENDE ttMoCD = ThongTinMoChuyenDeBUS.Instance.GetByID(thongTDK.maThongTimMoChuyenDe);
            //lấy ma chuyen de tu thong tin mo chuyen de
            lblMaChuyenDe.Text = ChuyenDeBUS.Instance.GetByID(ttMoCD.maChuyenDe).maCDe;
            //lấy dữ liệu tên chuyen de:
            lblTenChuyenDe.Text = ChuyenDeBUS.Instance.GetByID(ttMoCD.maChuyenDe).tenCDe;

            //mã lớp học
            lblMaLop.Text = thongTDK.maLop;
            //ma nhom
            //THANHVIEN nhom = ThanhVienBUS.Instance.GetByIDDK(cbMaDKChuyenDe.Text);
            if (ThanhVienBUS.Instance.GetByIDDK(cbMaDKChuyenDe.Text) == null)
            {
                lblMaNhom.Text = "Chưa Đăng Ký";
                lblTenNhom.Text = "Chưa Đăng Ký";
                dgvDSThanhVien.DataSource = null;
            }
            else
            {
                NHOM nhom = NhomBUS.Instance.GetByID(ThanhVienBUS.Instance.GetByIDDK(cbMaDKChuyenDe.Text).maNhom);
                lblMaNhom.Text = nhom.maNhom;
                lblTenNhom.Text = nhom.tenNhom;
                dgvDSThanhVien.DataSource = ThanhVienBUS.Instance.GetTVbyNhom(nhom.maNhom);
                dgvDSThanhVien.Columns[0].HeaderText = "MSSV";
                dgvDSThanhVien.Columns[1].HeaderText = "Họ và tên";
                dgvDSThanhVien.Columns[2].HeaderText = "Vai trò";
            }
        }
    }
}
