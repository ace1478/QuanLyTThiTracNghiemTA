using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class TTKTDAO
    {
        public static List<TTKT> LoadDSThongTinKyThi()
        {
            List<TTKT> list = new List<TTKT>();
            String querry = "Select * From ThongTinKyThi";
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    TTKT AC = new TTKT(item);
                    list.Add(AC);
                }
                return list;
            }
        }
        public static TTKT GetTTKT(int MSVKT)
        {
            List<TTKT> list = new List<TTKT>();
            String querry = "exec GetTTKT_ThanhVienDAO '"+MSVKT+"'";
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    TTKT AC = new TTKT(item);
                    list.Add(AC);
                }
                return list[0];
            }
        }
        public static void EditTTKT(string TenKyThi, String ThoiGianThi, string NgayThi, string CoQuanToChuc, string DiaDiemThi, string MatKhau, int MaTTKT)
        {
            string querry = "update ThongTinKyThi set TenKyThi=N'" + TenKyThi + "', ThoiGianThi='" + ThoiGianThi + "',NgayThi=N'" + NgayThi + "', CoQuanToChuc=N'" + CoQuanToChuc + "' ,DiaDiemThi=N'" + DiaDiemThi + "', MatKhau = N'"+MatKhau+"' Where MaTTKT=" + MaTTKT;
            DataProvider.instanse.ExecuteNonquerry(querry);

        }
        public static void AddTTKT(string TenKyThi, String ThoiGianThi, string NgayThi, string CoQuanToChuc, string DiaDiemThi,string MatKhau)
        {
            string querry = "insert into ThongTinKyThi values(N'" + TenKyThi + "','" + ThoiGianThi + "','" + NgayThi + "',N'" + CoQuanToChuc + "',N'" + DiaDiemThi + "',N'"+ MatKhau + "')";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void DeletedTTKT(int id)
        {
            string querry = "delete ThongTinKyThi where MaTTKT=" + id;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static string GetMK(int MaTTKT)
        {
            string MatKhau = null;
            String querry = "select * from ThongTinKyThi where  MaTTKT= " + MaTTKT ;
            DataTable DT = new DataTable();
            DT = DataProvider.instanse.Executequerry(querry);
            if (DT.Rows.Count == 0) return null;
            else
            {
                foreach (DataRow item in DT.Rows)
                {
                    TTKT AC = new TTKT(item);
                    MatKhau = AC.MatKhau;
                }
                return MatKhau;
            }
        }
     
    }
}
