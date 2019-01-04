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
            string query = "select * from CHUYENDE WHERE MaChuyenDe = @maNganh ";
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

        //get chuyen de duoc mo
        public List<CHUYENDE> ChuyenDeMo(string maN)
        {
            List<CHUYENDE> chuyendes = new List<CHUYENDE>();
            string query = "select * from CHUYENDE cd where cd.MaNganh = @maN and cd.MaChuyenDe in ( " +
                "select ttm.MaChuyenDe from THONGTINMOCHUYENDE ttm where ttm.TrangThai = 1 )";
            object[] para = new object[]
{
                maN
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

        public bool Insert(CHUYENDE cd)
        {
            string query = "Insert into CHUYENDE(MaChuyenDe, TenChuyenDe, SoSinhVienToiDa, MaNganh) values( @maCD , @tenCD , @svMAX , @maN )";

            object[] para = new object[]
            {
               cd.maCDe,
               cd.tenCDe,
               cd.soSV,
               cd.maNganh
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public string CreateMaCD()
        {
            string query = "select max(c.MaChuyenDe) as N'MaChuyenDe' from CHUYENDE c " +
                "where LEN(c.MaChuyenDe) >= all(select len(x.MaChuyenDe) from CHUYENDE x)";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            DataRow item = data.Rows[0];

            string maCDNew = item["MaChuyenDe"].ToString().TrimEnd();
            string x = maCDNew.Substring(maCDNew.Length - 2);
            string y = (int.Parse(x) + 1).ToString();
            return "CD" + y;
        }

        public bool deleteChuyenDe(string maCD)
        {
            string query = "delete from CHUYENDE where MaChuyenDe = @maCD ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCD }) > 0)
                return true;
            return false;
        }

        public bool Update(string maCD, CHUYENDE cd)
        {
            string query = "Update CHUYENDE SET TenChuyenDe = @tecd , SoSinhVienToiDa = @svMAX , MaNganh = @maN WHERE MaChuyenDe = @maCD ";

            object[] para = new object[]
            {
                cd.tenCDe,
                cd.soSV,
                cd.maNganh,
                maCD
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
