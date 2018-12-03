using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT.DTO;

namespace PROJECT.DAO
{
    public class NganhDAO
    {
        private static NganhDAO instance;
        public static NganhDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NganhDAO();
                }
                return instance;
            }
        }
        private NganhDAO() { }

        public List<NGANH> GetAll()
        {
            List<NGANH> nganhs = new List<NGANH>();
            string query = "SELECT * FROM NGANH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                string MaN=item["MaNganh"].ToString();
                string TenN=item["TenNganh"].ToString();
                int SoSVHoc=(int)item["SoSinhVienTheoHoc"];
                int SoCDMax=(int)item["SoChuyenDeToiDa"];

                NGANH NG = new NGANH(MaN, TenN, SoSVHoc, SoCDMax);
                nganhs.Add(NG);
            }

            return nganhs;
        }

        public NGANH GetByID(string id)
        {
            string query = "SELECT * FORM NGANH WHERE MaNganh = @maN ";
            object[] para = new object[]
            {
                id
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            DataRow item = data.Rows[0];

            string MaN = item["MaNganh"].ToString();
            string TenN = item["TenNganh"].ToString();
            int SoSVHoc = (int)item["SoSinhVienTheoHoc"];
            int SoCDMax = (int)item["SoChuyenDeToiDa"];

            NGANH NG = new NGANH(MaN, TenN, SoSVHoc, SoCDMax);
            return NG;
        }
    }
}
