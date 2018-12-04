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
    public class LopHocBUS
    {
        private static LopHocBUS instance;

        public static LopHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopHocBUS();
                return instance;
            }
        }

        private LopHocBUS() { }

        public void GetAll(DataGridView data)
        {
            data.DataSource = LopHocDAO.Instance.GetAll();
        }

        public LOPHOC GetByID(string id)
        {
            return LopHocDAO.Instance.GetByID(id);
        }

        public bool updateLopHoc(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MaLop = row.Cells["MaLop"].Value.ToString();
            string TenLop = row.Cells["TenLop"].Value.ToString();

            LOPHOC lh = new LOPHOC(MaLop, TenLop);

            return LopHocDAO.Instance.updateLopHoc(MaLop,lh);
        }

        public bool insertLopHoc()
        {
            string MaLop = ""; // chưa xác định lấy từ đâu
            string TenLop = ""; // chưa xác định lấy từ đâu

            LOPHOC lh = new LOPHOC(MaLop, TenLop);
            return LopHocDAO.Instance.insertLopHoc(lh);
        }

        public bool deleteLopHoc(string id)
        {
            return LopHocDAO.Instance.deleteLopHoc(id);
        }
    }
}
