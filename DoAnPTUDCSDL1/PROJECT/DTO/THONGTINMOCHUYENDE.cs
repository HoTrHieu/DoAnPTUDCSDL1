using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class THONGTINMOCHUYENDE
    {
        public string maThongTinMoChuyenDe { get; set; }
        public int hocKy { get; set; }
        public string nienHoc { get; set; }
        public string maGiaoVu { get; set; }
        public string maChuyenDe { get; set; }

        public THONGTINMOCHUYENDE(string MaTTMChuyenDe, int HocKy, string NienHoc, string MaGV, string MaCD)
        {
            maThongTinMoChuyenDe = MaTTMChuyenDe;
            hocKy = HocKy;
            nienHoc = NienHoc;
            maGiaoVu = MaGV;
            maChuyenDe = MaCD;
        }
    }
}
