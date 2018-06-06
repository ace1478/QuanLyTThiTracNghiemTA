using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNTA.GUI
{
    public partial class UC_QuanLyKyThi : UserControl
    {
        public UC_QuanLyKyThi()
        {
            InitializeComponent();
        }

        private void btn_DSKT_Click(object sender, EventArgs e)
        {
            Form_QuanLyKyThi f = new Form_QuanLyKyThi();
            f.Show();
        }

        private void btn_DeThi_Click(object sender, EventArgs e)
        {
            Form_QuanLyBoDeThi f = new Form_QuanLyBoDeThi();
            f.Show();
        }

        private void btn_SV_DeThi_Click(object sender, EventArgs e)
        {
            Form_QuanLyThi f = new Form_QuanLyThi();
            f.Show();
        }
    }
}
