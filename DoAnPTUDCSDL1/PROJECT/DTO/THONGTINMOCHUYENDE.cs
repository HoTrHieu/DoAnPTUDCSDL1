using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    class THONGTINMOCHUYENDE
    {
        public string maThongTinMoChuyenDe { get; set; }
        public int hocKy { get; set; }
        public string nienHoc { get; set; }
        public string maGiaoVu { get; set; }
        public string maChuyenDe { get; set; }

        public THONGTINMOCHUYENDE(string MaTTMChuyenDe, int HocKy, string NienHoc, string MaGV, string MaCD)
        {
            this.maThongTinMoChuyenDe = MaTTMChuyenDe;
            this.hocKy = HocKy;
            this.nienHoc = NienHoc;
            this.maGiaoVu = MaGV;
            this.maChuyenDe = MaCD;
        }
    }
}
