using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT.DTO;

namespace PROJECT.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
        }

        private TaiKhoanDAO() { }
        /////////////
        public List<TAIKHOAN> GetAll()
        {
            List<TAIKHOAN> taiKhoans = new List<TAIKHOAN>();
            string query = "select * from TaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maTK = item["MaTaiKhoan"].ToString();
                string matK = item["MatKhau"].ToString();
                string loaiTK = item["LoaiTaiKhoan"].ToString();
                string maGV = item["MaGiaoVuTao"].ToString();

                TAIKHOAN tk = new TAIKHOAN(maTK, matK, loaiTK, maGV);
                taiKhoans.Add(tk);

            }

            return taiKhoans;
        }
        //update
        public bool Update(string id, TAIKHOAN tk)
        {
            string query = "Update TAIKHOAN SET matKhau = @matK , loaiTaiKhoan = @loaiTK , maGiaoVu = @maGV WHERE maTaiKhoan = @maOLD ";

            object[] para = new object[]
            {
                tk.matKhau,
                tk.loaiTaiKhoan,
                tk.maGiaoVuTao,
                tk.maTaiKhoan,
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        //insert
        public bool Insert(TAIKHOAN tk)
        {
            string query = "Insert into TAIKHOAN(maTaiKhoan, matKhau, loaiTaiKhoan, maGiaoVuTao) values( @maTK , @matK , @loaiTK , @maGV )";

            object[] para = new object[]
            {
                tk.maTaiKhoan,
                tk.matKhau,
                tk.loaiTaiKhoan,
                tk.maGiaoVuTao
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        
        //getbyid
        public TAIKHOAN GetByID(string id)
        {
            string query = "select maTaiKhoan, matKhau, loaiTaiKhoan, maGiaoVuTao FROM TAIKHOAN WHERE maTaiKhoan= @id ";
            object[] para = new object[]
            {
                id
            };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            DataRow item = data.Rows[0];
            string maTK = item["maTaiKhoan"].ToString();
            string matK = item["matKhau"].ToString();
            string loaiTK = item["loaiTaiKhoan"].ToString();
            string maGV = item["maGiaoVuTao"].ToString();

            TAIKHOAN tk = new TAIKHOAN(maTK, matK, loaiTK, maGV);

            return tk;
        }
    }
}
