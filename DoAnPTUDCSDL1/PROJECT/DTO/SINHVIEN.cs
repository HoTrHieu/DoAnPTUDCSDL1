using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class SINHVIEN
    {
        public string maSinhVien { get; set; }
        public string tenSinhVien { get; set; }
        public bool? phai { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string maNganh { get; set; }

        public SINHVIEN(string MaSV, string TenSV, bool? P, DateTime? ns, string DC, string MaN)
        {
            this.maSinhVien = MaSV;
            this.tenSinhVien = TenSV;
            this.phai = P;
            this.ngaySinh = ns;
            this.diaChi = DC;
            this.maNganh = MaN;
        }
    }
}
