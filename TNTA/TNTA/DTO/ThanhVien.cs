using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class ThanhVien
    {
        public ThanhVien()
        {
            this.id_ThanhVien = 0;
            this.UserName = null;
            this.Password = null;
            this.MaSVKT = 0;

        }
        public ThanhVien(DataRow row)
        {
            this.id_ThanhVien = (int)row["id_ThanhVien"];
            this.UserName = row["Username"].ToString();
            this.Password = row["Password"].ToString();
         

            this.MaSVKT = (int)row["MaSVKT"];
        }
        public int id_ThanhVien { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


 
        public int MaSVKT { get; set; }
    }
}
