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
    public partial class Form_Thi : Form
    {
        private List<BTDoc> listBTDoc = new List<BTDoc>();
        private List<BTNguPhap> listBTNguPhap = new List<BTNguPhap>();
        private List<Panel> ListPl = new List<Panel>();
        private List<List<CauHoiDoc>> ListCauHoiDoc = new List<List<CauHoiDoc>>();
        private List<RadioButton> ListRB_Main = new List<RadioButton>();
        private int STT_DoanVan = -1;
        private int SoThuTu = 0;
        private int sl;
        private int gio = 1;
        private int phut = 0;
        private int giay = 0;
        private int TongGiay = 3600;
        private int SoCauDung = 0;
        private int Id_Made;

        public int MSVKT { get; set; }
        public int id_TV { get; set; }
        public Form_Thi()
        {
            InitializeComponent();
          

        }

        private void Form_Thi_Load(object sender, EventArgs e)
        {
            Id_Made = SinhVien_KyThiDAO.GetMaDe(MSVKT);
            listBTDoc = BTDocDAO.LoadDSCauHoi_TheoMaDe(Id_Made);
            listBTNguPhap = BTNguPhapDAO.LoadDSCauHoi_TheoMaDe(Id_Made);
            foreach (BTDoc item in listBTDoc)
            {
                List<CauHoiDoc> rb = CauHoiDocDAO.LoadDSCauHoiDoc(item.Id_Doc);
                ListCauHoiDoc.Add(rb);
            }
            SinhVien sv = ThanhVienDAO.GetThongTinSV(MSVKT);
            lb_name.Text = sv.HoVaTen;
            lb_MSV.Text = sv.MaSV;
            TTKT tk = TTKTDAO.GetTTKT(MSVKT);
           
            lb_NamKT.Text = tk.TenKyThi;
            timer1.Interval = 1000;
            timer1.Start();
             sl = listBTNguPhap.Count;
            foreach (List<CauHoiDoc> item in ListCauHoiDoc)
            {
                sl = sl + item.Count;
            }

            for (int i = 0; i < sl; i++)
            {
                TaoListBTT(5, 50 * i, i);
            }
            ThemCode(0);
            btn_TC.Hide();


        }
        public void ThemCode(int TS)
        {
            pl_CauHoi.Controls.Clear();
            Label btm = new Label() { Name = "lb_Stt", Location = new Point(10, 28), Text = "Câu" + (TS + 1), AutoSize = true };
            Label btm1 = new Label() { Name = "lb_CauHoi", Location = new Point(51, 28), Text = listBTNguPhap[TS].CauHoi, AutoSize = true };
            Label btm2 = new Label() { Name = "lb_DapAnA", Location = new Point(10, 66), Text = "A:    " + listBTNguPhap[TS].DapAn1, AutoSize = true };
            Label btm3 = new Label() { Name = "lb_DapAnB", Location = new Point(10, 91), Text = "B:    " + listBTNguPhap[TS].DapAn2, AutoSize = true };
            Label btm4 = new Label() { Name = "lb_DapAnC", Location = new Point(10, 115), Text = "C:    " + listBTNguPhap[TS].DapAn3, AutoSize = true };
            Label btm5 = new Label() { Name = "lb_DapAnD", Location = new Point(10, 144), Text = "D:    " + listBTNguPhap[TS].DapAn4, AutoSize = true };
            pl_CauHoi.Controls.Add(btm); pl_CauHoi.Controls.Add(btm1); pl_CauHoi.Controls.Add(btm2); pl_CauHoi.Controls.Add(btm3); pl_CauHoi.Controls.Add(btm4);
            pl_CauHoi.Controls.Add(btm5);
        }
        private void ThemCode_DoanVan(int id, int STT)
        {
            pl_CauHoi.Controls.Clear();
            Label btm = new Label() { Name = "lb_Stt", Location = new Point(3, 7), Text = "Đoạn Văn", AutoSize = true };
            RichTextBox rb = new RichTextBox() { Text = listBTDoc[id].DoanVan, Location = new Point(55, 7),Height=140,Width=720,Enabled=false };
            pl_CauHoi.Controls.Add(rb);
            pl_CauHoi.Controls.Add(btm);
            int i = 0;
            foreach (CauHoiDoc item in ListCauHoiDoc[id])
            {
                Label btm1 = new Label() { Location = new Point(3, 170 + i * 30), Text = "" + (STT+1), AutoSize = true };
                Label btm2 = new Label() { Name = "lb_DapAnA", Location = new Point(64, 170 + i * 30), Text = "A: " + item.DapAn1, AutoSize = true };
                Label btm3 = new Label() { Name = "lb_DapAnB", Location = new Point(252, 170 + i * 30), Text = "B: " + item.DapAn2, AutoSize = true };
                Label btm4 = new Label() { Name = "lb_DapAnC", Location = new Point(458, 170 + i * 30), Text = "C: " + item.DapAn3, AutoSize = true };
                Label btm5 = new Label() { Name = "lb_DapAnD", Location = new Point(643, 170 + i * 30), Text = "D: " + item.DapAn4, AutoSize = true };
                pl_CauHoi.Controls.Add(btm1); pl_CauHoi.Controls.Add(btm2); pl_CauHoi.Controls.Add(btm3); pl_CauHoi.Controls.Add(btm4);
                pl_CauHoi.Controls.Add(btm5);
                i++; STT++;
            }

        }
        private void TaoListBTT(int x, int y, int stt)
        {
            Panel pl = new Panel() { Name = "Pl" + stt, Location = new Point(x, y) };
            pl.Width = 200; pl.Height = 50;
            ListPl.Add(pl);

            Pl_CauTraLoi.Controls.Add(pl);

            Label lb = new Label() { Text = "Câu" + (stt + 1), Location = new Point(3, 15) };
            RadioButton rb1 = new RadioButton() { Text = "A", Name = "1", Location = new Point(50, 10), Tag = stt };
            RadioButton rb2 = new RadioButton() { Text = "B", Name = "2", Location = new Point(90, 10), Tag = stt };
            RadioButton rb3 = new RadioButton() { Text = "C", Name = "3", Location = new Point(130, 10), Tag = stt };
            RadioButton rb4 = new RadioButton() { Text = "D", Name = "4", Location = new Point(170, 10), Tag = stt };

            ListRB_Main.Add(rb1); ListRB_Main.Add(rb2); ListRB_Main.Add(rb3); ListRB_Main.Add(rb4);
            pl.Controls.Add(rb4);
            pl.Controls.Add(rb3);
            pl.Controls.Add(rb2);
            pl.Controls.Add(rb1);
            pl.Controls.Add(lb);



        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_NB_Click(object sender, EventArgs e)
        {
            List<List<string>> list_DapAn = List_DapAnCauHoi();
             List<string> listDapAnDung = GetListDapAnDung();
            foreach (RadioButton item in ListRB_Main)
            {
                if(item.Checked==true)
                {
                    int CauSo = int.Parse(item.Tag.ToString());
                    if (list_DapAn[CauSo][int.Parse(item.Name.ToString())-1] == listDapAnDung[CauSo]) SoCauDung++;
                    
                    
                }
            }
            MessageBox.Show("Số điểm của bạn là :" + SoCauDung, "Thông Báo");
            string querry = "Update Sv_KyThi set TongDiem=" + SoCauDung + "where MaSVKT=" + MSVKT;
            DataProvider.instanse.ExecuteNonquerry(querry);
            timer1.Stop();

            btn_NB.Enabled = false;
            btn_Back.Enabled = false;
            btn_Next.Enabled = false;
            btn_TC.Show();
        }



        private void btn_Next_Click(object sender, EventArgs e)
        {
            SoThuTu++;

            if (SoThuTu >= listBTNguPhap.Count)
            {
                
                if (STT_DoanVan >= listBTDoc.Count) { STT_DoanVan = listBTDoc.Count-1; }
                else
                {
                    if(SoThuTu>sl) { ThemCode_DoanVan(STT_DoanVan, SoThuTu);SoThuTu = SoThuTu - ListCauHoiDoc[STT_DoanVan].Count; }
                    if (STT_DoanVan == -1) STT_DoanVan = 0;
                    ThemCode_DoanVan(STT_DoanVan, SoThuTu);
                    if(STT_DoanVan!=listBTDoc.Count-1) SoThuTu = SoThuTu + ListCauHoiDoc[STT_DoanVan].Count - 1;
                    else SoThuTu = SoThuTu + ListCauHoiDoc[STT_DoanVan].Count ;
                    if (SoThuTu > sl) SoThuTu = sl;
                    
                }
                STT_DoanVan++;
                if (STT_DoanVan >= listBTDoc.Count) { STT_DoanVan = listBTDoc.Count-1 ; }
            }
            else
            {
                ThemCode(SoThuTu);
                
            }
           

        }

        private string ConvertS_To_H(int s)
        {
            string Gio;
            string Phut;
            string Giay;
            gio = s / 3600;
            phut = (s - gio * 3600) / 60;
            giay = s - gio * 3600 - phut * 60;
            if (gio >= 10) { Gio = gio.ToString(); }
            else { Gio = "0" + gio; }
            if (phut >= 10) { Phut = phut.ToString(); }
            else { Phut = "0" + phut; }
            if (giay >= 10) { Giay = giay.ToString(); }
            else { Giay = "0" + giay; }
            string st = Gio + ":" + Phut + ":" + Giay;
            return st;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            TongGiay--;
            string text = ConvertS_To_H(TongGiay);
            lb_Time.Text = text;
            if (TongGiay == 0)
            {
                timer1.Stop();
                MessageBox.Show("Bạn đã hết giơ làm bài", "Thông báo");

            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (SoThuTu != 0)
            { 
                if(STT_DoanVan>=0)
                {
                    //if(STT_DoanVan>=1) SoThuTu = SoThuTu - ListCauHoiDoc[STT_DoanVan].Count- ListCauHoiDoc[STT_DoanVan-1].Count;
                    //else SoThuTu = SoThuTu - ListCauHoiDoc[STT_DoanVan].Count;
                    //STT_DoanVan--;
                    STT_DoanVan--;
                    int j = 0;
                    for (int i=0;i<STT_DoanVan;i++)
                    {
                        j =j+ ListCauHoiDoc[i].Count();
                    }
                    SoThuTu = listBTNguPhap.Count + j;
                   

                }
                    
                else
                {
                    SoThuTu--;
                }
               

                if (STT_DoanVan >= 0) { ThemCode_DoanVan(STT_DoanVan, SoThuTu);SoThuTu = SoThuTu + ListCauHoiDoc[STT_DoanVan].Count; }

                else
                {
                    if(SoThuTu==listBTNguPhap.Count) SoThuTu--;

                    ThemCode(SoThuTu);
                }
            }

        }
        private List<string> GetListDapAnDung()
        {
            List<string> list = new List<string>();
            foreach(BTNguPhap item in listBTNguPhap)
            {
                string st = item.DapAnDung;
                list.Add(st);
            }
            foreach(List<CauHoiDoc> item in ListCauHoiDoc)
            {
                foreach (CauHoiDoc item1 in item)
                {
                    string st = item1.DapAnDung;
                    list.Add(st);
                }
            }
            return list;
        }
        private List<List<string>> List_DapAnCauHoi()
        {
            List<List<string>> List_Tong= new List<List<string>>();
            foreach (BTNguPhap item in listBTNguPhap)
            {
                List<string> list = new List<string>();
                list.Add(item.DapAn1);
                list.Add(item.DapAn2);
                list.Add(item.DapAn3);
                list.Add(item.DapAn4);
                List_Tong.Add(list);
            }
            foreach (List<CauHoiDoc> item in ListCauHoiDoc)
            {
                foreach (CauHoiDoc item1 in item)
                {
                    List<string> list = new List<string>();
                    list.Add(item1.DapAn1);
                    list.Add(item1.DapAn2);
                    list.Add(item1.DapAn3);
                    list.Add(item1.DapAn4);
                    List_Tong.Add(list);
                }
            }
            return List_Tong;
        }

        private void pl_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TC_Click(object sender, EventArgs e)
        {
            Form_CaNhanCuaSV f = new Form_CaNhanCuaSV();
            f.id_TV = id_TV;
            f.MSVKT = MSVKT;
            this.Hide();
            f.Show();
        }
    }
}
