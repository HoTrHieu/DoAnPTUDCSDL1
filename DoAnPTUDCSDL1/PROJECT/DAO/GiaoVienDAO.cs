using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DTO;

namespace PROJECT.DAO
{
    class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public static GiaoVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVienDAO();
                return instance;
            }
        }

        private GiaoVienDAO() { }

        public List<GIAOVIEN> GetAll()
        {
            List<GIAOVIEN> giaoviens = new List<GIAOVIEN>();
            string query = "SELECT * FROM GIAOVIEN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string maGV = item["MaGiaoVien"].ToString();
                string tenGV = item["TenGiaoVien"].ToString();
                bool phai = (bool)item["Phai"];
                DateTime ngaySinh = (DateTime)item["NgaySinh"];
                string diaChi = item["DiaChi"].ToString();
                string maCD = item["MaChuyenDe"].ToString();

                GIAOVIEN gv = new GIAOVIEN(maGV, tenGV, phai, ngaySinh, diaChi, maCD);
                giaoviens.Add(gv);
            }

            return giaoviens;
        }

        //update
        public bool Update(string id, GIAOVIEN gvien)
        {
            string query = "Update GIAOVIEN SET TenGiaoVien = @ten , Phai = @phai , NgaySinh = @NS , DiaChi = @diaChi , MaChuyenDe = @maCD WHERE MaGiaoVien = @maOLD ";

            object[] para = new object[]
            {
                gvien.tenGVien,
                gvien.phai,
                gvien.ngaySinh,
                gvien.diaChi,
                gvien.maChuyenDe,
                id
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

    }
}
