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
        public bool phai { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string maNganh { get; set; }

        public SINHVIEN(string msSV, string tenSV, bool phaiSV, DateTime ngSinh, string dChi, string mNganh)
        {
            maSinhVien = msSV;
            tenSinhVien = tenSV;
            phai = phaiSV;
            ngaySinh = ngSinh;
            diaChi = dChi;
            maNganh = mNganh;
        }
    }
}
