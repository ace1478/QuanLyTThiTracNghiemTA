using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNTA.DAO;
using TNTA.DTO;

namespace TNTA.GUI
{
    public partial class Form_AddDeThi : Form
    {
        
        public Form_AddDeThi()
        {
            InitializeComponent();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            List<BTNguPhap>  listBTNP=BTNguPhapDAO.LoadDSCauHoi();
            int Count_NP = listBTNP.Count;
            List<BTDoc> listDOC = BTDocDAO.LoadDSCauHoi();
            int Count_Doc = listDOC.Count;
           
            List<int> listNP_Check = new List<int> ();
            List<int> listDOC_Check= new List<int>();
            while (listNP_Check.Count < int.Parse( txb_NP.Text))
            {
                Random rd = new Random();
                int number=rd.Next(0, Count_NP - 1);
                if (listNP_Check == null) listNP_Check.Add(number);
                else
                {
                    while (listNP_Check.Contains(number))
                    {
                        number = rd.Next(0, Count_NP - 1);
                    }
                    listNP_Check.Add(number);
                }
                    
            }
            while (listDOC_Check.Count < int.Parse(tx_DoanVan.Text))
            {
                Random rd = new Random();
                int number = rd.Next(0, Count_Doc - 1);
                if (listDOC_Check == null) listDOC_Check.Add(number);
                else
                {
                    while (listDOC_Check.Contains(number))
                    {
                        number = rd.Next(0, Count_Doc - 1);
                    }
                    listDOC_Check.Add(number);
                }

            }
            MaDeThiDAO.Add(Txb_made.Text);
            foreach (int item in listNP_Check)
            {
                ChiTiet_NguPhapDAO.Add(MaDeThiDAO.GetIdCuoi(), listBTNP[item].Id_BTNguPhap);
            }
            foreach (int item in listDOC_Check)
            {
                ChiTiet_DocDAO.Add(MaDeThiDAO.GetIdCuoi(), listDOC[item].Id_Doc);
            }
            MessageBox.Show("Bạn đã tạo mới để thi thành công", "Thông báo");
            this.Hide();

        }

        private void Form_AddDeThi_Load(object sender, EventArgs e)
        {

        }
    }
}
