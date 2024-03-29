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
    public class NhomDAO
    {
        private static NhomDAO instance;

        public static NhomDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhomDAO();
                return instance;
            }
        }

        private NhomDAO() { }

        public List<NHOM> GetAll()
        {
            List<NHOM> nhoms = new List<NHOM>();
            string query = "select * from Nhom";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maNhom = item["maNhom"].ToString();
                string tenNhom = item["tenNhom"].ToString();
                bool trangThai = (bool)item["trangThai"];
        

                NHOM nh = new NHOM(maNhom, tenNhom, trangThai);
                nhoms.Add(nh);
            }
            return nhoms;
        }

        // lấy nhóm dựa vào mã nhóm
        public NHOM GetByID(string manhom)
        {
            string query = "select MaNhom, TenNhom, TrangThai from Nhom where MaNhom = @manhom ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{ manhom});
            DataRow item = data.Rows[0];

            string maNhom = item["MaNhom"].ToString();
            string tenNhom = item["TenNhom"].ToString();
            bool trangThai = (bool)item["TrangThai"];

            NHOM nh = new NHOM(maNhom, tenNhom, trangThai);
            return nh;
        }

        // thêm nhóm mới từ Mã Nhóm, Tên Nhóm và Trạng Thái của nhóm
        public bool insertNhom(NHOM nh)
        {
            string query = "insert into Nhom values( @maNhom , @tenNhom , @trangThai )";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { nh.maNhom, nh.tenNhom, nh.trangThai }) > 0)
                return true;
            return false;
        }

        // xóa nhóm dựa vào mã nhóm
        public bool deleteNhom(string maNhom)
        {
            string query = "delete from Nhom where MaNhom = @maNhom ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNhom }) > 0)
                return true;
            return false;
        }

        // sửa nhóm (sửa tên nhóm, trạng thái) dựa vào mã nhóm
        public  bool updateNhom(string maNhom, NHOM nh)
        {
            string query = "update Nhom set TenNhom = @tenNhom , TrangThai = @trangThai where MaNhom = @maNhom ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { nh.tenNhom, nh.trangThai, maNhom }) > 0)
                return true;
            return false;
        }

        //lấy nhóm cuối cùng trong danh sách
        public NHOM GetNhomLast()
        {
            string query = "select * from NHOM";
            List<NHOM> lstNhom = new List<NHOM>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                string maNhom = item["MaNhom"].ToString();
                string tenNhom = item["TenNhom"].ToString();
                bool trangThai =(bool)item["TrangThai"];

                NHOM nh = new NHOM(maNhom, tenNhom, trangThai);
                lstNhom.Add(nh);
            }
            return lstNhom.Last();
        }

        //tạo mã
        public string CreateCode()
        {
            string query = "select max(t.MaNhom) as N'MaNhom' from NHOM t where LEN(t.MaNhom)" +
                ">= all(select len(x.MaNhom) from NHOM x)";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            DataRow item = data.Rows[0];

            string maDK = item["MaNhom"].ToString().TrimEnd();
            string x = maDK.Substring(2);
            string y = (int.Parse(x) + 1).ToString();
            return "NH" + y;
        }

        //
        public List<string> GetListMaNhom(string MaMCD)
        {
            List<string> lstMaN = new List<string>();
            string query = "SELECT DISTINCT(tv.MaNhom) AS N'MaNhom' FROM THONGTINMOCHUYENDE tm, THONGTINDANGKY td, " +
                "THANHVIEN tv , NHOM nh WHERE tm.MaThongTinMoChuyenDe = td.MaThongTinMoChuyenDe AND td.MaDangKy = tv.MaDangKy " +
                "AND tv.MaNhom = nh.MaNhom AND nh.TrangThai = 0 AND tm.MaThongTinMoChuyenDe = @maMoCD ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaMCD });
            
            foreach (DataRow item in data.Rows)
            {
                string maNhom = item["MaNhom"].ToString();
                lstMaN.Add(maNhom);
            }

            return lstMaN;                
        }

    }
}
