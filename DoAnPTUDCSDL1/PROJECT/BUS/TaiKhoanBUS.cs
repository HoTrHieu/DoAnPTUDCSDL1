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
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
        }
        private TaiKhoanBUS() { }

        public void GetAll(DataGridView data)
        {
            data.DataSource = TaiKhoanDAO.Instance.GetAll();
        }

        public TAIKHOAN GetByID(string id)
        {
            return TaiKhoanDAO.Instance.GetByID(id);
        }

        public bool Insert(TAIKHOAN tk)
        {
            return TaiKhoanDAO.Instance.Insert(tk);
        }

    }
}
