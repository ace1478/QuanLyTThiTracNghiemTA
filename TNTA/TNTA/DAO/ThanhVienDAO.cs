using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class ThanhVienDAO
    {
        public static bool Login_Check(string username, string password)
        {
            string Querry_T = "select * from ThanhVien where username=N'" + username + "'And password=N'" + password + "'";
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            return check.Rows.Count > 0;
        }
        public static List<ThanhVien> GetAccount(string username, string password)
        {
            List<ThanhVien> listAccount = new List<ThanhVien>();
            string Querry_T = "select * from ThanhVien where username=N'" + username + "'And password=N'" + password + "'";
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            foreach (DataRow item in check.Rows)
            {
                ThanhVien ac = new ThanhVien(item);
                listAccount.Add(ac);
            }
            return listAccount;

        }
        public static ThanhVien GetAccount(int id)
        {
            List<ThanhVien> listAccount = new List<ThanhVien>();
            string Querry_T = "select * from ThanhVien where Id_ThanhVien=N'" + id + "'" ;
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            if (check == null) return null;
            foreach (DataRow item in check.Rows)
            {
                ThanhVien ac = new ThanhVien(item);
                listAccount.Add(ac);
            }
            return listAccount[0];

        }
        public static SinhVien GetThongTinSV(int id)
        {
            List<SinhVien> listAccount = new List<SinhVien>();
            string Querry_T = "exec GetThonTinSV_ThanhVienDAO '"+ id+"'";
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            foreach (DataRow item in check.Rows)
            {
                SinhVien ac = new SinhVien(item);
                listAccount.Add(ac);
            }
            return listAccount[0];
        }
    }
}
