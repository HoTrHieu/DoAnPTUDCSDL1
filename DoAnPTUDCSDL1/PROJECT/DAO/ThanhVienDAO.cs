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
    public class ThanhVienDAO
    {
        private static ThanhVienDAO instance;

        public static ThanhVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThanhVienDAO();
                return instance;
            }
        }

        public ThanhVienDAO() { }

        // lấy tất cả thông tin trong bảng thành viên
        public List<THANHVIEN> GetAll()
        {
            List<THANHVIEN> thanhViens = new List<THANHVIEN>();
            string query = "select * from ThanhVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maDangKy = item["maDangKy"].ToString();
                string maNhom = item["maNhom"].ToString();
                string vaiTro = item["vaiTro"].ToString();

                THANHVIEN tv = new THANHVIEN(maDangKy, maNhom, vaiTro);
                thanhViens.Add(tv);
            }
            return thanhViens;
        }
        // lấy thông tin từ mã đăng ký và mã nhóm
        public THANHVIEN GetByIDs(string madangky, string manhom)
        {
            string query = "select MaDangKy, MaNhom, VaiTro where MaDangKy = @madangky and MaNhom = @manhom ";
            object[] para = new object[]
            {
                madangky, manhom
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            DataRow item = data.Rows[0];

            string maDangKy = item["MaDangKy"].ToString();
            string maNhom = item["MaNhom"].ToString();
            string vaiTro = item["VaiTro"].ToString();

            THANHVIEN tv = new THANHVIEN(maDangKy, maNhom, vaiTro);
            return tv;
        }

        // thêm thông tin 1 thành viên
        public bool insertThanhVien(THANHVIEN tv)
        {
            string query = "insert into ThanhVien(MaDangKy, MaNhom, VaiTro) values(@maDangKy , @maNhom , @vaiTro )";
            object[] para = new object[]
            {
                tv.maDangKy,
                tv.maNhom,
                tv.vaiTro
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;

        }

        // xóa/rút 1 thành viên khỏi 1 nhóm thuộc MaDangKy và MaNhom
        public bool deleteThanhVien(string maDangKy, string maNhom)
        {
            string query = "delete from ThanhVien where MaDangKy = @maDangKy , MaNhom = @maNhom ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDangKy, maNhom }) > 0)
                return true;
            return false;
        }

        // cập nhật vai tro cua 1 thành viên trong 1 nhom
        public bool updateThanhVien(string maDangKy, string maNhom, THANHVIEN tv)
        {
            string query = "update ThanhVien set VaiTro = @vaiTro where MaDangKy = @maDangKy and MaNhom = @maNhom ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { tv.vaiTro, maDangKy, maNhom }) > 0)
                return true;
            return false;
        }

        //getAllByIDNhom
        // lấy tất cả thông tin trong bảng thành viên
        public List<THANHVIEN> GetAllByIDN(string mNhom)
        {
            List<THANHVIEN> thanhViens = new List<THANHVIEN>();
            string query = "select * from ThanhVien where MaNhom= @maN ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[]{ mNhom});

            foreach (DataRow item in data.Rows)
            {
                string maDangKy = item["maDangKy"].ToString();
                string maNhom = item["maNhom"].ToString();
                string vaiTro = item["vaiTro"].ToString();

                THANHVIEN tv = new THANHVIEN(maDangKy, maNhom, vaiTro);
                thanhViens.Add(tv);
            }
            return thanhViens;
        }
    }
}
