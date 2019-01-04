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
    public class ThongTinMoChuyenDeBUS
    {
        private static ThongTinMoChuyenDeBUS instance;

        public static ThongTinMoChuyenDeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongTinMoChuyenDeBUS();
                return instance;
            }
        }

        private ThongTinMoChuyenDeBUS() { }

        public void GetAll(DataGridView data)
        {
            data.DataSource = ThongTinMoChuyenDeDAO.Instance.GetAll();
        }

        public THONGTINMOCHUYENDE GetByID(string id)
        {
            return ThongTinMoChuyenDeDAO.Instance.GetByID(id);
        }

        public bool updateThongTinMoChuyenDe(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MaThongTinMoChuyenDe = row.Cells["MaThongTinMoChuyenDe"].Value.ToString();
            int HocKy = (int)row.Cells["HocKy"].Value;
            string NienHoc = row.Cells["NienHoc"].Value.ToString();
            string MaGiaoVu = row.Cells["MaGiaoVu"].Value.ToString();
            string MaChuyenDe = row.Cells["MaChuyenDe"].Value.ToString();
            bool trangThai = (bool)row.Cells["TrangThai"].Value;
            THONGTINMOCHUYENDE ttmcd = new THONGTINMOCHUYENDE(MaThongTinMoChuyenDe, HocKy, NienHoc, MaGiaoVu, MaChuyenDe, trangThai);

            return ThongTinMoChuyenDeDAO.Instance.updateThongTinMoChuyenDe(MaThongTinMoChuyenDe, ttmcd);
        }

        public bool insertThongTinMoChuyenDe(string maTTMCDe, int hocKy, string nienHoc, string maGV, string maCD, bool trangthai)
        {
            THONGTINMOCHUYENDE ttmcd = new THONGTINMOCHUYENDE(maTTMCDe, hocKy, nienHoc, maGV, maCD, trangthai) ;
            return ThongTinMoChuyenDeDAO.Instance.insertThongTinMoChuyenDe(ttmcd);
        }

        public bool deleteThongTinMoChuyenDe(string id)
        {
            return ThongTinMoChuyenDeDAO.Instance.deleteThongTinMoChuyenDe(id);
        }


        public THONGTINMOCHUYENDE GetThongTinMoChuyenDeLast()
        {
            return ThongTinMoChuyenDeDAO.Instance.GetThongTinMoChuyenDeLast();
        }

        public string CreateMaTTMCD()
        {
            return ThongTinMoChuyenDeDAO.Instance.CreateMaTTMCD();
        }

        //lấy thông tin mở chuyên đề theo mã ngành
        public List<THONGTINMOCHUYENDE> GetThonTinMoChuyenDeByNganh(string maN)
        {
            return ThongTinMoChuyenDeDAO.Instance.GetAllByMaNganh(maN);
        }

        //lấy mã mở chuyên đề by mã ChuyenDe
        public THONGTINMOCHUYENDE GetMoChuyenDeByMaCD(string maCD)
        {
            return ThongTinMoChuyenDeDAO.Instance.GetMoChuyenDeByMaCD(maCD);
        }

        public THONGTINMOCHUYENDE GetByMaCD(string maCD)
        {
            return ThongTinMoChuyenDeDAO.Instance.GetByMaCD(maCD);
        }

        public bool updateTrangThai(string MaTTMCDe, bool trangThai)
        {
            return ThongTinMoChuyenDeDAO.Instance.updateTrangThai(MaTTMCDe, trangThai);
        }
    }
}
