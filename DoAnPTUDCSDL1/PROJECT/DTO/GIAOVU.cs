using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class GIAOVU
    {
        public string MaGVu { get; set; }
        public string TenGVu { get; set; }
        public bool Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }

        public GIAOVU(string maGVu, string tenGVu, bool phai, DateTime ngaySinh, string diaChi)
        {
            MaGVu = maGVu;
            TenGVu = tenGVu;
            Phai = phai;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
        }
    }
}
