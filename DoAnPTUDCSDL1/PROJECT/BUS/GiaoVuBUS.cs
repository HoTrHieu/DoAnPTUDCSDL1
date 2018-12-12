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
    class GiaoVuBUS
    {
        private static GiaoVuBUS instance;

        public static GiaoVuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVuBUS();
                return instance;
            }
        }

        private GiaoVuBUS() { }

        //Update
        public bool Update(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MaGVu = row.Cells["maGVu"].Value.ToString();
            string TenGVu = row.Cells["tenGVu"].Value.ToString();
            bool? Phai = (bool?)row.Cells["phai"].Value;
            DateTime? NgaySinh = (DateTime?)row.Cells["ngaySinh"].Value;
            string DiaChi = row.Cells["diaChi"].Value.ToString();

            GIAOVU gvu = new GIAOVU(MaGVu, TenGVu, Phai, NgaySinh, DiaChi);

            return GiaoVuDAO.Instance.Update(MaGVu, gvu);
        }

        //get by id
        public GIAOVU GetByID(string id)
        {
            GIAOVU gvu = GiaoVuDAO.Instance.GetByID(id);
            return gvu;
        }
    }
}
