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
    public partial class Form_QuanLyKyThi : Form
    {
        public Form_QuanLyKyThi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_DSSV_KyThi f = new Form_DSSV_KyThi();
            this.Hide();
            f.Show();
        }
        private Account Acc;
        private int TrangThai;
        internal Account Acc1
        {
            get
            {
                return Acc;
            }

            set
            {
                Acc = value;
            }
        }

        private void dtgv_ThongTinKyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txb_TenKyThi.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["TenKyThi"].Value.ToString();
                txb_ThoiGian.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["ThoiGianThi"].Value.ToString();
                txb_DiaDiem.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["Diadiemthi"].Value.ToString();
                txb_CoQuanToChuc.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["CoQuanToChuc"].Value.ToString();
                dtp_NgayThi.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["NgayThi"].Value.ToString();
                txb_MatKhau.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["MatKhau"].Value.ToString();
                bt_Edit.Enabled = true;
                bt_delete.Enabled = true;

            }
        }

        private void LoadThongTinKyThi()
        {
            dtgv_ThongTinKyThi.DataSource = TTKTDAO.LoadDSThongTinKyThi();
            lb_ThongBao1.Hide(); lb_ThongBao2.Hide(); lb_ThongBao3.Hide(); lb_ThongBao4.Hide();lb_ThongBao5.Hide();
        }

        private void Form_QuanLyKyThi_Load(object sender, EventArgs e)
        {
            LoadThongTinKyThi();
            dtgv_ThongTinKyThi.Columns["TenKyThi"].HeaderText = "Tên Kỳ Thi";
            dtgv_ThongTinKyThi.Columns["ThoiGianThi"].HeaderText = "Thời lượng thi";
            dtgv_ThongTinKyThi.Columns["NgayThi"].HeaderText = "Ngày  thi";

            dtgv_ThongTinKyThi.Columns["CoQuanToChuc"].HeaderText = "Cơ quan tổ chức";
            dtgv_ThongTinKyThi.Columns["Diadiemthi"].HeaderText = "Địa điểm dự thi";

            dtgv_ThongTinKyThi.Columns["TenKyThi"].Width = 150;
            dtgv_ThongTinKyThi.Columns["ThoiGianThi"].Width = 100;
            dtgv_ThongTinKyThi.Columns["Diadiemthi"].Width = 200;
            dtgv_ThongTinKyThi.Columns["CoQuanToChuc"].Width = 200;

            dtgv_ThongTinKyThi.Columns["NgayThi"].Width = 150;

        }
        public void TrangThaiForm_Macdinh()
        {
            txb_TenKyThi.Enabled = false; txb_TenKyThi.Text = "";
            txb_ThoiGian.Enabled = false; txb_ThoiGian.Text = "";
            txb_DiaDiem.Enabled = false; txb_DiaDiem.Text = "";
            txb_CoQuanToChuc.Enabled = false; txb_CoQuanToChuc.Text = "";
            txb_MatKhau.Enabled = false; txb_MatKhau.Text = "";
            dtp_NgayThi.Enabled = false; txb_CoQuanToChuc.Text = "";
            bt_Edit.Enabled = false;
            bt_Save.Enabled = false;
            bt_huy.Enabled = false;
            bt_ADD.Enabled = true;
            bt_delete.Enabled = false;
            bt_Exit.Enabled = true;

        }
        public void TrangThaiForm_KhiCoSK()
        {
            txb_TenKyThi.Enabled = true;
            txb_ThoiGian.Enabled = true;
            txb_DiaDiem.Enabled = true;
            txb_MatKhau.Enabled = true;
            txb_CoQuanToChuc.Enabled = true;
            dtp_NgayThi.Enabled = true;
            bt_Edit.Enabled = false;
            bt_Save.Enabled = true;
            bt_huy.Enabled = true;
            bt_ADD.Enabled = false;
            bt_delete.Enabled = false;
            bt_Exit.Enabled = false;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chức năng này không không ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thao tác thêm không ?", "Thông báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TrangThaiForm_Macdinh();

            }
        }

        private void bt_ADD_Click(object sender, EventArgs e)
        {

            txb_TenKyThi.Text = "";
            txb_ThoiGian.Text = "";
            txb_DiaDiem.Text = "";
            txb_CoQuanToChuc.Text = "";
            txb_CoQuanToChuc.Text = "";
            TrangThaiForm_KhiCoSK();
            TrangThai = 0;
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            TrangThaiForm_KhiCoSK();

            TrangThai = 1;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = int.Parse(dtgv_ThongTinKyThi.CurrentRow.Cells["MaTTKT"].Value.ToString());
            if (id != 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa sinh viên này ra khỏi dách sách không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TTKTDAO.DeletedTTKT(id);
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                    TrangThaiForm_Macdinh();
                    LoadThongTinKyThi();
                }

            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            lb_ThongBao1.Hide(); lb_ThongBao2.Hide(); lb_ThongBao3.Hide(); lb_ThongBao4.Hide();
            if (TrangThai == 0)
            {
                if (checkDuLieu()==0)
                {
                    try
                    {
                        string ngayThi = dtp_NgayThi.Value.ToShortDateString();
                        TTKTDAO.AddTTKT(txb_TenKyThi.Text, txb_ThoiGian.Text, ngayThi, txb_CoQuanToChuc.Text, txb_DiaDiem.Text,txb_MatKhau.Text);
                        MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo");
                        TrangThaiForm_Macdinh();
                        LoadThongTinKyThi();

                    }
                    catch
                    {
                        MessageBox.Show("Xảy ra lỗi. vui lòng kiểm tra lại các định dạng dữ liệu nhâp vào");
                    }

                }
            }
            else if (TrangThai == 1)
            {
                if (checkDuLieu()==0)
                {
                    //try
                    //{
                        string ngayThi = dtp_NgayThi.Value.ToString("MM/dd/yyyy");
                        TTKTDAO.EditTTKT(txb_TenKyThi.Text, txb_ThoiGian.Text, ngayThi, txb_CoQuanToChuc.Text, txb_DiaDiem.Text, txb_MatKhau.Text, int.Parse(dtgv_ThongTinKyThi.CurrentRow.Cells["MaTTKT"].Value.ToString()));
                        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                        TrangThaiForm_Macdinh();
                        LoadThongTinKyThi();
                    //}
                    //catch
                    //{
                    //    MessageBox.Show("Xảy ra lỗi. vui lòng kiểm tra lại các định dạng dữ liệu nhâp vào ");
                    //}

                }
            }
        }
        public int checkDuLieu()
        {
            int i = 0;
            if (txb_TenKyThi.Text == "")
            {
                lb_ThongBao1.Text = "Chưa nhập tên kỳ thi";lb_ThongBao1.Show(); i = 1;

            }
             if (txb_ThoiGian.Text == "")
            {
                lb_ThongBao2.Text = "Chưa nhập tên kỳ thi"; lb_ThongBao2.Show(); i = 1;
            }

             if (txb_DiaDiem.Text == "")
            {
                lb_ThongBao3.Text = "Chưa nhập tên kỳ thi"; lb_ThongBao3.Show(); i = 1;
            }

             if (txb_CoQuanToChuc.Text == "")
            {
                lb_ThongBao4.Text = "Chưa nhập tên kỳ thi"; lb_ThongBao4.Show(); i = 1;
            }




            return i;
        }

        private void dtgv_ThongTinKyThi_DoubleClick(object sender, EventArgs e)
        {
            txb_TenKyThi.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["TenKyThi"].Value.ToString();
            txb_ThoiGian.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["ThoiGianThi"].Value.ToString();
            txb_DiaDiem.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["Diadiemthi"].Value.ToString();
            txb_CoQuanToChuc.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["CoQuanToChuc"].Value.ToString();
            dtp_NgayThi.Text = dtgv_ThongTinKyThi.CurrentRow.Cells["NgayThi"].Value.ToString();
        }

        private void btn_XemDanhSach_Click(object sender, EventArgs e)
        {
            if (txb_TenKyThi != null && txb_TenKyThi.Text != "")
            {
                Form_DSSV_KyThi f = new Form_DSSV_KyThi();
                TTKT KT = new TTKT();
                KT.MaTTKT = int.Parse(dtgv_ThongTinKyThi.CurrentRow.Cells["MaTTKT"].Value.ToString());
                KT.TenKyThi = dtgv_ThongTinKyThi.CurrentRow.Cells["TenKyThi"].Value.ToString();
                KT.NgayThi = dtgv_ThongTinKyThi.CurrentRow.Cells["NgayThi"].Value.ToString();
                KT.DiaDiemTHi = dtgv_ThongTinKyThi.CurrentRow.Cells["Diadiemthi"].Value.ToString();
                KT.CoQuanToChuc = dtgv_ThongTinKyThi.CurrentRow.Cells["CoQuanToChuc"].Value.ToString();
                f.KyThi1 = KT;
                f.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn kỳ thi!", "Thông báo");
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (txb_TenKyThi != null && txb_TenKyThi.Text != "")
        //    {
        //        Form_SVKyThi f = new Form_SVKyThi();
        //        TTKT KT = new TTKT();
        //        KT.MaTTKT = int.Parse(dtgv_ThongTinKyThi.CurrentRow.Cells["MaTTKT"].Value.ToString());
        //        KT.TenKyThi = dtgv_ThongTinKyThi.CurrentRow.Cells["TenKyThi"].Value.ToString();
        //        KT.NgayThi = dtgv_ThongTinKyThi.CurrentRow.Cells["NgayThi"].Value.ToString();
        //        KT.DiaDiemTHi = dtgv_ThongTinKyThi.CurrentRow.Cells["Diadiemthi"].Value.ToString();
        //        KT.CoQuanToChuc = dtgv_ThongTinKyThi.CurrentRow.Cells["CoQuanToChuc"].Value.ToString();
        //        f.KyThi1 = KT;
        //        f.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Bạn chưa chọn kỳ thi!", "Thông báo");
        //    }

        //}


    }
}
