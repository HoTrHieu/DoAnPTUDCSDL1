using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class THANHVIEN
    {
        public string maDangKy { get; set; }
        public string maNhom { get; set; }
        public string vaiTro { get; set; }

        public THANHVIEN(string MaDK,string MaN,string VT)
        {
            this.maDangKy = MaDK;
            this.maNhom = MaN;
            this.vaiTro = VT;
        }
    }
}
