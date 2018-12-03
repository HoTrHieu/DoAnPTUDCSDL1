using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class CHUYENDE
    {
        public string maCDe { get; set; }
        public string tenCDe { get; set; }
        public int soSV { get; set; }
        public string maNganh { get; set; }

        public CHUYENDE(string maCDe, string tenCDe, int soSV, string maNganh)
        {
            this.maCDe = maCDe;
            this.tenCDe = tenCDe;
            this.soSV = soSV;
            this.maNganh = maNganh;
        }
    }
}
