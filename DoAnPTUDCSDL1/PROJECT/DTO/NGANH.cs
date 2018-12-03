using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class NGANH
    {
        public string maNganh { get; set; }
        public string tenNganh { get; set; }
        public int soSinhVienTheoHoc { get; set; }
        public int soChuyenDeToiDa { get; set; }

        public NGANH(string MaN,string TenN,int soSVtheoHoc,int soCDToiDa)
        {
            this.maNganh = MaN;
            this.tenNganh = TenN;
            this.soSinhVienTheoHoc = soSVtheoHoc;
            this.soChuyenDeToiDa = soCDToiDa;
        }
    }
}
