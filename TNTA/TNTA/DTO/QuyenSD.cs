using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class QuyenSD
    {

        public int id_QuyenSD {get;set;}
        public string TenQuyen { get; set; }
        public QuyenSD()
        {
            this.id_QuyenSD = 0;
            this.TenQuyen = null;
        }
        public QuyenSD(DataRow row)
        {
            this.id_QuyenSD = (int)row["id_QuyenSD"];

            this.TenQuyen = row["TenQuyen"].ToString();

        }
    }
}
