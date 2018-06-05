using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class MaDeThiDAO
    {
        public static void Add(string MaDe)
        {
            string querry = " insert into MaDeThi values (N'" + MaDe +  "')";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void Delete(int MaDe)
        {
            string querry = " Delete MaDeThi where id_MaDe ="+ MaDe;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static int GetIdCuoi()
        {
            int id=0;
            string querry = "Select * From MaDeThi";
            DataTable DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return 0;
              else
            {
                foreach (DataRow item in DT.Rows)
                {
                    MaDeThi made = new MaDeThi(item);
                    id = made.ID_MaDe;
                }
               
            }
            return id;
        }
        public static List<MaDeThi> GetListMaDeThi()
        {
      
            string querry = "Select * From MaDeThi";
            List<MaDeThi> List =  new List<MaDeThi>();
            DataTable DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    MaDeThi made = new MaDeThi(item);
                    List.Add(made);
                }

            }
            return List;
           
        }
        public static int GetID_ByTen(string MaDe)
        {
            int id = 0;
            List<MaDeThi> List = new List<MaDeThi>();
            string querry = "select * from MaDeThi  where Made = '" + MaDe + "'";
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {

                    MaDeThi BTDoc = new MaDeThi(item);
                    id = BTDoc.ID_MaDe;
                    List.Add(BTDoc);
                }
            }
            return id;
        }
    }
}
