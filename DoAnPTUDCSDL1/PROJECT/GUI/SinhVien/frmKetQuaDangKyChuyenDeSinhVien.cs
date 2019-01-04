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
    public partial class frmKetQuaDangKyChuyenDeSinhVien : Form
    {
        public frmKetQuaDangKyChuyenDeSinhVien()
        {
            InitializeComponent();
        }
        private string _maSV;
        public frmKetQuaDangKyChuyenDeSinhVien(string maSV)
        {
            _maSV = maSV;
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

        private void frmKetQuaDangKyChuyenDeSinhVien_Load(object sender, EventArgs e)
        {
            // load dữ liệu vào cbHocKy va cbNamHoc
            cmbHocKy.DataSource = HocKyBUS.Instance.GetHocKy();
            cmbNamHoc.DataSource = HocKyBUS.Instance.GetNienHoc();

            //string maSV = lblMaSV.Text;
            SINHVIEN sv = SinhVienBUS.Instance.GetByID(_maSV);
            string tenSV = sv.tenSinhVien;

            dgvKetQuaDangKy.DataSource = ThongTinDangKyBUS.Instance.GetTTDKCDeSinhVien(_maSV);
            dgvKetQuaDangKy.Columns[0].HeaderText = "Mã CĐ";
            dgvKetQuaDangKy.Columns[1].HeaderText = "Tên Chuyên Đề";
            dgvKetQuaDangKy.Columns[2].HeaderText = "Ngày Bắt Đầu";
            dgvKetQuaDangKy.Columns[3].HeaderText = "Ngày Kết Thúc";
            dgvKetQuaDangKy.Columns[4].HeaderText = "Tên Lớp";

            if (dgvKetQuaDangKy.RowCount == 0)
            {
                MessageBox.Show("Không có chuyên đề nào được đăng ký");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string nienHoc = cmbNamHoc.SelectedItem.ToString();
            int hocKy = int.Parse(cmbHocKy.SelectedItem.ToString());

            dgvKetQuaDangKy.DataSource = ThongTinDangKyBUS.Instance.GetTTDKCDeSinhVien(_maSV, hocKy, nienHoc);
            dgvKetQuaDangKy.Columns[0].HeaderText = "Mã CĐ";
            dgvKetQuaDangKy.Columns[1].HeaderText = "Tên Chuyên Đề";
            dgvKetQuaDangKy.Columns[2].HeaderText = "Ngày Bắt Đầu";
            dgvKetQuaDangKy.Columns[3].HeaderText = "Ngày Kết Thúc";
            dgvKetQuaDangKy.Columns[4].HeaderText = "Tên Lớp";

            if (dgvKetQuaDangKy.RowCount == 0)
            {
                MessageBox.Show("Không có chuyên đề nào được đăng ký \nVào học kì : " + hocKy + " năm : " + nienHoc);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            frmKetQuaDangKyChuyenDeSinhVien_Load(sender,  e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            // lấy vị trí dòng đang chọn
            int rowIndex = dgvKetQuaDangKy.CurrentCell.RowIndex;

            // lấy mã chuyên đề từ ô 0 của row đang chọn
            string maCD = dgvKetQuaDangKy.Rows[rowIndex].Cells[0].Value.ToString();

            // lấy mở thông tin mở chuyên đề từ mã chuyên đề
            THONGTINMOCHUYENDE ttmcd = ThongTinMoChuyenDeBUS.Instance.GetByMaCD(maCD);
            string maMCD = ttmcd.maThongTinMoChuyenDe;

            // lấy mã đăng ký dựa vào mssv và mã thông tin mở chuyên đề
            THONGTINDANGKY ttdk = ThongTinDangKyBUS.Instance.GetMaDangKyByMCD_MSSV(_maSV, maMCD);
            string maDK = ttdk.maDangKy;

            THANHVIEN tv = ThanhVienBUS.Instance.GetByIDDK(maDK);
            if (tv != null)
            {            
                string manhom = tv.maNhom;

                // kiểm tra vai trò ( true : trưởng nhóm, false: thành viên)
                bool vaitro = ThanhVienBUS.Instance.checkTruongNhom(_maSV, maDK);

                // nếu là thành viên
                if (vaitro == false)
                {
                    // kiểm tra có xoá thành viên được không
                    bool trangthai = ThanhVienBUS.Instance.deleteThanhVienbyHai(maDK, manhom);

                    // nếu xoá được thực hiện xoá đăng ký chuyên đề
                    if (trangthai)
                    {
                        // nếu xoá đăng ký chuyên đề thành công
                        if (ThongTinDangKyBUS.Instance.DeleteByMaDK(maDK))
                        {
                            MessageBox.Show("Huỷ đăng ký chuyên đề thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvKetQuaDangKy.DataSource = null;
                            dgvKetQuaDangKy.DataSource = ThongTinDangKyBUS.Instance.GetTTDKCDeSinhVien(_maSV);
                            dgvKetQuaDangKy.Columns[0].HeaderText = "Mã CĐ";
                            dgvKetQuaDangKy.Columns[1].HeaderText = "Tên Chuyên Đề";
                            dgvKetQuaDangKy.Columns[2].HeaderText = "Ngày Bắt Đầu";
                            dgvKetQuaDangKy.Columns[3].HeaderText = "Ngày Kết Thúc";
                            dgvKetQuaDangKy.Columns[4].HeaderText = "Tên Lớp";

                        }
                        // ngược lại
                        else
                        {
                            MessageBox.Show("Huỷ đăng ký chuyên đề không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    // nếu không xoá được ra khỏi nhóm
                    else
                    {
                        MessageBox.Show("Xoá không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                // nếu vai trò là trưởng nhóm => xoá hết thành viên trong nhóm, sau đó, xoá nhóm mà trưởng nhóm đã tạo
                // tiếp theo, trưởng nhóm thực hiện huỷ đăng ký chuyên đề theo mong muốn
                else if (vaitro == true)
            {
                // nếu xoá thành viên thành công
                if (ThanhVienBUS.Instance.deleteThanhVienByMaNhom(manhom))
                {
                    // nếu xoá nhóm thành công
                    if (NhomBUS.Instance.deleteNhom(manhom))
                    {
                        if (ThongTinDangKyBUS.Instance.DeleteByMaDK(maDK))
                        {
                            MessageBox.Show("Huỷ đăng ký chuyên đề thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Huỷ đăng ký chuyên đề không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            }
            else
            {
                if (ThongTinDangKyBUS.Instance.DeleteByMaDK(maDK))
                {
                    MessageBox.Show("Huỷ đăng ký chuyên đề thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKetQuaDangKy.DataSource = null;
                    dgvKetQuaDangKy.DataSource = ThongTinDangKyBUS.Instance.GetTTDKCDeSinhVien(_maSV);
                    dgvKetQuaDangKy.Columns[0].HeaderText = "Mã CĐ";
                    dgvKetQuaDangKy.Columns[1].HeaderText = "Tên Chuyên Đề";
                    dgvKetQuaDangKy.Columns[2].HeaderText = "Ngày Bắt Đầu";
                    dgvKetQuaDangKy.Columns[3].HeaderText = "Ngày Kết Thúc";
                    dgvKetQuaDangKy.Columns[4].HeaderText = "Tên Lớp";

                }
            }
        }
    }
}
