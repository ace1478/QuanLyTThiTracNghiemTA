using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DTO;

namespace TNTA.DAO
{
    class CauHoiDocDAO
    {
        public static List<CauHoiDoc> LoadDSCauHoiDoc(int id_BTDoc)
        {
            List<CauHoiDoc> List = new List<CauHoiDoc>();
            string querry = "select * from CauHoiDoc where id_doc=" + id_BTDoc;
            DataTable Table = new DataTable();
            Table = DataProvider.instanse.Executequerry(querry);
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    CauHoiDoc BTDoc = new CauHoiDoc(item);
                    List.Add(BTDoc);
                }
            }
            else return null;
            return List;
        }
        public static void Edit_CauHoiDoc(int MaCauHoiDoc, string DapAn1, string DapAn2, string DapAn3, string DapAn4, string DapAnDung)
        {
            string querry = "update CauHoiDoc set DapAn1=N'" + DapAn1 + "',DapAn2=N'" + DapAn2 + "',DapAn3=N'" + DapAn3 + "',DapAn4=N'" + DapAn4 + "',DapAnDung=N'" + DapAnDung + "' Where MaCauHoiDoc=" + MaCauHoiDoc;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void Add_CauHoiDoc(int STT, string DapAn1, string DapAn2, string DapAn3, string DapAn4, string DapAnDung, int id_doc)
        {
            string querry = "insert into CauHoiDoc  values(" + STT + ",N'" + DapAn1 + "', N'" + DapAn2 + "', N'" + DapAn3 + "', N'" + DapAn4 + "', N'" + DapAnDung + "'," + id_doc + ")";
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
        public static void Add_LitCauHoiDoc(List<CauHoiDoc> List)
        {
            for (int i = 0; i < 10; i++)
            {
                Add_CauHoiDoc(List[i].STT, List[i].DapAn1, List[i].DapAn2, List[i].DapAn3, List[i].DapAn4, List[i].DapAnDung, BTDocDAO.Get_IdDoc());
            }
        }
        public static void Delete_CauHoiDoc(int id_doc)
        {
            string querry = "Delete CauHoiDoc where id_doc=" + id_doc;
            DataProvider.instanse.ExecuteNonquerry(querry);
        }
    }
}
