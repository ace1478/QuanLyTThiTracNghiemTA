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
    public partial class UC_HeThong : UserControl
    {
        public UC_HeThong()
        {
            InitializeComponent();
        }

        private void btn_DSTV_Click(object sender, EventArgs e)
        {
            Form_DSQuanTri f = new Form_DSQuanTri();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Quyen f = new Form_Quyen();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_LoaiThanhVien f = new Form_LoaiThanhVien();
            f.Show();
        }
    }
}
