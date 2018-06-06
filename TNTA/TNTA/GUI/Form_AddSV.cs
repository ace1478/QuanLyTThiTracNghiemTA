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
    public partial class Form_AddSV : Form
    {
        private int trang = 1;
        private int i = 0;
      
        public int MaKyThi { get; set; }
        private List<SinhVien> list;
        private TTKT KyThi;
        private List<CheckBox> listCheckBox = new List<CheckBox>();
        internal TTKT KyThi1
        {
            get
            {
                return KyThi;
            }

            set
            {
                KyThi = value;
            }
        }
        public Form_AddSV()
        {
            InitializeComponent();
        }

        private void Form_AddSV_Load(object sender, EventArgs e)
        {
            list = SinhVienDAO.LoadSVkoTrongKyThi(MaKyThi);
           
            LoadDS();
          
        }
        public void LoadDS()
        {

          

           
            if(list.Count<=10)
            {
                Label Name1 = new Label() { Text = "Mã Sinh Viên", Location = new Point(15, 0), AutoSize = true };
                Label lbLop1 = new Label() { Text = "Họ Và Tên", Location = new Point(150, 0), AutoSize = true };
                Label lbMASV1 = new Label() { Text = "Tên Lớp", Location = new Point(350, 0) , AutoSize = true };
                pl_cha.Controls.Add(Name1);
                pl_cha.Controls.Add(lbLop1);
                pl_cha.Controls.Add(lbMASV1);
                for ( i = 0; i < list.Count; i++)
                {
                    CheckBox ckb = new CheckBox() { Name = "ckb" + i.ToString(), Text = list[i].MaSV, Location = new Point(10, (i + 1) * 30), AutoSize = true };
                    Label Name = new Label() { Text = list[i].HoVaTen, Location = new Point(150, (i + 1) * 30),AutoSize = true };
                    Label lbLop = new Label() { Text = LopDAO.LoadTenLop(list[i].MaLop), Location = new Point(350, (i + 1) * 30), AutoSize = true };
                    listCheckBox.Add(ckb);
                    pl_cha.Controls.Add(ckb);
                    pl_cha.Controls.Add(Name);
                    pl_cha.Controls.Add(lbLop);

                }
            }
            else
            {
                Label Name1 = new Label() { Text = "Mã Sinh Viên", Location = new Point(15, 0), AutoSize = true };
                Label lbLop1 = new Label() { Text = "Họ Và Tên", Location = new Point(150, 0), AutoSize = true };
                Label lbMASV1 = new Label() { Text = "Tên Lớp", Location = new Point(350, 0), AutoSize = true };
                pl_cha.Controls.Add(Name1);
                pl_cha.Controls.Add(lbLop1);
                pl_cha.Controls.Add(lbMASV1);
                for ( i = 0; i < 10; i++)
                {
                    CheckBox ckb = new CheckBox() { Name = "ckb" + i.ToString(), Text = list[i].MaSV, Location = new Point(10, (i + 1) * 30), AutoSize = true };
                    Label Name = new Label() { Text = list[i].HoVaTen, Location = new Point(150, (i + 1) * 30), AutoSize = true };
                    Label lbLop = new Label() { Text = LopDAO.LoadTenLop(list[i].MaLop), Location = new Point(350, (i + 1) * 30), AutoSize = true };
                    listCheckBox.Add(ckb);
                    pl_cha.Controls.Add(ckb);
                    pl_cha.Controls.Add(Name);
                    pl_cha.Controls.Add(lbLop);

                }
            }
            
        }

        private void bt_ADD_Click(object sender, EventArgs e)
        {
            foreach (CheckBox ckb in listCheckBox)
            {
                if (ckb.Checked == true)
                {
                    SinhVien_KyThiDAO.Add(int.Parse(ckb.Text), MaKyThi);

                    int MSVKT = SinhVien_KyThiDAO.GetMSVKTCuoi();

                    string MatKhau = TTKTDAO.GetMK(MaKyThi);

                    string querry = "Insert into ThanhVien values ('" + ckb.Text + "','" + MatKhau + "'," + MSVKT + " )";
                    DataProvider.instanse.ExecuteNonquerry(querry);



                }



            }
            MessageBox.Show("Thêm Thành Công");
            Form_DSSV_KyThi f = new Form_DSSV_KyThi();
            f.KyThi1 = this.KyThi;
            this.Hide();
            f.Show();

        }
        private bool check_ListCB( CheckBox cb)
        {
            foreach( CheckBox item in listCheckBox)
            {
                if (cb.Name == item.Name) return false;
            }
            return true;
        }
        private void btn_TrangTruoc_Click(object sender, EventArgs e)
        {
           
            if (trang==1) { MessageBox.Show("Bạn đang ở trang đầu", "Thông báo"); }
            else
            {
                pl_cha.Controls.Clear();
                trang--;
                if (i == list.Count) i = i - i % 10 - 10;
                else i = i - 10;

                lb_Trang.Text = "Trang" + trang;
                Label Name1 = new Label() { Text = "Mã Sinh Viên", Location = new Point(15, 0),AutoSize=true };
                Label lbLop1 = new Label() { Text = "Họ Và Tên", Location = new Point(150, 0), AutoSize = true };
                Label lbMASV1 = new Label() { Text = "Tên Lớp", Location = new Point(350, 0), AutoSize = true };
                pl_cha.Controls.Add(Name1);
                pl_cha.Controls.Add(lbLop1);
                pl_cha.Controls.Add(lbMASV1);
                int stt = 0;
                int j = i;
                
                for ( j=i; j < i+10; j++)
                {
                    
                    CheckBox ckb = new CheckBox() { Name = "ckb" + j.ToString(), Text = list[j].MaSV, Location = new Point(10, (stt + 1) * 30), AutoSize = true };
                    Label Name = new Label() { Text = list[j].HoVaTen, Location = new Point(150, (stt + 1) * 30), AutoSize = true };
                    Label lbLop = new Label() { Text = LopDAO.LoadTenLop(list[j].MaLop), Location = new Point(350, (stt + 1) * 30), AutoSize = true };
                    if(check_ListCB(ckb)==true) listCheckBox.Add(ckb);
                    pl_cha.Controls.Add(ckb);
                    pl_cha.Controls.Add(Name);
                    pl_cha.Controls.Add(lbLop);
                    stt++;
                }
                i = j;

            }
        }

        private void btn_TrangSau_Click(object sender, EventArgs e)
        {
            int stt = 0;
            if(list.Count/10 ==0)
            {
                MessageBox.Show("Bạn đang ở trang cuối", "Thông báo");
            }
            else
            {
                if (trang == (list.Count / 10) + 1 && trang != 1)
                { MessageBox.Show("Bạn đang ở trang cuối", "Thông báo"); }
                else
                {
                    pl_cha.Controls.Clear();
                    trang++;
                    lb_Trang.Text = "Trang" + trang;
                    Label Name1 = new Label() { Text = "Mã Sinh Viên", Location = new Point(15, 0), AutoSize = true };
                    Label lbLop1 = new Label() { Text = "Họ Và Tên", Location = new Point(150, 0), AutoSize = true };
                    Label lbMASV1 = new Label() { Text = "Tên Lớp", Location = new Point(350, 0), AutoSize = true };
                    pl_cha.Controls.Add(Name1);
                    pl_cha.Controls.Add(lbLop1);
                    pl_cha.Controls.Add(lbMASV1);
                    if (i + 10 > list.Count)
                    {
                        int j = i;
                        for (j = i; j < list.Count; j++)
                        {


                            CheckBox ckb = new CheckBox() { Name = "ckb" + j.ToString(), Text = list[j].MaSV, Location = new Point(10, (stt + 1) * 30), AutoSize = true };
                            Label Name = new Label() { Text = list[j].HoVaTen, Location = new Point(150, (stt + 1) * 30), AutoSize = true };
                            Label lbLop = new Label() { Text = LopDAO.LoadTenLop(list[j].MaLop), Location = new Point(350, (stt + 1) * 30), AutoSize = true };
                            if (check_ListCB(ckb) == true) listCheckBox.Add(ckb);
                            pl_cha.Controls.Add(ckb);
                            pl_cha.Controls.Add(Name);
                            pl_cha.Controls.Add(lbLop);
                            stt++;
                        }
                        i = j;
                    }
                    else
                    {
                        int j = i;
                        for (j = i; j < i + 10; j++)
                        {

                            CheckBox ckb = new CheckBox() { Name = "ckb" + j.ToString(), Text = list[j].MaSV, Location = new Point(10, (stt + 1) * 30) };
                            Label Name = new Label() { Text = list[j].HoVaTen, Location = new Point(150, (stt + 1) * 30) };
                            Label lbLop = new Label() { Text = LopDAO.LoadTenLop(list[j].MaLop), Location = new Point(350, (stt + 1) * 30) };
                            if (check_ListCB(ckb) == true) listCheckBox.Add(ckb);
                            pl_cha.Controls.Add(ckb);
                            pl_cha.Controls.Add(Name);
                            pl_cha.Controls.Add(lbLop);
                            stt++;
                        }
                        i = j;
                    }
                }
                
           
               
            }
        }

        private void Form_AddSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            List<SinhVien> list_SV = new List<SinhVien>();
            list_SV = SinhVienDAO.TimKiem_MSV(txb_MaSV.Text);
            if(list_SV==null) { MessageBox.Show("Không có sinh viên nào "); }
            else
            {
                btn_TrangSau.Enabled = false;
                btn_TrangTruoc.Enabled = false;
                pl_cha.Controls.Clear();
                Label Name1 = new Label() { Text = "Mã Sinh Viên", Location = new Point(15, 0), AutoSize = true };
                Label lbLop1 = new Label() { Text = "Họ Và Tên", Location = new Point(150, 0), AutoSize = true };
                Label lbMASV1 = new Label() { Text = "Tên Lớp", Location = new Point(350, 0), AutoSize = true };
                pl_cha.Controls.Add(Name1);
                pl_cha.Controls.Add(lbLop1);
                pl_cha.Controls.Add(lbMASV1);

                int i = 0;
                foreach(SinhVien item in list_SV)
                {
                    CheckBox ckb = new CheckBox() { Text = list_SV[i].MaSV, Location = new Point(10, (i + 1) * 30) };
                    Label Name = new Label() { Text = list_SV[i].HoVaTen, Location = new Point(150,(i+ 1) * 30) };
                    Label lbLop = new Label() { Text = LopDAO.LoadTenLop(list_SV[i].MaLop), Location = new Point(350, (i+1) * 30) };
                    if (check_ListCB(ckb) == true) listCheckBox.Add(ckb);
                    pl_cha.Controls.Add(ckb);
                    pl_cha.Controls.Add(Name);
                    pl_cha.Controls.Add(lbLop);
                }
               
            }

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadDS();
            btn_TrangSau.Enabled = true;
            btn_TrangTruoc.Enabled = true;
        }

        private void rb_All_CheckedChanged(object sender, EventArgs e)
        {
            
            foreach (CheckBox item in listCheckBox)
            {
                item.Checked = true;
            }
            LoadDS();
        }

        private void rb_noAll_CheckedChanged(object sender, EventArgs e)
        {
           
            foreach (CheckBox item in listCheckBox)
            {
                item.Checked = false;
            }
            LoadDS();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Form_DSSV_KyThi f = new Form_DSSV_KyThi();
            f.KyThi1 = this.KyThi;
            this.Hide();
            f.Show();
        }
    }
}
