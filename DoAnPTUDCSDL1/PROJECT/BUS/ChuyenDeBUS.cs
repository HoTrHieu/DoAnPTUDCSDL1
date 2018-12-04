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
    class ChuyenDeBUS
    {
        private static ChuyenDeBUS instance;
        public static ChuyenDeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChuyenDeBUS();
                }
                return instance;
            }
        }
        private ChuyenDeBUS() { }
        //lấy toàn bộ danh sách các cac chuyen de
        public void GetAll(DataGridView data)
        {
            data.DataSource = ChuyenDeDAO.Instance.GetAll();
        }
        //lấy chuyên đề theo mã Chuyên Đề
        public CHUYENDE GetByID(string id)
        {
            return ChuyenDeDAO.Instance.GetByID(id);
        }
    }
}
