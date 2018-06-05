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
using TNTA.GUI;

namespace TNTA.DTO
{
    public partial class Form_CaNhanCuaSV : Form
    {
        private SinhVien sv;
        public int MSVKT { get; set; }
        public int id_TV { get; set; }
        private SV_KyThi SV_KT;
        public Form_CaNhanCuaSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(SV_KT.TongDiem ==0)
            {
                Form_Thi f = new Form_Thi();
                f.MSVKT = MSVKT;
                f.id_TV = id_TV;
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã hoàn thành kỳ thi !", "THông báo");
            }
          
        }

        private void Form_CaNhanCuaSV_Load(object sender, EventArgs e)
        {
             sv = ThanhVienDAO.GetThongTinSV(MSVKT);
            lb_XinChao.Text = "Xin chào : " + sv.HoVaTen;
             SV_KT = SinhVien_KyThiDAO.GetById(MSVKT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_DoiMatKhau f = new Form_DoiMatKhau();
            f.TT = 1;
            f.Id_Account = id_TV;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SV_KT.TongDiem != 0)
            {
                MessageBox.Show(" Điểm thi của bạn là  :"+ SV_KT.TongDiem, "THông báo");
            }
            else
            {
                MessageBox.Show("Điểm của bạn hiện tại chưa có. Vui lòng tham gia kỳ thi", "THông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
