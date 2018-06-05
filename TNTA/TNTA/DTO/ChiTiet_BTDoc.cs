using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class ChiTiet_BTDoc
    {
        public ChiTiet_BTDoc()
        {
            this.id= 0;
            this.id_MaDeThi = 0;
            this.id_Doc = 0;

        }
        public ChiTiet_BTDoc(DataRow row)
        {
            this.id = (int)row["id_CTNguPhap"];
            this.id_MaDeThi = (int)row["id_MaDeThi"];
            this.id_Doc = (int)row["id_BTNguPhap"];
        }

        public int id { get; set; }
        public int id_MaDeThi { get; set; }
        public int id_Doc { get; set; }

    }
}

