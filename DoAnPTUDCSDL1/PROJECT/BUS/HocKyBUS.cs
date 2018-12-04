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
    class HocKyBUS
    {
        private static HocKyBUS instance;
        public static HocKyBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocKyBUS();
                }
                return instance;
            }
        }
        private HocKyBUS() { }

        //lấy toàn bộ danh sách Hoc Ky
        public void GetAll(DataGridView data)
        {
            data.DataSource = HocKyDAO.Instance.GetAll();
        }

        //lấy toàn bộ danh sách Hoc Ky theo nien hoc
        public void GetByNienKhoa(DataGridView data, string NK)
        {
            data.DataSource = HocKyDAO.Instance.GetByNienKhoa(NK);
        }
    }
}
