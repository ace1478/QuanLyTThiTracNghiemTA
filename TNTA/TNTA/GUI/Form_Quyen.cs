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
    public partial class Form_Quyen : Form
    {
        private int TrangThai = -1;
        public Form_Quyen()
        {
            InitializeComponent();
        }

        private void Form_Quyen_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            string querry = "Select * from QuyenSD";
            DataTable Tb = DataProvider.instanse.Executequerry(querry);
            dtgv_QuyenSD.DataSource = Tb;
            lb_ThongBao.Hide();
            txb_TenQuyen.Text = "";
            txb_TenQuyen.Enabled = false;
            btn_Add.Enabled = true;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = false;
            btn_Huy.Enabled = false;
        }

        private void dtgv_QuyenSD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_TenQuyen.Text = dtgv_QuyenSD.CurrentRow.Cells["TenQuyen"].Value.ToString();
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
       
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txb_TenQuyen.Text = "";
            txb_TenQuyen.Enabled = true;
           btn_Add.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_Huy.Enabled = true;
            TrangThai = 0;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (TrangThai == 0)// Trạng thái thêm mới
            {
                if (txb_TenQuyen.Text != "")
                {

                    string querry = " Insert into QuyenSD  values(N'" + txb_TenQuyen.Text + "')";
                    DataProvider.instanse.ExecuteNonquerry(querry);
                    MessageBox.Show("Thêm dữ liệu thành công");
                    LoadForm();
                }
                else
                {
                    lb_ThongBao.Text = "Bạn chưa nhập thông tin ";
                    lb_ThongBao.Show();
                }
            }
            else if (TrangThai == 1)//Trạng thái sửa
            {
                if (txb_TenQuyen.Text != "")
                {
                    string querry = "update QuyenSD set TenQuyen = N'" + txb_TenQuyen.Text + "' where Id_QuyenSD =" + dtgv_QuyenSD.CurrentRow.Cells["Id_QuyenSD"].Value.ToString();
                    DataProvider.instanse.ExecuteNonquerry(querry);
                    MessageBox.Show("Sửa dữ liệu thành công");
                    LoadForm();
                }
                else
                {
                    lb_ThongBao.Text = "Bạn chưa nhập thông tin ";
                    lb_ThongBao.Show();
                }

            }  
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn hủy thao tác thêm không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string querry = "Delete QuyenSD where Id_QuyenSD=" + dtgv_QuyenSD.CurrentRow.Cells["Id_QuyenSD"].Value.ToString();
                    DataProvider.instanse.ExecuteNonquerry(querry);
                    MessageBox.Show("Đã xóa dữ liệu thành công!");
                    LoadForm();
                }
              
            }
           catch
            {

            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            TrangThai = 1;
           
            txb_TenQuyen.Enabled = true;
            btn_Add.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_Huy.Enabled = true;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thao tác thêm không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoadForm();
            }
        }
    }
}
