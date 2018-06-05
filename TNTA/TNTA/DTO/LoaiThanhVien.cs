using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class LoaiThanhVien
    {
        public int Id_LoaiTV { get; set; }
        public string Name { get; set; }
        public string GhiChu { get; set; }
        public LoaiThanhVien()
        {
            this.Id_LoaiTV = 0;
            this.Name = null;
            this.GhiChu = null;
        }
        public LoaiThanhVien(DataRow row)
        {
            this.Id_LoaiTV = (int)row["Id_LoaiTV"];
            this.GhiChu = row["GhiChu"].ToString();
            this.Name = row["Name"].ToString();

        }
    }
}
