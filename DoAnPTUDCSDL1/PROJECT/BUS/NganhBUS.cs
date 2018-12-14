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
    public class NganhBUS
    {
        private static NganhBUS instance;
        public static NganhBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NganhBUS();
                }
                return instance;
            }
        }
        private NganhBUS() { }

        //lấy toàn bộ danh sách các ngành
        public List<NGANH> GetAll()
        {
            return NganhDAO.Instance.GetAll();
        }


        //lấy ngành theo mã ngành
        public NGANH GetByID(string id)
        {
            return NganhDAO.Instance.GetByID(id);
        }
    }
}
