using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class HOCKY
    {
        public int HKy { get; set; }
        public string NienKhoa { get; set; }
        public DateTime NgayBDau { get; set; }
        public DateTime NgayKThuc { get; set; }

        public HOCKY(int hKy, string nienKhoa, DateTime ngayBDau, DateTime ngayKThuc)
        {
            HKy = hKy;
            NienKhoa = nienKhoa;
            NgayBDau = ngayBDau;
            NgayKThuc = ngayKThuc;
        }
    }
}
