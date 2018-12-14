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
    class GiaoVuDAO
    {
        private static GiaoVuDAO instance;

        public static GiaoVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVuDAO();
                return instance;
            }
        }

        private GiaoVuDAO() { }

        public List<GIAOVU> GetAll()
        {
            List<GIAOVU> giaovus = new List<GIAOVU>();
            string query = "SELECT * FROM GIAOVU";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string maGVu = item["MaGiaoVu"].ToString();
                string tenGVu = item["TenGiaoVu"].ToString();
                bool phai = (bool)item["Phai"];
                DateTime ngaySinh = (DateTime)item["NgaySinh"];
                string diaChi = item["DiaChi"].ToString();

                GIAOVU gv = new GIAOVU(maGVu, tenGVu, phai, ngaySinh, diaChi);
                giaovus.Add(gv);
            }

            return giaovus;
        }

        //update
        public bool Update(string id, GIAOVU gvu)
        {
            string query = "Update GIAOVU SET TenGiaoVu = @ten , Phai = @phai , NgaySinh = @NS , DiaChi = @diaChi WHERE MaGiaoVu = @maOLD ";

            object[] para = new object[]
            {
                gvu.tenGVu,
                gvu.phai,
                gvu.ngaySinh,
                gvu.diaChi,
                id
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        //get by id
        public GIAOVU GetByID(string id)
        {
            string query = "select * from GIAOVU where MaGiaoVu = @Id ";
            object[] para = new object[]
            {
                id
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);

            DataRow item = data.Rows[0];

            string maGVU = item["MaGiaoVu"].ToString();
            string tenGVU = item["TenGiaoVu"].ToString();
            bool? phai = item["Phai"].ToString() == string.Empty ? null : (bool?)item["phai"];
            DateTime? ngaySinh = item["NgaySinh"].ToString() == string.Empty ? null : (DateTime?)item["ngaySinh"];
            string diaChi = item["DiaChi"].ToString();
            
            GIAOVU GVU = new GIAOVU(maGVU, tenGVU, phai, ngaySinh, diaChi);

            return GVU;
        }


    }
}
