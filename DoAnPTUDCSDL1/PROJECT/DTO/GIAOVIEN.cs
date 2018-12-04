using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class GIAOVIEN
    {
        public string maGVien { get; set; }
        public string tenGVien { get; set; }
        public bool? phai { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string maChuyenDe { get; set; }

        public GIAOVIEN(string maGVien, string tenGVien, bool? phai, DateTime? ngaySinh, string diaChi, string maChuyenDe)
        {
            this.maGVien = maGVien;
            this.tenGVien = tenGVien;
            this.phai = phai;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.maChuyenDe = maChuyenDe;
        }
    }
}
