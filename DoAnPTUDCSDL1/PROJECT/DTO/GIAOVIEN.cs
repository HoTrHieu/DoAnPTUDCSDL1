using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class GIAOVIEN
    {
        public string MaGVien { get; set; }
        public string TenGVien { get; set; }
        public bool Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string MaChuyenDe { get; set; }

        public GIAOVIEN(string maGVien, string tenGVien, bool phai, DateTime ngaySinh, string diaChi, string maChuyenDe)
        {
            MaGVien = maGVien;
            TenGVien = tenGVien;
            Phai = phai;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            MaChuyenDe = maChuyenDe;
        }
    }
}
