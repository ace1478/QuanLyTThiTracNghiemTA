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
    public partial class Form_QuanLyBoDeThi : Form
    {
      //  int ThuTu = -1;
        public Form_QuanLyBoDeThi()
        {
            InitializeComponent();
            cb_MaDe.DataSource = MaDeThiDAO.GetListMaDeThi();
            cb_MaDe.ValueMember = "Id_MaDe";
            cb_MaDe.DisplayMember = "MaDe";

        }
        private void Form_QuanLyBoDeThi_Load(object sender, EventArgs e)
        {
           
        
    }
        private void LoadDS(int IdMaDe)
        {
            if (BTNguPhapDAO.LoadDSCauHoi_TheoMaDe(IdMaDe)!=null)
            {
                dtgv_CauHoiNP.DataSource = BTNguPhapDAO.LoadDSCauHoi_TheoMaDe(IdMaDe);
                dtgv_DoanVan.DataSource = BTDocDAO.LoadDSCauHoi_TheoMaDe(IdMaDe);
            }
           else
            {
                MessageBox.Show("Mã đề hiện tại chưa có dữ liệu","Thông báo");
            }
        }
      
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form_AddDeThi f = new Form_AddDeThi();
            f.Show();
           
    }

    
        private void cb_MaDe_SelectedIndexChanged(object sender, EventArgs e)
        {
           // ThuTu = 1;
            try
            {
                LoadDS(int.Parse(cb_MaDe.SelectedValue.ToString()));
            }
           catch
            {

            }
        }

        private void dtgv_CauHoiDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtgv_DoanVan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgv_CauHoiDoc.DataSource = CauHoiDocDAO.LoadDSCauHoiDoc((int)dtgv_DoanVan.CurrentRow.Cells["Id_Doc"].Value);
        }
        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            //ThuTu = 2;// trang thai dể duyệt khi xóa
            int id = MaDeThiDAO.GetID_ByTen(txb_NdTimKiem.Text);
            LoadDS(id);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Form_XoaMaDE f = new Form_XoaMaDE();
            f.Show();
          
        }
    }
}
