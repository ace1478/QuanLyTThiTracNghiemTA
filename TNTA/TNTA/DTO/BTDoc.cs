using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DTO
{
    class BTDoc
    {
        public int Id_Doc { get; set; }
        public string DoanVan { get; set; }
        public BTDoc()
        {
            this.Id_Doc = 0;
            this.DoanVan = null;
        }
        public BTDoc(DataRow row)
        {
            this.Id_Doc = (int)row["Id_Doc"];

            this.DoanVan = row["DoanVan"].ToString();

        }
    }
}
