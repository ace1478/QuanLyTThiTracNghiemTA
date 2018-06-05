using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class Khoa
    {
        public Khoa()
        {
            this.MaKhoa = 0;
            this.TenKhoa = null;



        }
        public Khoa(DataRow row)
        {
            this.MaKhoa = (int)row["MaKhoa"];
            this.TenKhoa = row["TenKhoa"].ToString();

        }

        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
    }
}
