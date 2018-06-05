using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DAO
{
    class ChiTiet_DocDAO
    {
        public static void Add(int id_MaDeThi, int id_Doc)
        {
            string querry = " insert into ChiTiet_Doc values (" + id_MaDeThi + "," + id_Doc + ")";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void Delete(int Id_MaDe)
        {
            string querry = "Delete ChiTiet_Doc Where Id_MaDe = '"+ Id_MaDe +  "'";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
    }
}
