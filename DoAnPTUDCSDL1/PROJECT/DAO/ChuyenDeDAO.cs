using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PROJECT.DTO;

namespace PROJECT.DAO
{
    class ChuyenDeDAO
    {
        private static ChuyenDeDAO instance;
        public static ChuyenDeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChuyenDeDAO();
                }
                return instance;
            }
        }
        private ChuyenDeDAO() { }

        public List<CHUYENDE> GetAll ()
        {
            List<CHUYENDE> chuyendes = new List<CHUYENDE>();
            string query = "select * from CHUYENDE";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string MaCD = item["MaChuyenDe"].ToString();
                string TenCD = item["TenChuyenDe"].ToString();
                int SoSVMax = (int)item["SoSinhVienToiDa"];
                string MaN = item["MaNganh"].ToString();

                CHUYENDE CD = new CHUYENDE(MaCD, TenCD, SoSVMax, MaN);
                chuyendes.Add(CD);
            }

            return chuyendes;
        }

        public List<CHUYENDE> GetByMaNganh(string maNganh)
        {
            List<CHUYENDE> chuyendes = new List<CHUYENDE>();
            string query = "select * from CHUYENDE WHERE MaChuyenDe = @maNganh";
            object[] para = new object[]
{
                maNganh
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                string MaCD = item["MaChuyenDe"].ToString();
                string TenCD = item["TenChuyenDe"].ToString();
                int SoSVMax = (int)item["SoSinhVienToiDa"];
                string MaN = item["MaNganh"].ToString();

                CHUYENDE CD = new CHUYENDE(MaCD, TenCD, SoSVMax, MaN);
                chuyendes.Add(CD);
            }

            return chuyendes;
        }

        public CHUYENDE GetByID(string id)
        {
            string query = "SELECT * FROM CHUYENDE WHERE MaChuyenDe = @maCD ";
            object[] para = new object[]
            {
                id
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            DataRow item = data.Rows[0];

            string MaCD = item["MaChuyenDe"].ToString();
            string TenCD = item["TenChuyenDe"].ToString();
            int SoSVMax = (int)item["SoSinhVienToiDa"];
            string MaN = item["MaNganh"].ToString();

            CHUYENDE CD = new CHUYENDE(MaCD, TenCD, SoSVMax, MaN);
            return CD;
        }


    }
}
