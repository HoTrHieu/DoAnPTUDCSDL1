using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT.DTO;

namespace PROJECT.DAO
{
    public class ThongTinDangKyDAO
    {
        private static ThongTinDangKyDAO instance;
        public static ThongTinDangKyDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinDangKyDAO();
                }
                return instance;
            }
        }
        private ThongTinDangKyDAO() { }

        public List<THONGTINDANGKY> GetAll()
        {
            List<THONGTINDANGKY> thongTins = new List<THONGTINDANGKY>();

            string query = "SELECT * FROM THONTINDANGKY";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maDK = item["MaDangKy"].ToString();
                string maSV = item["MaSinhVien"].ToString();
                string maTTMCD = item["MaThongTinMoChuyenDe"].ToString();
                string maL = item["MaLop"].ToString();

                THONGTINDANGKY ttdk = new THONGTINDANGKY(maDK, maSV, maTTMCD, maL);
                thongTins.Add(ttdk);
            }

            return thongTins;
        }

        //lấy theo mã đăng ký
        public THONGTINDANGKY GetByID(string id)
        {
            string query = "SELECT * FROM THONGTINDANGKY WHERE MaDangKy = @maDK ";
            object[] para = new object[]
            {
                id
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query,para);

            DataRow item = data.Rows[0];
    
            string maDK = item["MaDangKy"].ToString();
            string maSV = item["MaSinhVien"].ToString();
            string maTTMCD = item["MaThongTinMoChuyenDe"].ToString();
            string maL = item["MaLop"].ToString();

            THONGTINDANGKY ttdk = new THONGTINDANGKY(maDK, maSV, maTTMCD, maL);
            return ttdk;
        }

        public List<THONGTINDANGKY> GetAllByIDSV(string MSSV)
        {
            List<THONGTINDANGKY> thongTins = new List<THONGTINDANGKY>();

            string query = "SELECT * FROM THONGTINDANGKY WHERE MaSinhVien = @masv ";
            object[] para = new object[]
            {
                MSSV,
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query,para);

            foreach(DataRow item in data.Rows)
            {
                string maDK = item["MaDangKy"].ToString();
                string maSV = item["MaSinhVien"].ToString();
                string maTTMCD = item["MaThongTinMoChuyenDe"].ToString();
                string maL = item["MaLop"].ToString();

                THONGTINDANGKY ttdk = new THONGTINDANGKY(maDK, maSV, maTTMCD, maL);
                thongTins.Add(ttdk);
            }
           
            return thongTins;
        }

        public bool Update(string id, THONGTINDANGKY ttdk)
        {
            string query = "Update THONGTINDANGKY SET MaSinhVien = @maSV , MaThongTinMoChuyenDe = @MaTTMoCD , MaLop = @MaL WHERE MaDangKy = @maOLD ";

            object[] para = new object[]
            {                
                ttdk.maSinhVien,
                ttdk.maThongTimMoChuyenDe,
                ttdk.maLop,
                id
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        //insert
        public bool Insert(THONGTINDANGKY ttdk)
        {
            string query = "Insert into THONGTINDANGKY(MaDangKy, MaSinhVien, MaThongTinMoChuyenDe, MaLop) values( @MaDK , @maSV , @MaTTMoCD , @MaL )";

            object[] para = new object[]
            {
               ttdk.maDangKy,
               ttdk.maSinhVien,
               ttdk.maThongTimMoChuyenDe,
               ttdk.maLop
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        //get ma dang ky from id sinh vien
        public List<string> GetMaDangKyByIDSV(string MSSV)
        {
            List<string> lMaDK = new List<string>();

            string query = "SELECT MaDangKy FROM THONGTINDANGKY WHERE MaSinhVien = @masv ";
            object[] para = new object[]
            {
                MSSV,
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string maDK = item["MaDangKy"].ToString();

                lMaDK.Add(maDK);
            }
            return lMaDK;
        }

        public List<string> GetMaSVByIDMoCD(string maMo)
        {
            List<string> lMaMo = new List<string>();

            string query = "SELECT MaSinhVien FROM THONGTINDANGKY WHERE MaThongTinMoChuyenDe = @maMo ";
            object[] para = new object[]
            {
                maMo,
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string maDK = item["MaSinhVien"].ToString();

                lMaMo.Add(maDK);
            }
            return lMaMo;
        }

        public string GetMaDangKyByMMML(string maSV, string maMo, string maLop)
        {
            string MaDK;

            string query = "SELECT MaDangKy FROM THONGTINDANGKY WHERE MaSinhVien= @maSV , MaThongTinMoChuyenDe = @maMo , MaLop= @maL ";
            object[] para = new object[]
            {
                maSV,maMo,maLop
            };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
           // DataRow item = data.Rows[0];

            return data.Rows[0]["MaDangKy"].ToString();
            
        }

        // tạo list lấy tất cả thông tin đăng ký chuyên đề
        public List<Tuple<int, string, string, string, string, string, string>> GetAllThongTinDangKyChuyenDeSinhVien()
        {

            string query = "select ttmcd.HocKy, ttmcd.NienHoc, lh.TenLop, sv.MaSinhVien, sv.TenSinhVien, gv.TenGiaoVien, cd.TenChuyenDe " +
                "from THONGTINDANGKY ttdk, NGANH ng, SINHVIEN sv, GIAOVIEN gv, THONGTINMOCHUYENDE ttmcd, LOPHOC lh, CHUYENDE cd " +
                "where ttdk.MaSinhVien = sv.MaSinhVien and sv.MaNganh = ng.MaNganh and ttmcd.MaThongTinMoChuyenDe = ttdk.MaThongTinMoChuyenDe " +
                "and ttdk.MaLop = lh.MaLop and ttmcd.MaChuyenDe = gv.MaChuyenDe and ng.MaNganh = cd.MaNganh " +
                "Order By HocKy, NienHoc, TenLop, MaSinhVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<Tuple<int, string, string, string, string, string, string>> list = new List<Tuple<int, string, string, string, string, string, string>>();
            foreach (DataRow item in data.Rows)
            {
                int hocKy = (int)item["HocKy"];
                string nienHoc = item["NienHoc"].ToString();
                string tenLop = item["TenLop"].ToString();
                string maSinhVien = item["MaSinhVien"].ToString();
                string tenSinhVien = item["TenSinhVien"].ToString();
                string tenGiaoVien = item["TenGiaoVien"].ToString();
                string tenChuyenDe = item["TenChuyenDe"].ToString();
                nienHoc = nienHoc.Trim(' ');

                list.Add(new Tuple<int, string, string, string, string, string, string>(hocKy, nienHoc, tenLop, maSinhVien, tenSinhVien, tenGiaoVien, tenChuyenDe));
            }
            return list;
        }

        // tạo list lấy tất cả thông tin đăng ký chuyên đề
        public List<Tuple<int, string, string, string, string, string, string>> GetAllThongTinDangKyChuyenDeSinhVienTheoDieuKien(int HK, string NH, string maCD)
        {

            string query = "select ttmcd.HocKy, ttmcd.NienHoc, lh.TenLop, sv.MaSinhVien, sv.TenSinhVien, gv.TenGiaoVien, cd.TenChuyenDe " +
                "from THONGTINDANGKY ttdk, NGANH ng, SINHVIEN sv, GIAOVIEN gv, THONGTINMOCHUYENDE ttmcd, LOPHOC lh, CHUYENDE cd " +
                "where ttdk.MaSinhVien = sv.MaSinhVien and sv.MaNganh = ng.MaNganh and ttmcd.MaThongTinMoChuyenDe = ttdk.MaThongTinMoChuyenDe " +
                "and ttdk.MaLop = lh.MaLop and ttmcd.MaChuyenDe = gv.MaChuyenDe and ng.MaNganh = cd.MaNganh " +
                "and ttmcd.HocKy = @hocKy and ttmcd.NienHoc = @nienHoc and ttmcd.MaChuyenDe = @maCD " +
                "Order By HocKy, NienHoc, TenLop, MaSinhVien";

            object[] para = new object[]
            {
                HK, NH, maCD
            };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);

            List<Tuple<int, string, string, string, string, string, string>> list = new List<Tuple<int, string, string, string, string, string, string>>();
            foreach (DataRow item in data.Rows)
            {
                int hocKy = (int)item["HocKy"];
                string nienHoc = item["NienHoc"].ToString();
                string tenLop = item["TenLop"].ToString();
                string maSinhVien = item["MaSinhVien"].ToString();
                string tenSinhVien = item["TenSinhVien"].ToString();
                string tenGiaoVien = item["TenGiaoVien"].ToString();
                string tenChuyenDe = item["TenChuyenDe"].ToString();
                nienHoc = nienHoc.Trim(' ');

                list.Add(new Tuple<int, string, string, string, string, string, string>(hocKy, nienHoc, tenLop, maSinhVien, tenSinhVien, tenGiaoVien, tenChuyenDe));
            }
            return list;
        }

        // tạo list lấy thông tin đăng ký chuyên đề của sinh viên dựa vào mã sv
        public List<Tuple<string, string, string, string, string>> GetTTDKCDeSinhVien(string maSV)
        {

            string query = "SELECT CD.MaChuyenDe, CD.TenChuyenDe, HK.NgayBatDau, HK.NgayKetThuc, LH.TenLop " +
                "FROM SINHVIEN SV, LOPHOC LH, THONGTINDANGKY TTDK, THONGTINMOCHUYENDE TTMCD, CHUYENDE CD, HOCKY HK " +
                "WHERE SV.MaSinhVien = TTDK.MaSinhVien AND LH.MaLop = TTDK.MaLop AND " +
                "TTMCD.MaThongTinMoChuyenDe = TTDK.MaThongTinMoChuyenDe AND " +
                " TTMCD.MaChuyenDe = CD.MaChuyenDe AND HK.HocKy = TTMCD.HocKy AND HK.NienHoc = TTMCD.NienHoc " +
                "AND SV.MaSinhVien = @maSV ";

            object[] para = new object[]
            {
                maSV
            };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);

            List<Tuple<string, string, string, string, string>> list = new List<Tuple<string, string, string, string, string>>();
            foreach (DataRow item in data.Rows)
            {
                string maCD = item["MaChuyenDe"].ToString();
                string tenCD = item["tenChuyenDe"].ToString();
                string ngayBD = item["NgayBatDau"].ToString();
                ngayBD = ngayBD.Substring(0, 10);
                string ngayKT = item["NgayKetThuc"].ToString();
                ngayKT = ngayKT.Substring(0, 10);
                string tenLop = item["TenLop"].ToString();
                list.Add(new Tuple<string, string, string, string, string>(maCD, tenCD, ngayBD, ngayKT, tenLop));
            }
            return list;
        }

        // tạo list lấy thông tin đăng ký chuyên đề của sinh viên dựa vào mã sv, học kỳ , nien học
        public List<Tuple<string, string, string, string, string>> GetTTDKCDeSinhVien(string maSV, int hocKy, string nienHoc)
        {

            string query = "SELECT CD.MaChuyenDe, CD.TenChuyenDe, HK.NgayBatDau, HK.NgayKetThuc, LH.TenLop " +
                "FROM SINHVIEN SV, LOPHOC LH, THONGTINDANGKY TTDK, THONGTINMOCHUYENDE TTMCD, CHUYENDE CD, HOCKY HK " +
                "WHERE SV.MaSinhVien = TTDK.MaSinhVien AND LH.MaLop = TTDK.MaLop AND " +
                "TTMCD.MaThongTinMoChuyenDe = TTDK.MaThongTinMoChuyenDe AND " +
                " TTMCD.MaChuyenDe = CD.MaChuyenDe AND HK.HocKy = TTMCD.HocKy AND HK.NienHoc = TTMCD.NienHoc " +
                "AND SV.MaSinhVien = @maSV AND HK.HocKy = @hocKy AND HK.NienHoc = @nienHoc ";

            object[] para = new object[]
            {
                maSV, hocKy, nienHoc
            };

            DataTable data = DataProvider.Instance.ExecuteQuery(query,para);

            List<Tuple<string, string, string, string, string>> list = new List<Tuple<string, string, string, string, string>>();
            foreach (DataRow item in data.Rows)
            {
                string maCD = item["MaChuyenDe"].ToString();
                string tenCD = item["tenChuyenDe"].ToString();
                string ngayBD = item["NgayBatDau"].ToString();
                ngayBD = ngayBD.Substring(0, 10);
                string ngayKT = item["NgayKetThuc"].ToString();
                ngayKT = ngayKT.Substring(0, 10);
                string tenLop = item["TenLop"].ToString();
                list.Add(new Tuple<string, string, string, string, string>(maCD, tenCD, ngayBD, ngayKT, tenLop));
            }
            return list;
        }

    }
}
