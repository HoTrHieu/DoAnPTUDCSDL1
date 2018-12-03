using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class HOCKY
    {
        public int hKy { get; set; }
        public string nienKhoa { get; set; }
        public DateTime ngayBDau { get; set; }
        public DateTime ngayKThuc { get; set; }

        public HOCKY(int hKy, string nienKhoa, DateTime ngayBDau, DateTime ngayKThuc)
        {
            this.hKy = hKy;
            this.nienKhoa = nienKhoa;
            this.ngayBDau = ngayBDau;
            this.ngayKThuc = ngayKThuc;
        }
    }
}
