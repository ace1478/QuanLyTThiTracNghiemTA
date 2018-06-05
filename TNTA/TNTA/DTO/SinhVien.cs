using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class SinhVien
    {
        public SinhVien()
        {
            this.MaSV = null;
            this.HoVaTen = null;
            this.NgaySinh = null;
            this.GioiTinh = null;
            this.SDT = 0;
            this.Email = null;
            this.MaLop = 0;




        }
        public SinhVien(DataRow row)
        {
            this.MaSV = row["MaSV"].ToString();
            this.HoVaTen = row["HoVaTen"].ToString();
            this.NgaySinh = row["NgaySinh"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.SDT = (int)row["SDT"];
            this.Email = row["Email"].ToString();
            this.MaLop = (int)row["MaLop"];

        }
        public string MaSV { get; set; }
        public string HoVaTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int SDT { get; set; }
        public string Email { get; set; }
        public int MaLop { get; set; }
    }
}
