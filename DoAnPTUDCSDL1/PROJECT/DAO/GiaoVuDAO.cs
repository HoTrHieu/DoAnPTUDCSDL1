using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DTO;

namespace PROJECT.DAO
{
    class GiaoVuDAO
    {
        private static GiaoVuDAO instance;

        public static GiaoVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVuDAO();
                return instance;
            }
        }

        private GiaoVuDAO() { }

        //update
        public bool Update(string id, GIAOVU gvu)
        {
            string query = "Update GIAOVU SET TenGiaoVu = @ten , Phai = @phai , NgaySinh = @NS , DiaChi = @diaChi WHERE MaGiaoVu = @maOLD ";

            object[] para = new object[]
            {
                gvu.tenGVu,
                gvu.phai,
                gvu.ngaySinh,
                gvu.diaChi,
                id
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
