using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class CHUYENDE
    {
        public string MaCDe { get; set; }
        public string TenCDe { get; set; }
        public int SoSV { get; set; }
        public string MaNganh { get; set; }

        public CHUYENDE(string maCDe, string tenCDe, int soSV, string maNganh)
        {
            MaCDe = maCDe;
            TenCDe = tenCDe;
            SoSV = soSV;
            MaNganh = maNganh;
        }
    }
}
