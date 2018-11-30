using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DAO;

namespace PROJECT.BUS
{
    public class SinhVienBUS
    {
        private static SinhVienBUS instance;

        public static SinhVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SinhVienBUS();
                return instance;
            }
        }

        private SinhVienBUS() { }
        public void GetAll(DataGridView data)
        {
            data.DataSource = SinhVienDAO.Instance.GetAll();
        }
    }
}
