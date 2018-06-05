using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class QuyenSDDAO
    {
        public static List<QuyenSD>  GetListQuyenSD()
        {
            string querry = "select * from QuyenSD";
            List<QuyenSD> List = new List<QuyenSD>();
           
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    QuyenSD BTDoc = new QuyenSD(item);
                    List.Add(BTDoc);
                }
            }
            else return null;
            return List;
        }
        public static List<QuyenSD> GetListQuyen_LoaiTV(int Id_LoaiTV)
        {
            string querry = "select * from QuyenSD where Id_QuyenSD in ( select Id_QuyenSD from Quyen_LoaiTV where Id_LoaiTV ="+Id_LoaiTV+")";
            List<QuyenSD> List = new List<QuyenSD>();

            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    QuyenSD BTDoc = new QuyenSD(item);
                    List.Add(BTDoc);
                }
            }
            else return null;
            return List;
        }
        public static void AddQuyen_LoaiTV(int Id_LoaiTV , int Id_QuyenSD)
        {
            string querry = "Insert into Quyen_LoaiTV  values( " + Id_LoaiTV + "," + Id_QuyenSD + ")";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void DeleteQuyen_LoaiTV(int Id_LoaiTV, int Id_QuyenSD)
        {
            string querry = "Delete Quyen_LoaiTV  where Id_QuyenSD= "+Id_QuyenSD+"And Id_LoaiTV="+Id_LoaiTV;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
    }
}
