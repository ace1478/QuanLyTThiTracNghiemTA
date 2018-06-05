using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class SinhVienLop
    {
        public SinhVienLop()
        {
            this.MaSV = null;
            this.HoVaTen = null;
            this.TenLop = null;
        }
        public SinhVienLop(DataRow row)
        {
            this.MaSV = row["MaSV"].ToString();
            this.HoVaTen = row["HoVaTen"].ToString();
            this.TenLop = row["TenLop"].ToString();
        }
        public string MaSV { get; set; }
        public string HoVaTen { get; set; }
        public string TenLop { get; set; }
    }
}
