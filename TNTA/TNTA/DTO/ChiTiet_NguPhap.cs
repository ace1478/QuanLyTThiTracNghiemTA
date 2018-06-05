using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class ChiTiet_NguPhap
    {
        public ChiTiet_NguPhap()
        {
            this.id_CTNguPhap = 0;
            this.id_MaDeThi = 0;
            this.id_BTNguPhap = 0;

        }
        public ChiTiet_NguPhap(DataRow row)
        {
            this.id_CTNguPhap = (int)row["id_CTNguPhap"];
            this.id_MaDeThi = (int)row["id_MaDeThi"];
            this.id_BTNguPhap = (int)row["id_BTNguPhap"];
        }

        public int id_CTNguPhap { get; set; }
        public int id_MaDeThi { get; set; }
        public int id_BTNguPhap { get; set; }

    }
}
