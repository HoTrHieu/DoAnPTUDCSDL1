using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DAO;
using PROJECT.DTO;

namespace PROJECT.BUS
{
    public class ThongTinDangKyBUS
    {
        private static ThongTinDangKyBUS instance;
        public static ThongTinDangKyBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinDangKyBUS();
                }
                return instance;
            }
        }
        public ThongTinDangKyBUS() { }

        public void GetAll(DataGridView data)
        {
            data.DataSource = ThongTinDangKyDAO.Instance.GetAll();
        }

        //lấy thong tin của 1 đang ký
        public THONGTINDANGKY GetByID(string id)
        {
            return ThongTinDangKyDAO.Instance.GetByID(id);
        }

        //lấy list thong tin dang ky của 1 thằng sinh vien
        public void GetAllByIDSV(DataGridView data, string MSSV)
        {
            data.DataSource = ThongTinDangKyDAO.Instance.GetAllByIDSV(MSSV);
        }

        //lấy ma đăng ký theo sinh vien
        public List<string> GetMaDangKyByIDSV(string MSSV)
        {
            return ThongTinDangKyDAO.Instance.GetMaDangKyByIDSV(MSSV);
        }

        //lấy mã sinh vien
        public List<string> GetMaSVByIDMoCD(string maMo)
        {
            return ThongTinDangKyDAO.Instance.GetMaSVByIDMoCD(maMo);
        }
        //lấy mã đăng ký by mamochuyende va ma lop
        public string GetMaDangKyByMMML(string maSV, string maMo,string maLop)
        {
            return ThongTinDangKyDAO.Instance.GetMaDangKyByMMML(maSV, maMo, maLop);
        }

        public List<Tuple<int, string, string, string, string, string, string>> GetAllThongTinDangKyChuyenDeSinhVien()
        {
            return ThongTinDangKyDAO.Instance.GetAllThongTinDangKyChuyenDeSinhVien();
        }

        public List<Tuple<int, string, string, string, string, string, string>> GetAllThongTinDangKyChuyenDeSinhVienTheoDieuKien(int hocKy, string nienHoc, string maCD)
        {
            return ThongTinDangKyDAO.Instance.GetAllThongTinDangKyChuyenDeSinhVienTheoDieuKien(hocKy, nienHoc, maCD);
        }

        public List<Tuple<string, string, string, string, string>> GetTTDKCDeSinhVien(string maSV, int hocKy, string nienHoc)
        {
            return ThongTinDangKyDAO.Instance.GetTTDKCDeSinhVien(maSV, hocKy, nienHoc);
        }

        public List<Tuple<string, string, string, string, string>> GetTTDKCDeSinhVien(string maSV)
        {
            return ThongTinDangKyDAO.Instance.GetTTDKCDeSinhVien(maSV);
        }

        //tạo mã đăng ký
        public string CreateMaDK()
        {
            return ThongTinDangKyDAO.Instance.CreateMaDK();
        }

        //insert
        public bool Insert(THONGTINDANGKY tt)
        {
            return ThongTinDangKyDAO.Instance.Insert(tt);
        }

        //get all by IDSV
        public List<THONGTINDANGKY> GetAllByIDSV(string masv)
        {
            return ThongTinDangKyDAO.Instance.GetAllByIDSV(masv);
        }
    }
}
