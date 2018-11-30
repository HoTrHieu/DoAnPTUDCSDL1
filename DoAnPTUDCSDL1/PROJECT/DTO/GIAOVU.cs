using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    class GIAOVU
    {
        public string maGVu { get; set; }
        public string tenGVu { get; set; }
        public bool phai { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }

        public GIAOVU(string maGVu, string tenGVu, bool phai, DateTime ngaySinh, string diaChi)
        {
            this.maGVu = maGVu;
            this.tenGVu = tenGVu;
            this.phai = phai;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
        }
    }
}
