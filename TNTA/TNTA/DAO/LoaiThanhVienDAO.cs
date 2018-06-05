using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class LoaiThanhVienDAO
    {
        public static int GetIdCuoi()
        {
            int id=0;
            DataTable tb= DataProvider.instanse.Executequerry("select * from LoaiThanhVien");
            if (tb == null) return 0;
            else
            {
                foreach(DataRow item in tb.Rows)
                {
                    LoaiThanhVien tv = new LoaiThanhVien(item);
                    id = tv.Id_LoaiTV;
                }
            }
            return id;

        }
    }
}
