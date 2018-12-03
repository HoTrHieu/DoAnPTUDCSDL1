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

        //
    }
}
