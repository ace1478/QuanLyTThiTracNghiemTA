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
    public partial class Form_DSQuanTri : Form
    {
        public Form_DSQuanTri()
        {
            InitializeComponent();
        }

        private void Form_DSQuanTri_Load(object sender, EventArgs e)
        {
            LoadForm();
           
        }
        private void LoadForm()
        {
            string querry = "select id,username, HovaTen,Email, id_LoaiTV from Account ";
            DataTable tb = new DataTable();
            tb = DataProvider.instanse.Executequerry(querry);
            dtgv_DSQuanTri.DataSource = tb;
            dtgv_DSQuanTri.Columns["HoVaTen"].HeaderText = "Họ và Tên";
            dtgv_DSQuanTri.Columns["username"].HeaderText = "Tài Khoản";
            dtgv_DSQuanTri.Columns["Email"].HeaderText = "Email";
            dtgv_DSQuanTri.Columns["id_LoaiTV"].HeaderText = "Loai thành viên";

            string querry1 = "select *  from LoaiThanhVien";
            DataTable tb1 = new DataTable();
            tb1 = DataProvider.instanse.Executequerry(querry1);
            cb_LoaiTV.DataSource = tb1;
            cb_LoaiTV.DisplayMember = "Name";
            cb_LoaiTV.ValueMember = "Id_LoaiTV";
            btn_PhanQuyen.Enabled = true;
            btn_luu.Enabled = false;
            btn_Delete.Enabled = true;
            cb_LoaiTV.Enabled = false;
        }

        private void LoadDTGV_Quyen(int Id_LoaiThanhVien)
        {
            string querry = "select * from QuyenSD where id_QuyenSD in (select id_QuyenSD  from Quyen_LoaiTV where id_LoaiTV =" + Id_LoaiThanhVien + ")";
            DataTable tb = new DataTable();
            tb = DataProvider.instanse.Executequerry(querry);
            dtgv_QuyenTuongung.DataSource = tb;
            dtgv_QuyenTuongung.Columns["TenQuyen"].HeaderText = "Tên Quyền";
        }  
        private string GetNameLLoaiThanhVien(int Id_LoaiThanhVien)
        {
            string querry = "select  Name from LoaiThanhVien where id_LoaiTV ="+Id_LoaiThanhVien;
            DataTable tb = new DataTable();
            tb = DataProvider.instanse.Executequerry(querry);
            string Name_LoaiThanhVien = "";
            if (tb == null) return null;
            foreach(DataRow item in tb.Rows)
            {
                Name_LoaiThanhVien = item["Name"].ToString();
            }
            return Name_LoaiThanhVien;
        }

        private void dtgv_DSQuanTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            try
            {
                lb_UserName.Text = dtgv_DSQuanTri.CurrentRow.Cells["username"].Value.ToString();
                lb_HoVaTen.Text = dtgv_DSQuanTri.CurrentRow.Cells["HoVaTen"].Value.ToString();
                lb_Email.Text = dtgv_DSQuanTri.CurrentRow.Cells["Email"].Value.ToString();
                cb_LoaiTV.Text = GetNameLLoaiThanhVien(int.Parse(dtgv_DSQuanTri.CurrentRow.Cells["id_LoaiTV"].Value.ToString()));
                LoadDTGV_Quyen(int.Parse(dtgv_DSQuanTri.CurrentRow.Cells["id_LoaiTV"].Value.ToString()));

            }
            catch
            {

            }
           

        }

        private void btn_PhanQuyen_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            btn_Delete.Enabled = false;
            cb_LoaiTV.Enabled = true;
            btn_PhanQuyen.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string querry = "UpDate Account Set id_LoaiTV="+cb_LoaiTV.SelectedValue+" where id=" + int.Parse(dtgv_DSQuanTri.CurrentRow.Cells["id"].Value.ToString());
            DataProvider.instanse.ExecuteNonquerry(querry);
            MessageBox.Show("Sưa đổi quyền thành viên thành công !","Thông báo");
            LoadForm();
        }
    }
}
