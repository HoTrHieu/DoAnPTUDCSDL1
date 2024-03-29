﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DTO;

namespace PROJECT.DAO
{
    public class ThongTinMoChuyenDeDAO
    {
        private static ThongTinMoChuyenDeDAO instance;

        public static ThongTinMoChuyenDeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongTinMoChuyenDeDAO();
                return instance;
            }
        }

        private ThongTinMoChuyenDeDAO() { }

        public List<THONGTINMOCHUYENDE> GetAll()
        {
            List<THONGTINMOCHUYENDE> thongTinMoChuyenDes = new List<THONGTINMOCHUYENDE>();
            string query = "select * from ThongTinMoChuyenDe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maThongTinMoChuyenDe = item["maThongTinMoChuyenDe"].ToString();
                int hocKy = (int)item["hocKy"];
                string nienHoc = item["nienHoc"].ToString();
                string maGiaoVu = item["maGiaoVu"].ToString();
                string maChuyenDe = item["maChuyenDe"].ToString();
                bool trangThai = (bool)item["TrangThai"];
                THONGTINMOCHUYENDE ttmcd = new THONGTINMOCHUYENDE(maThongTinMoChuyenDe, hocKy, nienHoc, maGiaoVu, maChuyenDe, trangThai);
                thongTinMoChuyenDes.Add(ttmcd);
            }
            return thongTinMoChuyenDes;
        }
        // lấy thông tin mở chuyên đề dựa vào MaThongTinMoChuyenDe
        public THONGTINMOCHUYENDE GetByID(string MaTTMCDe)
        {
            string query = "select MaThongTinMoChuyenDe, HocKy, NienHoc, MaGiaoVu, MaChuyenDe, TrangThai " +
                "from ThongTinMoChuyenDe where MaThongTinMoChuyenDe = @MaTTMCDe ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaTTMCDe });
            DataRow item = data.Rows[0];

            string maThongTinMoChuyenDe = item["MaThongTinMoChuyenDe"].ToString();
            int hocKy = (int)item["HocKy"];
            string nienHoc = item["NienHoc"].ToString();
            string maGiaoVu = item["MaGiaoVu"].ToString();
            string maChuyenDe = item["MaChuyenDe"].ToString();
            bool trangThai = (bool)item["TrangThai"];
            THONGTINMOCHUYENDE ttmcd = new THONGTINMOCHUYENDE(maThongTinMoChuyenDe, hocKy, nienHoc, maGiaoVu, maChuyenDe, trangThai);
            return ttmcd;
        }

        // thêm một thông tin mở chuyên đề
        public bool insertThongTinMoChuyenDe(THONGTINMOCHUYENDE ttmcd)
        {
            string query = "insert into ThongTinMoChuyenDe values( @maThongTinMoChuyenDe ,  @hocKy , @nienHoc , @maGiaoVu , @maChuyenDe , @trangThai )";
            object[] para = new object[]
            {
                ttmcd.maThongTinMoChuyenDe,
                ttmcd.hocKy,
                ttmcd.nienHoc,
                ttmcd.maGiaoVu,
                ttmcd.maChuyenDe,
                ttmcd.trangThai
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        // xóa 1 thông tin mở chuyên đề dựa vào MaThongTinMoChuyenDe
        public bool deleteThongTinMoChuyenDe(string maThongTinMoChuyenDe)
        {
            string query = "delete from ThongTinMoChuyenDe where MaThongTinMoChuyenDe = @maThongTinMoChuyenDe ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { maThongTinMoChuyenDe }) > 0)
                return true;
            return false;
        }

        // cập nhật thông tin chuyên đề dựa vào MaThongTinMoChuyenDe
        public bool updateThongTinMoChuyenDe(string MaTTMCDe, THONGTINMOCHUYENDE ttmcd)
        {
            string query = "update ThongTinMoChuyenDe " +
                "set HocKy = @hocKy , NienHoc = @nienHoc , MaGiaoVu = @maGiaoVu , MaChuyenDe = @maChuyenDe " +
                "where MaThongTinMoChuyenDe = @maThongTinMoChuyenDe ";
            object[] para = new object[]
            {
                ttmcd.maThongTinMoChuyenDe,
                ttmcd.hocKy,
                ttmcd.nienHoc,
                ttmcd.maGiaoVu,
                ttmcd.maChuyenDe
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }


        public List<THONGTINMOCHUYENDE> GetAllByIDSV(string maSV)
        {
            //List<THONGTINDANGKY> ttDK = ThongTinDangKyBUS

            List<THONGTINMOCHUYENDE> thongTinMoChuyenDes = new List<THONGTINMOCHUYENDE>();
            string query = "select * from ThongTinMoChuyenDe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maThongTinMoChuyenDe = item["maThongTinMoChuyenDe"].ToString();
                int hocKy = (int)item["hocKy"];
                string nienHoc = item["nienHoc"].ToString();
                string maGiaoVu = item["maGiaoVu"].ToString();
                string maChuyenDe = item["maChuyenDe"].ToString();
                bool trangThai = (bool)item["TrangThai"];
                THONGTINMOCHUYENDE ttmcd = new THONGTINMOCHUYENDE(maThongTinMoChuyenDe, hocKy, nienHoc, maGiaoVu, maChuyenDe, trangThai);
                thongTinMoChuyenDes.Add(ttmcd);
            }
            return thongTinMoChuyenDes;
        }

        // hàm lấy thông tin mở chuyên đề cuối cùng
        public THONGTINMOCHUYENDE GetThongTinMoChuyenDeLast()
        {
            string query = "SELECT TOP 1 * FROM THONGTINMOCHUYENDE ORDER BY MaThongTinMoChuyenDe DESC ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            DataRow item = data.Rows[0];
            string maTTMCD = item["MaThongTinMoChuyenDe"].ToString();
            int hocKy = (int)item["HocKy"];
            string nienHoc = item["NienHoc"].ToString();
            string maGVu = item["MaGiaoVu"].ToString();
            string maCDe = item["MaChuyenDe"].ToString();
            bool trangThai = (bool)item["TrangThai"];
            THONGTINMOCHUYENDE ttmcd = new THONGTINMOCHUYENDE(maTTMCD, hocKy, nienHoc, maGVu, maCDe, trangThai);

            return ttmcd;
        }

        // tạo mã thông tin mở chuyên đề mới
        public string CreateMaTTMCD()
        {
            string query = "select max(t.MaThongTinMoChuyenDe) as N'MaThongTinMoChuyenDe' from THONGTINMOCHUYENDE t where LEN(t.MaThongTinMoChuyenDe) >= all(select len(x.MaThongTinMoChuyenDe) from THONGTINMOCHUYENDE x)";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            DataRow item = data.Rows[0];

            string maTTMCD = item["MaThongTinMoChuyenDe"].ToString().TrimEnd();
            string x = maTTMCD.Substring(maTTMCD.Length - 2);
            string y = (int.Parse(x) + 1).ToString();
            return "MCD" + y;
        }

        //get thong tin mo chuyen de theo ma nganh
        public List<THONGTINMOCHUYENDE> GetAllByMaNganh(string maN)
        {
            //List<THONGTINDANGKY> ttDK = ThongTinDangKyBUS
           
            List<THONGTINMOCHUYENDE> thongTinMoChuyenDes = new List<THONGTINMOCHUYENDE>();
            string query = "select * from THONGTINMOCHUYENDE t where t.MaChuyenDe in " +
                "(select cd.MaChuyenDe from CHUYENDE cd where cd.MaNganh = @maN )";
            object[] para = new object[]
            {
                maN
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string maThongTinMoChuyenDe = item["maThongTinMoChuyenDe"].ToString();
                int hocKy = (int)item["hocKy"];
                string nienHoc = item["nienHoc"].ToString();
                string maGiaoVu = item["maGiaoVu"].ToString();
                string maChuyenDe = item["maChuyenDe"].ToString();
                bool trangThai = (bool)item["TrangThai"];
                THONGTINMOCHUYENDE ttmcd = new THONGTINMOCHUYENDE(maThongTinMoChuyenDe, hocKy, nienHoc, maGiaoVu, maChuyenDe, trangThai);
                thongTinMoChuyenDes.Add(ttmcd);
            }
            return thongTinMoChuyenDes;
        }

        //get by ma nganh
        public THONGTINMOCHUYENDE GetMoChuyenDeByMaCD(string maCD)
        {
            string query = "SELECT * FROM THONGTINMOCHUYENDE where MaChuyenDe = @maCD and TrangThai = 1 ";
            object[] para = new object[]
            {
                maCD
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query,para);

            DataRow item = data.Rows[0];
            string maTTMCD = item["MaThongTinMoChuyenDe"].ToString();
            int hocKy = (int)item["HocKy"];
            string nienHoc = item["NienHoc"].ToString();
            string maGVu = item["MaGiaoVu"].ToString();
            string maCDe = item["MaChuyenDe"].ToString();
            bool trangThai = (bool)item["TrangThai"];
            THONGTINMOCHUYENDE ttmcd = new THONGTINMOCHUYENDE(maTTMCD, hocKy, nienHoc, maGVu, maCDe, trangThai);

            return ttmcd;
        }

        public THONGTINMOCHUYENDE GetByMaCD(string maCD)
        {
            string query = "SELECT * FROM THONGTINMOCHUYENDE where MaChuyenDe = @maCD ";
            object[] para = new object[]
            {
                maCD
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);

            DataRow item = data.Rows[0];
            string maTTMCD = item["MaThongTinMoChuyenDe"].ToString();
            int hocKy = (int)item["HocKy"];
            string nienHoc = item["NienHoc"].ToString();
            string maGVu = item["MaGiaoVu"].ToString();
            string maCDe = item["MaChuyenDe"].ToString();
            bool trangThai = (bool)item["TrangThai"];
            THONGTINMOCHUYENDE ttmcd = new THONGTINMOCHUYENDE(maTTMCD, hocKy, nienHoc, maGVu, maCDe, trangThai);

            return ttmcd;
        }

        public bool updateTrangThai(string MaTTMCDe, bool trangThai)
        {
            string query = "update ThongTinMoChuyenDe " +
                "set TrangThai = @trangthai where MaThongTinMoChuyenDe = @maThongTinMoChuyenDe ";
            object[] para = new object[]
            {
               trangThai, MaTTMCDe
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}
