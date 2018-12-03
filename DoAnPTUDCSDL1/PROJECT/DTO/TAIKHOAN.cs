using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DTO
{
    public class TAIKHOAN
    {
        public string maTaiKhoan { get; set; }
        public string matKhau { get; set; }
        public string loaiTaiKhoan { get; set; }
        public string maGiaoVuTao { get; set; }

        public TAIKHOAN(string MaTK,string MK,string LoaiTK,string MaGVT)
        {
            this.maTaiKhoan = MaTK;
            this.matKhau = MK;
            this.loaiTaiKhoan = LoaiTK;
            this.maGiaoVuTao = MaGVT;
        }
    }
}
