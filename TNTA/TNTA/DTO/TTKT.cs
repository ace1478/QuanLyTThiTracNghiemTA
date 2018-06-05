using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class TTKT
    {
        public TTKT()
        {
            this.MaTTKT = 0;
            this.TenKyThi = null;
            this.ThoiGianThi = null;
            this.DiaDiemTHi = null;
            this.CoQuanToChuc = null;
            this.NgayThi = null;


        }
        public TTKT(DataRow row)
        {
            this.MaTTKT = (int)row["MaTTKT"];
            this.TenKyThi = row["TenKyThi"].ToString();

            this.ThoiGianThi = row["ThoiGianThi"].ToString();
            this.NgayThi = row["NgayThi"].ToString();

            this.CoQuanToChuc = row["CoQuanToChuc"].ToString();
            this.DiaDiemTHi = row["DiaDiemThi"].ToString();
            this.MatKhau = row["MatKhau"].ToString();

        }

        public int MaTTKT { get; set; }
        public string TenKyThi { get; set; }
        public string ThoiGianThi { get; set; }
        public string DiaDiemTHi { get; set; }
        public string CoQuanToChuc { get; set; }
        public string NgayThi { get; set; }
        public string MatKhau { get; set; }
    }
}
