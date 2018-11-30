using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    class LOPHOC
    {
        public string maLop { get; set; }
        public string tenLop { get; set; }

        public LOPHOC(string mLop, string tLop)
        {
            this.maLop = mLop;
            this.tenLop = tLop;
        }
    }
}
