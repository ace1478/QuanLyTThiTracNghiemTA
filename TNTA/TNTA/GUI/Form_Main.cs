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
using TNTA.GUI;

namespace TNTA
{
    
    public partial class Form_Main : Form
    {
        public int Id_TaiKhoan { get; set; }
        private Account TK = new Account();
        private List<QuyenSD> ListQuyen = new List<QuyenSD>();
        public Form_Main()
        {

            try
            {
                pl_side.Height = btn_system.Height;
                pl_side.Top = btn_system.Top;

            }
            catch
            {

            }

            InitializeComponent();
            UC_HeThong frm = new UC_HeThong();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_cha.Controls.Add(frm);
            //UC_QuanLySinhVien.BringToFront;
        }
        private void btn_system_Click(object sender, EventArgs e)
        {
            pl_side.Height = btn_system.Height;
            pl_side.Top = btn_system.Top;
            if (checkQuyen("Quản lý hệ thống"))
            {
                panel_cha.Controls.Clear();
                UC_HeThong frm = new UC_HeThong();
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                panel_cha.Controls.Add(frm);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này");
            }
            
        }

        private void btn_DSSinhVien_Click_1(object sender, EventArgs e)
        {
            if (checkQuyen("Quản lý danh sách sinh viên"))
            {
                panel_cha.Controls.Clear();
                UC_SinhVien frm = new UC_SinhVien();
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                panel_cha.Controls.Add(frm);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này");
            }
             pl_side.Height = btn_DSSinhVien.Height;
            pl_side.Top = btn_DSSinhVien.Top;
           
        }

        private void btn_CauHoi_Click_1(object sender, EventArgs e)
        {
            pl_side.Height = btn_CauHoi.Height;
            pl_side.Top = btn_CauHoi.Top;
          
            if (checkQuyen("Quản lý ngân hàng câu hỏi"))
            {
                panel_cha.Controls.Clear();
                UC_CauHoi frm = new UC_CauHoi();
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                panel_cha.Controls.Add(frm);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này");
            }

        }

        private void btn_KyThi_Click_1(object sender, EventArgs e)
        {
            if(checkQuyen("Quản lý kỳ thi"))
            {
                panel_cha.Controls.Clear();
                UC_QuanLyKyThi frm = new UC_QuanLyKyThi();
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                panel_cha.Controls.Add(frm);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này");
            }
            pl_side.Height = btn_KyThi.Height;
            pl_side.Top = btn_KyThi.Top;
          
            
        }

        private void btn_Help_Click_1(object sender, EventArgs e)
        {
            pl_side.Height = btn_Help.Height;
            pl_side.Top = btn_Help.Top;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            TK = AccountDAO.GetAccount(Id_TaiKhoan);
            ListQuyen = AccountDAO.GetListQuyen(Id_TaiKhoan);
            lb_XinChao.Text = "Xin chào:" + TK.Hovaten;
        }
        private bool checkQuyen(string quyen)
        {
             foreach(QuyenSD item in ListQuyen)
            {
                if (item.TenQuyen == quyen) return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login f = new Form_Login();
            f.Show();
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            if (checkQuyen("Báo cáo thống kê"))
            {
                panel_cha.Controls.Clear();
                UC_BaoCaoThongKe frm = new UC_BaoCaoThongKe();
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                panel_cha.Controls.Add(frm);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này");
            }
            pl_side.Height = btn_BaoCao.Height;
            pl_side.Top = btn_BaoCao.Top;
        }

        private void resotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = null; ;
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Backup|*.bak|All Files|*.*";
            //Tên của hộp thoại hiện lên - Không có thì sẽ là mặc định
            OPF.Title = "Chọn file ";
            OPF.ShowDialog();
            s = OPF.FileName;
            string querry = "restore database NGANHANGCAUHOI from disk = '" + s + "' WITH NORECOVERY ";
            //try
            //{
                DataProvider.instanse.ExecuteNonquerry(querry);
                MessageBox.Show("Back up dữ liệu thành công");
            //}
            //catch
            //{
            //    MessageBox.Show("Đã phát sinh lỗi ngoài dự kiến, vui lòng thử lại sau");
            //}


        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_DoiMatKhau f = new Form_DoiMatKhau();
            f.Id_Account = Id_TaiKhoan;
            f.TT = 0;
            f.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SVF = new SaveFileDialog();
            string s = null; ;
            SVF.DefaultExt = "bak";
            SVF.Filter = "Backup |*.bak|Text file (*.txt)|*.txt|XML file (*.xml)|*.xml|All files (*.*)|*.*";
            SVF.AddExtension = true;
            SVF.RestoreDirectory = true;
            SVF.Title = "Save file";
           
            if (SVF.ShowDialog() == DialogResult.OK)
            {
                s = SVF.FileName;
            }
            else
            {
                MessageBox.Show("Youcancel or closed the dialog.");
            }
            string query = "backup database NGANHANGCAUHOI to disk='" + s + "'";
            try
            {
                DataProvider.instanse.ExecuteNonquerry(query);
                MessageBox.Show("Back up dữ liệu thành công");
            }
            catch
            {
                MessageBox.Show("Đã phát sinh lỗi ngoài dự kiến, vui lòng thử lại sau");
            }
        }

        private void backupDifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SVF = new SaveFileDialog();
            string s = null; ;
            SVF.DefaultExt = "bak";
            SVF.Filter = "Backup |*.bak|Text file (*.txt)|*.txt|XML file (*.xml)|*.xml|All files (*.*)|*.*";
            SVF.AddExtension = true;
            SVF.RestoreDirectory = true;
            SVF.Title = "Where do you want to save the file?";

            if (SVF.ShowDialog() == DialogResult.OK)
            {
                s = SVF.FileName;
            }
            else
            {
                MessageBox.Show("Youcancel or closed the dialog.");
            }
            string query = "BACKUP DATABASE NGANHANGCAUHOI TO DISK = '" +s+"' WITH INIT, DIFFERENTIAL";

            //try
            //{
                DataProvider.instanse.ExecuteNonquerry(query);
                MessageBox.Show("Back up dữ liệu thành công");
            //}
            //catch
            //{
            //    MessageBox.Show("Đã phát sinh lỗi ngoài dự kiến, vui lòng thử lại sau");
            //}
        }

        private void resetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = null; ;
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Backup|*.bak|All Files|*.*";
            //Tên của hộp thoại hiện lên - Không có thì sẽ là mặc định
            OPF.Title = "Chọn file ";
            OPF.ShowDialog();
            s = OPF.FileName;
            string querry = " USE MASTER restore database NGANHANGCAUHOI from disk = '" + s + "' WITH  REPLACE";
            //try
            //{
            DataProvider.instanse.ExecuteNonquerry(querry);
            MessageBox.Show("Back up dữ liệu thành công");
            //}
            //catch
            //{
            //    MessageBox.Show("Đã phát sinh lỗi ngoài dự kiến, vui lòng thử lại sau");
            //}

        }

      
    }
}
