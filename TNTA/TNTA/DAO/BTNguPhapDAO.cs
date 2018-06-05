using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class BTNguPhapDAO
    {
        public static List<BTNguPhap> LoadDSCauHoi()
        {
            List<BTNguPhap> List = new List<BTNguPhap>();
            string querry = "select * from BTNguPhap";
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    BTNguPhap BTNguPhap = new BTNguPhap(item);
                    List.Add(BTNguPhap);
                }
            }
            else return null;
            return List;
        }
        public static void AddCauHoi(string CauHoi, string DapAn1, string DapAn2, string DapAn3, string DapAn4, string DapAnDung)
        {
            string querry = "Insert into BTNguPhap Values(  N'" + CauHoi + "',N'" + DapAn1 + "',N'" + DapAn2 + "',N'" + DapAn3 + "',N'" + DapAn4 + "',N'" + DapAnDung + "')";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void EditCauHoi(int Id_BTNguPhap, string CauHoi, string DapAn1, string DapAn2, string DapAn3, string DapAn4, string DapAnDung)
        {
            string querry = "update BTNguPhap set Cauhoi= N'" + CauHoi + "',DapAn1=N'" + DapAn1 + "',DapAn2=N'" + DapAn2 + "',DapAn3=N'" + DapAn3 + "',DapAn4=N'" + DapAn4 + "',DapAnDung=N'" + DapAnDung + "' Where Id_BTNguPhap=" + Id_BTNguPhap;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }

        public static void DeleteCauHoi(int id)
        {
            string querry = "delete BTNguPhap where Id_BTNguPhap=" + id;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static List<BTNguPhap > LoadDSCauHoi_TheoMaDe( int MaDe)
        {
            List<BTNguPhap> List = new List<BTNguPhap>();
            string querry = "select * from BTNguPhap where Id_BTNguPhap in (select Id_BTNguPhap from ChiTiet_NguPhap  where Id_MaDe ="+MaDe+")";
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    BTNguPhap BTNguPhap = new BTNguPhap(item);
                    List.Add(BTNguPhap);
                }
            }
            else return null;
            return List;
        }
    }
}
