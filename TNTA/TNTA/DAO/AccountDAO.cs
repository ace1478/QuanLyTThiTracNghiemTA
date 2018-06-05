using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class AccountDAO
    {
        public static bool  Login_Check(string username, string password)
        {
            string Querry_T = "select * from Account where username=N'" + username + "'And password=N'" + password + "'";
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            return check.Rows.Count > 0;
        }
        public static List<Account> GetAccount(string username, string password)
        {
            List<Account> listAccount = new List<Account>();
            string Querry_T = "select * from Account where username=N'" + username + "'And password=N'" + password + "'";
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            foreach (DataRow item in check.Rows)
            {
                Account ac = new Account(item);
                listAccount.Add(ac);
            }
            return listAccount;

        }
        public static Account GetAccount(int Id_MaTK)
        {
            List<Account> listAccount = new List<Account>();
            string Querry_T = "select * from Account where Id ="+ Id_MaTK;
            DataTable check = DataProvider.instanse.Executequerry(Querry_T);
            foreach (DataRow item in check.Rows)
            {
                Account ac = new Account(item);
                listAccount.Add(ac);
            }
            return listAccount[0];

        }
        public static  List<QuyenSD>  GetListQuyen(int Id_Tk)
        {
            List<QuyenSD> listQuyen = new List<QuyenSD>();
           string querry = "exec 	GetListQuyenByid1 '" + Id_Tk + "'";
            DataTable check = DataProvider.instanse.Executequerry(querry);
            if (check == null) return null;
            foreach (DataRow item in check.Rows)
            {
                QuyenSD ac = new QuyenSD(item);
                listQuyen.Add(ac);
            }
            return listQuyen;
        }
    }
}
