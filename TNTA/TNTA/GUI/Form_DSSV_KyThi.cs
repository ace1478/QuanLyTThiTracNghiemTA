using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNTA.DTO;
using TNTA.DAO;
namespace TNTA.GUI
{
    public partial class Form_DSSV_KyThi : Form
    {
        public Form_DSSV_KyThi()
        {
            InitializeComponent();
        }
        private TTKT KyThi;
        private int i = 0;
      //  private List<SinhVienLop> SinhVienTT;
        private List<SinhVien> SinhVienThi;


        internal TTKT KyThi1
        {
            get
            {
                return KyThi;
            }

            set
            {
                KyThi = value;
            }
        }


        private void Form_SVKyThi_Load(object sender, EventArgs e)
        {
            lb_TenKT.Text = KyThi.TenKyThi;
            lb_ngaythi.Text = KyThi.NgayThi;
            lb_DDThi.Text = KyThi.DiaDiemTHi;
            LoadForm();
        }
        private void LoadForm()
        {

            if (i == 0)
            {
                KhoiTao();
                i++;
            }

            dtgv_DSSVThi.DataSource = SinhVienThi;
        }
        private void KhoiTao()
        {
            SinhVienThi = SinhVienDAO.LoadSVKyThi(KyThi.MaTTKT);

        }

        private void bt_ADD_Click(object sender, EventArgs e)
        {
            Form_AddSV f = new Form_AddSV();
            this.Hide();
            f.MaKyThi = KyThi.MaTTKT;
            f.KyThi1 = this.KyThi;
            f.Show();
          
            LoadForm()
   ;            
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sinh viên này ra khỏi dách sách không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string MaSV = dtgv_DSSVThi.CurrentRow.Cells["MaSV"].Value.ToString();
                    int MSVKT = SinhVien_KyThiDAO.GetMSVKTByMaSV_TTKT(MaSV, KyThi.MaTTKT);
                    string querry = "Delete ThanhVien where MaSVKT =" +MSVKT ;
                    DataProvider.instanse.ExecuteNonquerry(querry);
                    SinhVien_KyThiDAO.Delete_ByMaSV(dtgv_DSSVThi.CurrentRow.Cells["MaSV"].Value.ToString());

                    MessageBox.Show("Xóa Thành công");
                    SinhVienThi = SinhVienDAO.LoadSVKyThi(KyThi.MaTTKT);
                    LoadForm();
            }
                catch
            {
                MessageBox.Show(" Lỗi hệ thống");
            }

        }
        }
    }
}

