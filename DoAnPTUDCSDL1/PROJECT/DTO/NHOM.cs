using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    class NHOM
    {
        public string maNhom { get; set; }
        public string tenNhom { get; set; }

        public byte trangThai { get; set; }

        public NHOM(string MaNhom, string TenNhom, byte TrThai)
        {
            this.maNhom = MaNhom;
            this.tenNhom = TenNhom;
            this.trangThai = TrThai;
        }
    }
}
