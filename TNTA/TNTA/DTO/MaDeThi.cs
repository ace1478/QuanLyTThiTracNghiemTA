using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class MaDeThi
    {
        public MaDeThi()
        {
            this.ID_MaDe= 0;
            this.MaDe = null;



        }
        public MaDeThi(DataRow row)
        {
            this.ID_MaDe = (int)row["ID_MaDe"];
            this.MaDe = row["MaDe"].ToString();

        }

        public int ID_MaDe { get; set; }
        public string MaDe { get; set; }
    }
}
