using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class LopDAO
    {
        public static List<Lop> LoadDSLop()
        {
            List<Lop> listLop = new List<Lop>();
            String querry = "Select * From Lop";
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    Lop Lp = new Lop(item);
                    listLop.Add(Lp);
                }
                return listLop;
            }
        }
        public static string LoadTenLop(int MaLop)
        {

            String querry = "Select * From Lop Where MaLop=" + MaLop;
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                Lop Lp = new Lop(DT.Rows[0]);
                return Lp.TenLop;

            }
        }
        public static List<Lop> LoadTenLopTheoLhoa(int MaKhoa)
        {
            List<Lop> listLop = new List<Lop>();
            String querry = "Select * From Lop Where Makhoa=" + MaKhoa;
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    Lop Lp = new Lop(item);
                    listLop.Add(Lp);
                }
                return listLop;
            }
        }
    }
}
