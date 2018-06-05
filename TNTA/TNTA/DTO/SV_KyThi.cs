using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class SV_KyThi
    {
        public SV_KyThi()
        {
            this.MaSVKT = 0;
            this.MaSV = null;
            this.MaTTKT = 0;
            this.Id_MaDe = 0;

        }
        public SV_KyThi(DataRow row)
        {
            this.MaSVKT = (int)row["MaSVKT"];
            this.MaSV = row["MaSV"].ToString();
            this.MaTTKT = (int)row["MaTTKT"];
            try
            {
                this.TongDiem = (int)row["TongDiem"];
            }
           catch
            {
                this.TongDiem = 0;
            }
            try
            {
                this.Id_MaDe = (int)row["Id_MaDe"];
            }
            catch { }
           
        }
        public int MaSVKT { get; set; }
        public string MaSV { get; set; }
        public int MaTTKT { get; set; }
        public int TongDiem { get; set; }


        public int Id_MaDe { get; set; }
    }
}
