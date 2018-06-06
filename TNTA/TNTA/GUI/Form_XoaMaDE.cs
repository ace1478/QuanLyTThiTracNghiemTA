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

namespace TNTA.GUI
{
    public partial class Form_XoaMaDE : Form
    {
        public Form_XoaMaDE()
        {
            InitializeComponent();
        }

        private void Form_XoaMaDE_Load(object sender, EventArgs e)
        {
            cb_MaDe.DataSource = MaDeThiDAO.GetListMaDeThi();
            cb_MaDe.ValueMember = "Id_MaDe";
            cb_MaDe.DisplayMember = "MaDe";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=0;
            id = int.Parse(cb_MaDe.SelectedValue.ToString());
            if (MessageBox.Show("Bạn có muốn xóa mã đề  này không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (id == 0) MessageBox.Show("Bạn chưa chọn mã đề thi nào");
                else
                {
                    ChiTiet_DocDAO.Delete(id);
                    ChiTiet_NguPhapDAO.Delete(id);
                    SinhVien_KyThiDAO.Delete(id);
                    MaDeThiDAO.Delete(id);
                  
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo");
                }
                this.Hide();


            }
        }
    }
}
