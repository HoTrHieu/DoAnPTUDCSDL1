using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT.DTO;

namespace PROJECT.DAO
{
    class HocKyDAO
    {
        private static HocKyDAO instance;
        public static HocKyDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocKyDAO();
                }
                return instance;
            }
        }
        private HocKyDAO() { }

        public List<HOCKY> GetAll()
        {
            List<HOCKY> hockys = new List<HOCKY>();
            string query = "SELECT * FROM HOCKY";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int HocKy = (int)item["HocKy"];
                string NienKhoa = item["NienHoc"].ToString();
                DateTime? NgayBatDau = item["NgayBatDau"].ToString() == string.Empty ? null : (DateTime?)item["NgayBatDau"];
                DateTime? NgayKatThuc = item["NgayKetThuc"].ToString() == string.Empty ? null : (DateTime?)item["NgayKetThuc"];

                HOCKY HK = new HOCKY(HocKy, NienKhoa, NgayBatDau, NgayKatThuc);
                hockys.Add(HK);
            }

            return hockys;
        }

        public List<HOCKY> GetByNienKhoa(string NK)
        {
            List<HOCKY> hockys = new List<HOCKY>();
            string query = "SELECT * FROM HOCKY WHERE NienHoc= @nienHoc ";
            object[] para = new object[]
            {
                NK
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int HocKy = (int)item["HocKy"];
                string NienKhoa = item["NienHoc"].ToString();
                DateTime? NgayBatDau = item["NgayBatDau"].ToString() == string.Empty ? null : (DateTime?)item["NgayBatDau"];
                DateTime? NgayKatThuc = item["NgayKetThuc"].ToString() == string.Empty ? null : (DateTime?)item["NgayKetThuc"];

                HOCKY HK = new HOCKY(HocKy, NienKhoa, NgayBatDau, NgayKatThuc);
                hockys.Add(HK);
            }

            return hockys;
        }

        public List<int> GetHocKy()
        {
            List<int> lHocKy = new List<int>();
            string query = "SELECT DISTINCT HocKy FROM HOCKY";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int HocKy = (int)item["HocKy"];

                lHocKy.Add(HocKy);
            }

            return lHocKy;
        }

        public List<string> GetNienHoc()
        {
            List<string> lNienHoc = new List<string>();
            string query = "SELECT DISTINCT NienHoc FROM HOCKY";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string NienHoc = item["NienHoc"].ToString();

                lNienHoc.Add(NienHoc);
            }

            return lNienHoc;
        }
    }
}
