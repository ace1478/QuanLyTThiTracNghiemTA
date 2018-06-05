using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class BTDocDAO
    {
        public static List<BTDoc> LoadDSCauHoi()
        {
            List<BTDoc> List = new List<BTDoc>();
            string querry = "select * from BTDoc";
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    BTDoc BTDoc = new BTDoc(item);
                    List.Add(BTDoc);
                }
            }
            else return null;
            return List;
        }
        public static List<BTDoc> LoadDSCauHoi_TheoMaDe(int MaDe)
        {
            List<BTDoc> List = new List<BTDoc>();
            string querry = "select * from BTDoc where Id_Doc in (select Id_Doc from ChiTiet_Doc  where Id_MaDe =" + MaDe + ")";
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    BTDoc BTDoc = new BTDoc(item);
                    List.Add(BTDoc);
                }
            }
            else return null;
            return List;
        }
        public static void EditDoanVan(int Id_Doc, string DoanVan)
        {
            string querry = "update BTDoc  set DoanVan = N'" + DoanVan + "' where id_doc=" + Id_Doc;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void AddDoanVan(string DoanVan)
        {
            string querry = "insert into BTDoc values ( N'" + DoanVan + "' )";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static int Get_IdDoc()
        {
            int id = 0;
            List<BTDoc> List = new List<BTDoc>();
            string querry = "select * from BTDoc";
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {

                    BTDoc BTDoc = new BTDoc(item);
                    id = BTDoc.Id_Doc;
                    List.Add(BTDoc);
                }
            }
            return id;
        }
        public static void DeleteDoanVan(int id_doc)
        {
            string querry = "Delete BTDoc where id_doc=" + id_doc;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
       
    }
}
