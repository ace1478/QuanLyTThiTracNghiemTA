using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTA.DAO
{
    class ChiTiet_NguPhapDAO
    {
        public static void Add(int id_MaDeThi,int id_BTNguPhap)
        {
            string querry = " insert into ChiTiet_NguPhap values (" + id_MaDeThi + "," + id_BTNguPhap + ")";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void Delete(int Id_MaDe)
        {
            string querry = "Delete ChiTiet_NguPhap Where Id_MaDe = '" + Id_MaDe + "'";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
    }
}
