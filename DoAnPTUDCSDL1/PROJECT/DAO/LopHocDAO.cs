using System;
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
    public class LopHocDAO
    {
        private static LopHocDAO instance;

        public static LopHocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopHocDAO();
                return instance;
            }
        }

        private LopHocDAO() { }

        public List<LOPHOC> GetAll()
        {
            List<LOPHOC> lopHocs = new List<LOPHOC>();
            string query = "select * from LopHoc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maLop = item["maLop"].ToString();
                string tenLop = item["tenLop"].ToString();

                LOPHOC lh = new LOPHOC(maLop, tenLop);
                lopHocs.Add(lh);

            }

            return lopHocs;
        }

        // lấy lớp dựa vào mã
        public LOPHOC GetByID(string malop)
        {
            string query = "select MaLop, TenLop from LopHoc where MaLop = @maLop ";
            DataTable data =  DataProvider.Instance.ExecuteQuery(query, new object[] { malop });
            DataRow item = data.Rows[0];
            string maLop = item["MaLop"].ToString();
            string tenLop = item["TenLop"].ToString();

            LOPHOC lh = new LOPHOC(maLop, tenLop);
            return lh;
        }

        // thêm 1 lớp học mới
        public bool insertLopHoc(LOPHOC lh)
        {
            string query = "insert into LopHoc values(@maLop , @tenLop)";
            object[] para = new object[]
            {
                lh.maLop,
                lh.tenLop
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        // xóa 1 lớp học dựa vào Mã Lớp
        public bool deleteLopHoc(string maLop)
        {
            string query = "delete from LopHoc where MaLop = @maLop";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLop }) > 0)
                return true;
            return false;
        }

        // chỉnh sửa tên lớp học dựa vào Mã Lớp
        public bool updateLopHoc(string maLop, LOPHOC lh)
        {
            string query = "update LopHoc set TenLop = @tenLop where MaLop = @maLop";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { lh.tenLop, lh.maLop }) > 0)
                return true;
            return false;
        }
    }
}
