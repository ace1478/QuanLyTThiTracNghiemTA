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
    public partial class Form_DoiMatKhau : Form
    {
        public int Id_Account { get; set; }
        private Account TK = new Account();
        private ThanhVien TV = new ThanhVien();
        public int TT { get; set; } // để xem bên admin gọi , hay sinhvien gọi
        public Form_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void Form_DoiMatKhau_Load(object sender, EventArgs e)
        {
            if(TT==0)
            {
                TK = AccountDAO.GetAccount(Id_Account);
            }
            else if(TT==1)
            {
                TV = ThanhVienDAO.GetAccount(Id_Account);
            }
            lb_thongbao.Hide();
            lb_thongbao1.Hide();
            lb_thongbao2.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private int check_MatKhauCu()// trả về 0 là ko có lỗi
        {
            int check = 0;
           
            if (tb_mk.Text == "") { lb_thongbao.Text = "Bạn chưa nhập dữ liệu"; lb_thongbao.Show(); check = 1; }
            else
            {
                if (tb_mk.Text != TK.Password &&TT==0)
                {
                    lb_thongbao.Text = "Mật khẩu sai"; lb_thongbao.Show(); check = 1;
                }
                if (tb_mk.Text != TV.Password && TT == 1)
                {
                    lb_thongbao.Text = "Mật khẩu sai"; lb_thongbao.Show(); check = 1;
                }

            }
            if (check == 0) lb_thongbao.Hide();

            return check;
        }
        private int check_MatKhauMoi()
        {
            int check = 0;
            if (tb_Mkmoi.Text == "") { check = 1; lb_thongbao1.Text = "Bạn chưa nhập dữ liệu"; lb_thongbao1.Show(); }
            else lb_thongbao1.Hide();
            return check;
        }
        private int check_NLMatKhau()
        {
            int check = 0;
            if (tb_NLMk.Text == "") { check = 1; lb_thongbao2.Text = "Bạn chưa nhập dữ liệu"; lb_thongbao2.Show(); }
            else
            {
                if(tb_NLMk.Text!=tb_Mkmoi.Text)
                {
                    check = 1;
                    lb_thongbao2.Text = "Mật Khẩu không khớp! vui lòng nhập lại";
                    lb_thongbao2.Show();
                }
            }
            if (check == 0) lb_thongbao2.Hide();
             return check;
        }
        private int check_dulieu()
        {
            int check = 0;
            if(check_MatKhauCu()==1)  check=1;
            if (check_MatKhauMoi() == 1) check = 1;
            if (check_NLMatKhau() == 1) check = 1;
            return check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check_dulieu()==0)
            {
                try
                {
                    if (TT==0)
                    { 
                        DataProvider.instanse.ExecuteNonquerry("update Account set Password = N'" + tb_Mkmoi.Text + "' where  Id=" + Id_Account);
                    }
                    else if(TT==1)
                    {
                    DataProvider.instanse.ExecuteNonquerry("update ThanhVien set Password = N'" + tb_Mkmoi.Text + "' where  Id_ThanhVien=" + Id_Account);
                     }
                MessageBox.Show("Cập nhật thành công");
                    this.Hide();
                }
                catch
                {
                   MessageBox.Show(" Chức năng này đang trong quá trình sửa chữa");
                }
            }
    }

    private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát khỏi chức nằng này không !","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) ==DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
