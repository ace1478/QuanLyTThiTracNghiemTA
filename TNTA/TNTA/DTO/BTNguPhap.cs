using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class BTNguPhap
    {
        public BTNguPhap()
        {
            this.Id_BTNguPhap = 0;
            this.CauHoi = null;
            this.DapAn1 = null;
            this.DapAn2 = null;
            this.DapAn3 = null;
            this.DapAn4 = null;
            this.DapAnDung = null;

        }
        public BTNguPhap(DataRow row)
        {
            this.Id_BTNguPhap = (int)row["Id_BTNguPhap"];
            this.CauHoi = row["CauHoi"].ToString();
            this.DapAn1 = row["DapAn1"].ToString();
            this.DapAn2 = row["DapAn2"].ToString();
            this.DapAn3 = row["DapAn3"].ToString();
            this.DapAn4 = row["DapAn4"].ToString();
            this.DapAnDung = row["DapAnDung"].ToString();


        }
        public int Id_BTNguPhap { get; set; }
        public string CauHoi { get; set; }
        public string DapAn1 { get; set; }
        public string DapAn2 { get; set; }
        public string DapAn3 { get; set; }
        public string DapAn4 { get; set; }
        public string DapAnDung { get; set; }
    }
}
