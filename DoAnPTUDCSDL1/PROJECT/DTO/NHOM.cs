using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class NHOM
    {
        public string maNhom { get; set; }
        public string tenNhom { get; set; }

        public bool trangThai { get; set; }

        public NHOM(string MaNhom, string TenNhom, bool TrThai)
        {
            this.maNhom = MaNhom;
            this.tenNhom = TenNhom;
            this.trangThai = TrThai;
        }
    }
}
