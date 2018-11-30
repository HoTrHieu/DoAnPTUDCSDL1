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
    public class SinhVienDAO
    {
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SinhVienDAO();
                return instance;
            }
        }

        private SinhVienDAO() { }

        public List<SINHVIEN> GetAll()
        {
            List<SINHVIEN> sinhViens = new List<SINHVIEN>();
            string query = "select * from SinhVien";
            DataTable data= DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maSV = item["maSinhVien"].ToString();
                string tenSV = item["tenSinhVien"].ToString();
                bool? phai =item["phai"].ToString()== string.Empty ? null: (bool?) item["phai"];
                DateTime? ngaySinh = item["ngaySinh"].ToString() ==string.Empty ? null:(DateTime?) item["ngaySinh"];
                string diaChi=item["diaChi"].ToString();
                string maNganh=item["maNganh"].ToString();

                SINHVIEN sv = new SINHVIEN(maSV,tenSV,phai,ngaySinh,diaChi,maNganh);
                sinhViens.Add(sv);

            }

            return sinhViens;
        }

    }
}
