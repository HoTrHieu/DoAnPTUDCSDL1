using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT.DTO;

namespace PROJECT.DAO
{
    public class ThongTinDangKyDAO
    {
        private static ThongTinDangKyDAO instance;
        public static ThongTinDangKyDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinDangKyDAO();
                }
                return instance;
            }
        }
        private ThongTinDangKyDAO() { }

        public List<THONGTINDANGKY> GetAll()
        {
            List<THONGTINDANGKY> thongTins = new List<THONGTINDANGKY>();

            string query = "SELECT * FROM THONTINDANGKY";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maDK = item["MaDangKy"].ToString();
                string maSV = item["MaSinhVien"].ToString();
                string maTTMCD = item["MaThongTinMoChuyenDe"].ToString();
                string maL = item["MaLop"].ToString();

                THONGTINDANGKY ttdk = new THONGTINDANGKY(maDK, maSV, maTTMCD, maL);
                thongTins.Add(ttdk);
            }

            return thongTins;
        }

        //lấy theo mã đăng ký
        public THONGTINDANGKY GetByID(string id)
        {
            string query = "SELECT * FROM THONTINDANGKY";
            object[] para = new object[]
            {
                id
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query,para);

            DataRow item = data.Rows[0];
    
            string maDK = item["MaDangKy"].ToString();
            string maSV = item["MaSinhVien"].ToString();
            string maTTMCD = item["MaThongTinMoChuyenDe"].ToString();
            string maL = item["MaLop"].ToString();

            THONGTINDANGKY ttdk = new THONGTINDANGKY(maDK, maSV, maTTMCD, maL);
            return ttdk;
        }

        public List<THONGTINDANGKY> GetAllByIDSV(string MSSV)
        {
            List<THONGTINDANGKY> thongTins = new List<THONGTINDANGKY>();

            string query = "SELECT * FROM THONTINDANGKY WHERE MaSinhVien = @masv ";
            object[] para = new object[]
            {
                MSSV,
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query,para);

            foreach(DataRow item in data.Rows)
            {
                string maDK = item["MaDangKy"].ToString();
                string maSV = item["MaSinhVien"].ToString();
                string maTTMCD = item["MaThongTinMoChuyenDe"].ToString();
                string maL = item["MaLop"].ToString();

                THONGTINDANGKY ttdk = new THONGTINDANGKY(maDK, maSV, maTTMCD, maL);
                thongTins.Add(ttdk);
            }
           
            return thongTins;
        }

        public bool Update(string id, THONGTINDANGKY ttdk)
        {
            string query = "Update THONGTINDANGKY SET MaSinhVien = @maSV , MaThongTinMoChuyenDe = @MaTTMoCD , MaLop = @MaL WHERE MaDangKy = @maOLD ";

            object[] para = new object[]
            {                
                ttdk.maSinhVien,
                ttdk.maThongTimMoChuyenDe,
                ttdk.maLop,
                id
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        //insert
        public bool Insert(THONGTINDANGKY ttdk)
        {
            string query = "Insert into THONGTINDANGKY(MaDangKy, MaSinhVien, MaThongTinMoChuyenDe, MaLop) values( @MaDK , @maSV , @MaTTMoCD , @MaL )";

            object[] para = new object[]
            {
               ttdk.maDangKy,
               ttdk.maSinhVien,
               ttdk.maThongTimMoChuyenDe,
               ttdk.maLop
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

    }
}
