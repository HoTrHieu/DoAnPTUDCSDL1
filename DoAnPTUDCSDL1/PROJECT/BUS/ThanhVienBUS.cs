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
    public class ThanhVienBUS
    {
        private static ThanhVienBUS instance;

        public static ThanhVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThanhVienBUS();
                return instance;
            }
        }

        private ThanhVienBUS() { }

        public void GetAll(DataGridView data)
        {
            data.DataSource = ThanhVienDAO.Instance.GetAll();
        }

        public THANHVIEN GetByID(string maDangKy, string maNhom)
        {
            return ThanhVienDAO.Instance.GetByIDs(maDangKy, maNhom);
        }

        public THANHVIEN GetByIDDK(string maDangKy)
        {
            return ThanhVienDAO.Instance.GetByIDDK(maDangKy);
        }

        public bool updateTrgNhom(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string maDangKy = row.Cells["MaDangKy"].Value.ToString();
            string maNhom = row.Cells["MaNhom"].Value.ToString();
            string vaiTro = row.Cells["VaiTro"].Value.ToString();

            THANHVIEN tv = new THANHVIEN(maDangKy, maNhom, vaiTro);

            return ThanhVienDAO.Instance.updateThanhVien(maDangKy, maNhom, tv);
        }

        public bool updateThanhVien(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string maDangKy = row.Cells["MaDangKy"].Value.ToString();
            string maNhom = row.Cells["MaNhom"].Value.ToString();
            string vaiTro = row.Cells["VaiTro"].Value.ToString();

            THANHVIEN tv = new THANHVIEN(maDangKy, maNhom, vaiTro);

            return ThanhVienDAO.Instance.updateThanhVien(maDangKy, maNhom, tv);
        }

        public bool insertThanhVien(string maDangKy, string maNhom, string vaiTro)
        {
            THANHVIEN tv = new THANHVIEN(maDangKy, maNhom, vaiTro);
            return ThanhVienDAO.Instance.insertThanhVien(tv);
        }

        public bool deleleThanhVien(string maDangKy, string maNhom)
        {
            return ThanhVienDAO.Instance.deleteThanhVien(maDangKy, maNhom);
        }

        //
        public List<THANHVIEN> GetAllByIDN(string mNhom)
        {
            return ThanhVienDAO.Instance.GetAllByIDN(mNhom);
        }
        //hai them vao
        public List<Tuple<string, string, string>> GetTVbyNhom(string MaNhom)
        {
            return ThanhVienDAO.Instance.GetTVbyNhom(MaNhom);
        }

        public bool checkTruongNhom(string MSSV, string MaDK)
        {
            return ThanhVienDAO.Instance.checkTruongNhom(MSSV, MaDK);
        }

        public bool deleteThanhVienbyHai(string maDangKy, string maNhom)
        {
            return ThanhVienDAO.Instance.deleteThanhVienbyHai(maDangKy, maNhom);
        }
        public bool deleteThanhVienByMaNhom(string maNhom)
        {
            return ThanhVienDAO.Instance.deleteThanhVienByMaNhom(maNhom);
        }
    }
}
