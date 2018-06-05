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
    public partial class Form_Login : Form
    {
        public int TrangThai { get; set; }
        public Form_Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if(TrangThai==1)
            {
                string username = tx_user.Text;
                string password = tx_Password.Text;
                if (Login(username, password))
                {
                    List<Account> list = AccountDAO.GetAccount(username, password);
                    Account TK = list[0] as Account;
                    Form_Main frm = new Form_Main();
                    frm.Id_TaiKhoan = TK.id;
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn đã sai tên đăng nhập hoặc mật khẩu!");
                }
               
            }
            else
            {
                string username = tx_user.Text;
                string password = tx_Password.Text;
                if (ThanhVienDAO.Login_Check(username, password))
                {
                    List<ThanhVien> list = ThanhVienDAO.GetAccount(username, password);
                    ThanhVien TK = list[0] as ThanhVien;
                    Form_CaNhanCuaSV f = new Form_CaNhanCuaSV();
                    f.MSVKT = TK.MaSVKT;
                    f.id_TV = TK.id_ThanhVien;
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Bạn đã sai tên đăng nhập hoặc mật khẩu!");
                }
            }
           
        }
        public bool Login(string username, string password)
        {
            return AccountDAO.Login_Check(username, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_LuaChon f = new GUI.Form_LuaChon();
            this.Hide();
            f.Show();
        }

        private void tx_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter)
            {
                if (TrangThai == 1)
                {
                    string username = tx_user.Text;
                    string password = tx_Password.Text;
                    if (Login(username, password))
                    {
                        List<Account> list = AccountDAO.GetAccount(username, password);
                        Account TK = list[0] as Account;
                        Form_Main frm = new Form_Main();
                        frm.Id_TaiKhoan = TK.id;
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã sai tên đăng nhập hoặc mật khẩu!");
                    }

                }
                else
                {
                    string username = tx_user.Text;
                    string password = tx_Password.Text;
                    if (ThanhVienDAO.Login_Check(username, password))
                    {
                        List<ThanhVien> list = ThanhVienDAO.GetAccount(username, password);
                        ThanhVien TK = list[0] as ThanhVien;
                        Form_CaNhanCuaSV f = new Form_CaNhanCuaSV();
                        f.MSVKT = TK.MaSVKT;
                        this.Hide();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã sai tên đăng nhập hoặc mật khẩu!");
                    }
                }
            }
        }
    }
}
