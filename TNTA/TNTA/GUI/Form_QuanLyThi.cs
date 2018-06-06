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
    public partial class Form_QuanLyThi : Form
    {
        private int i;
        public Form_QuanLyThi()
        {
            InitializeComponent();
        }

        private void Form_QuanLyThi_Load(object sender, EventArgs e)
        {
            cb_KyThi.DataSource = TTKTDAO.LoadDSThongTinKyThi();
            cb_KyThi.DisplayMember = "TenKyThi";
            cb_KyThi.ValueMember = "MaTTKT";
            cb_MaDe.DataSource = MaDeThiDAO.GetListMaDeThi();
            cb_MaDe.DisplayMember = "MaDe";
            cb_MaDe.ValueMember = "Id_Made";
            btn_Luu.Enabled = false;
            cb_MaDe.Enabled = false;btn_huy.Enabled = false;
        }
        private void Load_Form(int i)
        {
            string querry = "select SinhVien.MaSV,HoVaTen,SDT,MaDe,TongDiem from SinhVien,Sv_kyThi,MaDeThi where Sv_KyThi.Id_MaDe=MaDeThi.id_MaDe and SinhVien.MaSV=Sv_KyThi.MaSV and Sv_KyThi.MaTTKT=" + i;
            dtgv_ThongTinkyThi.DataSource=  DataProvider.instanse.Executequerry(querry);
            btn_Luu.Enabled = false;
            cb_MaDe.Enabled = false; btn_huy.Enabled = false;
            btn_Sua.Enabled = true;
        }

        private void cb_KyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TTKT item = (TTKT)cb_KyThi.SelectedItem;
                i = item.MaTTKT;
                Load_Form(item.MaTTKT);
            }
            catch
            { }
            
        }

        private void dtgv_ThongTinkyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_Diem.Text = dtgv_ThongTinkyThi.CurrentRow.Cells["TongDiem"].Value.ToString();
            lb_MaSV.Text = dtgv_ThongTinkyThi.CurrentRow.Cells["MaSV"].Value.ToString();
            lb_Name.Text = dtgv_ThongTinkyThi.CurrentRow.Cells["HoVaTen"].Value.ToString();
            lb_SDT.Text = dtgv_ThongTinkyThi.CurrentRow.Cells["SDT"].Value.ToString();
            
            cb_MaDe.Text = dtgv_ThongTinkyThi.CurrentRow.Cells["MaDe"].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;cb_MaDe.Enabled = true;btn_huy.Enabled = true;
            btn_Sua.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string MaSV= dtgv_ThongTinkyThi.CurrentRow.Cells["MaSV"].Value.ToString();
            string MaDe = cb_MaDe.SelectedValue.ToString();
            string querry = "update SV_KyThi set id_MaDe=" + MaDe + " where MaSV='"+MaSV+"'";
            DataProvider.instanse.ExecuteNonquerry(querry);
            MessageBox.Show("Thêm mới dữ liệu thành công");
            Load_Form(i);
            
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thao tác thêm không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Load_Form(i);
            }
        }
    }
}
