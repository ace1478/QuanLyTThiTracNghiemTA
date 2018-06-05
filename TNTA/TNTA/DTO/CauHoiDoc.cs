using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class CauHoiDoc
    {
        public CauHoiDoc()
        {
            this.MaCauHoiDoc = 0;
            this.STT = 0;
            this.DapAn1 = null;
            this.DapAn2 = null;
            this.DapAn3 = null;
            this.DapAn4 = null;
            this.DapAnDung = null;
            this.Id_Doc = 0;
        }
        public CauHoiDoc(DataRow row)
        {
            this.MaCauHoiDoc = (int)row["MaCauHoiDoc"];
            this.STT = (int)row["STT"];
            this.DapAn1 = row["DapAn1"].ToString();
            this.DapAn2 = row["DapAn2"].ToString();
            this.DapAn3 = row["DapAn3"].ToString();
            this.DapAn4 = row["DapAn4"].ToString();
            this.DapAnDung = row["DapAnDung"].ToString();
            this.Id_Doc = (int)row["Id_Doc"];

        }
        public int MaCauHoiDoc { get; set; }
        public int STT { get; set; }
        public string DapAn1 { get; set; }
        public string DapAn2 { get; set; }
        public string DapAn3 { get; set; }
        public string DapAn4 { get; set; }
        public string DapAnDung { get; set; }
        public int Id_Doc { get; set; }
    }
}
