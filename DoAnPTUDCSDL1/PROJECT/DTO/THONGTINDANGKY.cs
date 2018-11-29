using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class THONGTINDANGKY
    {
        public string maDangKy { get; set; }
        public string maSinhVien { get; set; }
        public string maThongTimMoChuyenDe { get; set; }
        public string maLop { get; set; }

        public THONGTINDANGKY(string MaDK,string MaSV, string MaTT,string MaL)
        {
            this.maDangKy = MaDK;
            this.maSinhVien = MaSV;
            this.maThongTimMoChuyenDe = MaTT;
            this.maLop = MaL;
        }
    }
}
