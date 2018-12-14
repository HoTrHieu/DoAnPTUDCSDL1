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
    class GiaoVienBUS
    {
        private static GiaoVienBUS instance;

        public static GiaoVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVienBUS();
                return instance;
            }
        }

        //lấy toàn bộ danh sách Giao vien
        public List<GIAOVIEN> GetAll()
        {
            return GiaoVienDAO.Instance.GetAll();
        }

        //Update
        public bool Update(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MaGVien = row.Cells["maGVien"].Value.ToString();
            string TenGVien = row.Cells["tenGVien"].Value.ToString();
            bool? Phai = (bool?)row.Cells["phai"].Value;
            DateTime? NgaySinh = (DateTime?)row.Cells["ngaySinh"].Value;
            string DiaChi = row.Cells["diaChi"].Value.ToString();
            string MaCD = row.Cells["maChuyenDe"].Value.ToString();

            GIAOVIEN gvien = new GIAOVIEN(MaGVien, TenGVien, Phai, NgaySinh, DiaChi, MaCD);

            return GiaoVienDAO.Instance.Update(MaGVien, gvien);
        }
    }
}
