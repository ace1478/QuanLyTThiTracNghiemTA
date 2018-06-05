using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class SinhVienLopDAO
    {
        public static List<SinhVienLop> LoadDSSV()
        {
            List<SinhVienLop> List = new List<SinhVienLop>();
            string querry = "select MaSV,HoVaTen,TenLop from SinhVien,Lop where SinhVien.MaLop=Lop.MaLop";
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    SinhVienLop SinhVienLop = new SinhVienLop(item);
                    List.Add(SinhVienLop);
                }
            }
            else return null;
            return List;
        }
        public static List<SinhVienLop> LoadDSSVThi(int id)
        {
            List<SinhVienLop> List = new List<SinhVienLop>();
            string querry = "select SinhVien.MaSV,HoVaTen,TenLop from SinhVien,Lop,SV_KyThi where SinhVien.MaSV=SV_KyThi.MaSV and SinhVien.MaLop=Lop.MaLop and MaTTKT=" + id;
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    SinhVienLop SinhVienLop = new SinhVienLop(item);
                    List.Add(SinhVienLop);
                }
            }
            else return null;
            return List;
        }
    }
}
