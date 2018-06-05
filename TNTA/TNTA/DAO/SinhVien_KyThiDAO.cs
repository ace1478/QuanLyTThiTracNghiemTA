using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class SinhVien_KyThiDAO
    {
        public static void Add(int MaSV, int MaMaTTKT)
        {
            string querry = "insert into Sv_KyThi(MaSV,MaTTKT) values (" + MaSV + "," + MaMaTTKT + ")";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void Delete(int Id_MaDe)
        {
            string querry = "Delete Sv_KyThi Where Id_MaDe = '" + Id_MaDe + "'";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void Delete_ByMaSV(string MaSV)
        {

            string querry = "Delete Sv_KyThi Where MaSV = '" + MaSV + "'";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static int GetMaDe (int MSVKT)
        {
            List<SV_KyThi> listAccount = new List<SV_KyThi>();
            string Querry_T = "select * from Sv_KyThi where MaSVKT= "+MSVKT;
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            foreach (DataRow item in check.Rows)
            {
                SV_KyThi ac = new SV_KyThi(item);
                listAccount.Add(ac);
            }
            return listAccount[0].Id_MaDe;
        }
        public static SV_KyThi GetById(int MSVKT)
        {
            List<SV_KyThi> listAccount = new List<SV_KyThi>();
            string Querry_T = "select * from Sv_KyThi where MaSVKT= " + MSVKT;
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            foreach (DataRow item in check.Rows)
            {
                SV_KyThi ac = new SV_KyThi(item);
                listAccount.Add(ac);
            }
            return listAccount[0];
        }
        public static int  GetMSVKTCuoi ()
        {
            int i = 0;
            string Querry_T = "select * from Sv_KyThi " ;
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            if (check == null) return 0;
            foreach (DataRow item in check.Rows)
            {
                SV_KyThi ac = new SV_KyThi(item);
                i = ac.MaSVKT;
            }
            return i;
        }
        public static int GetMSVKTByMaSV_TTKT(string MaSV, int MaTTKT)
        {
            int i = 0;
            string Querry_T = "select * from Sv_KyThi  where MaSV='"+MaSV+ "' and  MaTTKT="+ MaTTKT;
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            if (check == null) return 0;
            foreach (DataRow item in check.Rows)
            {
                SV_KyThi ac = new SV_KyThi(item);
                i = ac.MaSVKT;
            }
            return i;
        }
    }
}
