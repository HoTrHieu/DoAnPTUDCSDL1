//kiểm tra data đưa xuống cho DAO xử lý
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DAO;
using PROJECT.DTO;

namespace PROJECT.BUS
{
    public class SinhVienBUS
    {
        private static SinhVienBUS instance;

        public static SinhVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SinhVienBUS();
                return instance;
            }
        }

        private SinhVienBUS() { }
        public void GetAll(DataGridView data)
        {
            data.DataSource = SinhVienDAO.Instance.GetAll();
        }
        
        //Update
        public bool Update(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MaSV = row.Cells["maSinhVien"].Value.ToString();
            string TenSV = row.Cells["tenSinhVien"].Value.ToString();
            bool? Phai=(bool?) row.Cells["phai"].Value;
            DateTime? NgaySinh = (DateTime?)row.Cells["ngaySinh"].Value;
            string DiaChi = row.Cells["diaChi"].Value.ToString();
            string MaN = row.Cells["maNganh"].Value.ToString();

            SINHVIEN sv = new SINHVIEN(MaSV, TenSV, Phai, NgaySinh, DiaChi, MaN);

            return SinhVienDAO.Instance.Update(MaSV, sv);
        }

        //update sinh viên
        public bool Update(SINHVIEN sv)
        {
            return SinhVienDAO.Instance.Update(sv.maSinhVien, sv);
        }
        //get by id
        public SINHVIEN GetByID(string id)
        {
            return SinhVienDAO.Instance.GetByID(id);
        }
        /*
         * if(SinhVienBUS.Instance.Update(dtgView))
         *      {
         *          MessageBox.Show("Sửa thành công");
         *          //load lại data
         *       }
         * else
         *      MessageBox.Show("Lỗi");
         * 
         * 
         * 
         */

        public SINHVIEN GetSinhVienLast()
        {
            return SinhVienDAO.Instance.GetSinhVienLast();
        }

        public string CreateMaSinhVien()
        {
            return SinhVienDAO.Instance.CreateMaSinhVien();
        }
    }
}
