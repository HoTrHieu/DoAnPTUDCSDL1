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
                string maSV = item["MaSinhVien"].ToString();
                string tenSV = item["TenSinhVien"].ToString();
                bool? phai =item["Phai"].ToString()== string.Empty ? null: (bool?) item["phai"];
                DateTime? ngaySinh = item["NgaySinh"].ToString() ==string.Empty ? null:(DateTime?) item["ngaySinh"];
                string diaChi=item["DiaChi"].ToString();
                string maNganh=item["MaNganh"].ToString();

                SINHVIEN sv = new SINHVIEN(maSV,tenSV,phai,ngaySinh,diaChi,maNganh);
                sinhViens.Add(sv);

            }

            return sinhViens;
        }
        //update
        public bool Update(string id, SINHVIEN sv)
        {
            string query = "Update SINHVIEN SET TenSinhVien = @ten , Phai = @phai , NgaySinh = @NS , DiaChi = @diaChi , MaNganh = @maN WHERE MaSinhVien = @maOLD ";

            object[] para = new object[] 
            {
                sv.tenSinhVien,
                sv.phai,
                sv.ngaySinh,
                sv.diaChi,
                sv.maNganh,
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
