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
            string query = "insert into Nhom values(@maNhom , @tenNhom , @trangThai )";
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
    }
}
