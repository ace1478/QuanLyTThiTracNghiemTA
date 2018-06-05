using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class Lop
    {
        
            public Lop()
            {
                this.MaLop = 0;
                this.TenLop = null;
                this.MaKhoa = 0;


            }
            public Lop(DataRow row)
            {
                this.MaLop = (int)row["MaLop"];
                this.TenLop = row["TenLop"].ToString();
                this.MaKhoa = (int)row["Makhoa"];
            }

            public int MaLop { get; set; }
            public string TenLop { get; set; }
            public int MaKhoa { get; set; }

        
    }
}
