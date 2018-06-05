using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNTA.GUI
{
    public partial class Form_LuaChon : Form
    {
        public Form_LuaChon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            this.Hide();
            f.TrangThai = 0;
            f.ShowDialog();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            this.Hide();
            f.TrangThai = 1;
            f.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn phải đăng nhập để thực hiên chức năng này","Thông báo",MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn phải đăng nhập để thực hiên chức năng này", "Thông báo", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn phải đăng nhập để thực hiên chức năng này", "Thông báo", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn phải đăng nhập để thực hiên chức năng này", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
