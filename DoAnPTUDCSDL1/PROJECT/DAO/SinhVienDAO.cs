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

        //select by ID
        public SINHVIEN GetByID(string id)
        {
            string query = "select * from SinhVien where MaSinhVien = @Id ";
            object[] para = new object[]
            {
                id
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query,para);

            DataRow item = data.Rows[0];

            string maSV = item["MaSinhVien"].ToString();
            string tenSV = item["TenSinhVien"].ToString();
            bool? phai = item["Phai"].ToString() == string.Empty ? null : (bool?)item["phai"];
            DateTime? ngaySinh = item["NgaySinh"].ToString() == string.Empty ? null : (DateTime?)item["ngaySinh"];
            string diaChi = item["DiaChi"].ToString();
            string maNganh = item["MaNganh"].ToString();

            SINHVIEN SV = new SINHVIEN(maSV, tenSV, phai, ngaySinh, diaChi, maNganh);


            return SV;
        }

        // hàm lấy sinh viên cuối cùng cuối cùng
        public SINHVIEN GetSinhVienLast()
        {
            string query = "SELECT TOP 1 * FROM SINHVIEN ORDER BY MaSinhVien DESC ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            DataRow item = data.Rows[0];
            string maSV = item["MaSinhVien"].ToString();
            string tenSV = item["TenSinhVien"].ToString();
            bool phai = (bool)item["Phai"];
            DateTime ngaySinh = (DateTime)item["NgaySinh"];
            string diaChi = item["DiaChi"].ToString();
            string maNganh = item["MaNganh"].ToString();

            SINHVIEN sv = new SINHVIEN(maSV, tenSV, phai, ngaySinh, diaChi, maNganh);

            return sv;
        }

        // tạo mã sinh viên mới
        public string CreateMaSinhVien()
        {
            string maSinhVienOld = SinhVienDAO.Instance.GetSinhVienLast().maSinhVien;
            string _2charFirst = maSinhVienOld.Substring(0, 2);
            int stt = int.Parse(maSinhVienOld.Substring(2, 3));
            string sttNew = (stt < 10) ? ("0" + (++stt)) : ("" + (++stt));
            string maSinhVienNew = _2charFirst + sttNew;
            return maSinhVienNew;
        }
    }
}
