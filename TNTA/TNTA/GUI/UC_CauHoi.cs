using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TNTA.DAO;
using System.Windows.Forms;

namespace TNTA.GUI
{
    public partial class UC_CauHoi : UserControl
    {
        private int TrangThai_BTNguPhap = -1;
        public UC_CauHoi()
        {
            InitializeComponent();
        }

        private void UC_CauHoi_Load(object sender, EventArgs e)
        {

            LoadDSCauHoiNguPhap();
            LoadDSDoanVan();

        }
        private void dtgv_BTNguPhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txb_CauHoi.Text = dtgv_BTNguPhap.CurrentRow.Cells["CauHoi"].Value.ToString();
                txb_DapAn1.Text = dtgv_BTNguPhap.CurrentRow.Cells["DapAn1"].Value.ToString();
                txb_DapAn2.Text = dtgv_BTNguPhap.CurrentRow.Cells["DapAn2"].Value.ToString();
                txb_DapAn3.Text = dtgv_BTNguPhap.CurrentRow.Cells["DapAn3"].Value.ToString();
                txb_DapAn4.Text = dtgv_BTNguPhap.CurrentRow.Cells["DapAn4"].Value.ToString();
                txb_DapAnDung.Text = dtgv_BTNguPhap.CurrentRow.Cells["DapAnDung"].Value.ToString();

            }

            if (bt_Edit1.Enabled == false) bt_Edit1.Enabled = true;
            if (bt_delete1.Enabled == false) bt_delete1.Enabled = true;
        }


        private void LoadDSCauHoiNguPhap()
        {
            dtgv_BTNguPhap.DataSource = BTNguPhapDAO.LoadDSCauHoi();
            dtgv_BTNguPhap.Columns["Id_BTNguPhap"].HeaderText = "STT";
            dtgv_BTNguPhap.Columns["CauHoi"].HeaderText = "Câu Hỏi";
            dtgv_BTNguPhap.Columns["DapAn1"].HeaderText = "Đáp Án 1";
            dtgv_BTNguPhap.Columns["DapAn2"].HeaderText = "Đáp Án 2";
            dtgv_BTNguPhap.Columns["DapAn3"].HeaderText = "Đáp Án 3";
            dtgv_BTNguPhap.Columns["DapAn4"].HeaderText = "Đáp Án 4";
            dtgv_BTNguPhap.Columns["DapAnDung"].HeaderText = "Đáp Án Đúng";

            dtgv_BTNguPhap.Columns["Id_BTNguPhap"].Width = 75;
            dtgv_BTNguPhap.Columns["CauHoi"].Width = 400;
            dtgv_BTNguPhap.Columns["DapAn1"].Width = 100;
            dtgv_BTNguPhap.Columns["DapAn2"].Width = 100;
            dtgv_BTNguPhap.Columns["DapAn3"].Width = 100;
            dtgv_BTNguPhap.Columns["DapAn4"].Width = 100;
            dtgv_BTNguPhap.Columns["DapAnDung"].Width = 100;

            rdb_DapAn1.Checked = false;rdb_DapAn2.Checked = false; rdb_DapAn3.Checked = false; rdb_DapAn4.Checked = false;
            rdb_DapAn1.Enabled = false; rdb_DapAn2.Enabled = false; rdb_DapAn3.Enabled = false; rdb_DapAn4.Enabled = false;
            //ẩn các lb thôg báo
            lb_ThongBao1.Hide(); lb_ThongBao2.Hide(); lb_ThongBao3.Hide(); lb_ThongBao4.Hide(); lb_ThongBao.Hide();

        }
        private void LoadDSDoanVan()
        {
            dtgv_DoanVan.DataSource = BTDocDAO.LoadDSCauHoi();
            dtgv_DoanVan.Columns["Id_doc"].HeaderText = "STT";
            dtgv_DoanVan.Columns["DoanVan"].HeaderText = "Nội dung đoạn văn";
            dtgv_DoanVan.Columns["Id_doc"].Width = 50;
            dtgv_DoanVan.Columns["DoanVan"].Width = 400;
        }
        public void TrangThaiMacdinh_TaskBTNguPhap()
        {
            txb_CauHoi.Enabled = false; txb_CauHoi.Text = "";
            txb_DapAn1.Enabled = false; txb_DapAn1.Text = "";
            txb_DapAn2.Enabled = false; txb_DapAn2.Text = "";
            txb_DapAn3.Enabled = false; txb_DapAn3.Text = "";
            txb_DapAn4.Enabled = false; txb_DapAn4.Text = "";
            txb_DapAnDung.Enabled = false; txb_DapAnDung.Text = "";
            bt_Edit1.Enabled = false;
            bt_Save1.Enabled = false;
            bt_huy1.Enabled = false;
            bt_Add1.Enabled = true;
            bt_delete1.Enabled = false;
            bt_exit1.Enabled = true;

        }
        public void TrangThaiKhiCoSK_TaskBTNguPhap()
        {
            txb_CauHoi.Enabled = true;
            txb_DapAn1.Enabled = true;
            txb_DapAn2.Enabled = true;
            txb_DapAn3.Enabled = true;
            txb_DapAn4.Enabled = true;
            txb_DapAnDung.Enabled = false;
            bt_Edit1.Enabled = false;
            bt_Save1.Enabled = true;
            bt_huy1.Enabled = true;
            bt_Add1.Enabled = false;
            bt_delete1.Enabled = false;
            bt_exit1.Enabled = false;
            rdb_DapAn1.Enabled = true; rdb_DapAn2.Enabled = true; rdb_DapAn3.Enabled = true; rdb_DapAn4.Enabled = true;

        }


        private int checkdulieu_BTNguPhap()
        {
            int i = 0;
            if (txb_CauHoi.Text == "")
            {
                lb_ThongBao.Text = "Chưa nhập dữ liệu "; lb_ThongBao.Show();
                i = 1;
            }
             if (txb_DapAn1.Text == "")
            {
                lb_ThongBao1.Text = "Chưa nhập dữ liệu đáp án A "; lb_ThongBao1.Show();
                i = 1;
            }

             if (txb_DapAn2.Text == "")
            {
                lb_ThongBao2.Text = "Chưa nhập dữ liệu đáp án B "; lb_ThongBao2.Show();
                i = 1;
            }

             if (txb_DapAn3.Text == "")
            {
                lb_ThongBao3.Text = "Chưa nhập dữ liệu đáp án c "; lb_ThongBao3.Show();
                i = 1;
            }

             if (txb_DapAn4.Text == "")
            {
                lb_ThongBao4.Text = "Chưa nhập dữ liệu đáp án D "; lb_ThongBao4.Show();
                i = 1;
            }
         
         
            return i;
        }
        private void bt_Add1_Click_1(object sender, EventArgs e)
        {
            txb_CauHoi.Text = "";
            txb_DapAn1.Text = "";
            txb_DapAn2.Text = "";
            txb_DapAn3.Text = "";
            txb_DapAn4.Text = "";
            txb_DapAnDung.Text = "";
            TrangThaiKhiCoSK_TaskBTNguPhap();
            TrangThai_BTNguPhap = 1;

        }
        private void bt_huy1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thao tác thêm không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TrangThai_BTNguPhap = -1;
                TrangThaiMacdinh_TaskBTNguPhap();
                LoadDSCauHoiNguPhap();
            }

        }

        private void bt_Save1_Click(object sender, EventArgs e)
        {
            lb_ThongBao1.Hide(); lb_ThongBao2.Hide(); lb_ThongBao3.Hide(); lb_ThongBao4.Hide(); lb_ThongBao.Hide();

            if (TrangThai_BTNguPhap == 1)
            {
                if (checkdulieu_BTNguPhap()==0)
                    try
                    {
                        BTNguPhapDAO.AddCauHoi(txb_CauHoi.Text, txb_DapAn1.Text, txb_DapAn2.Text, txb_DapAn3.Text, txb_DapAn4.Text, txb_DapAnDung.Text);
                        MessageBox.Show("Bạn đã thêm dữ liệu thành công", "Thông báo");
                        TrangThai_BTNguPhap = -1;
                        TrangThaiMacdinh_TaskBTNguPhap();
                        LoadDSCauHoiNguPhap();


                    }
                    catch
                    {
                        MessageBox.Show("Xảy ra lỗi " + e.ToString());
                    }


            }
            else if (TrangThai_BTNguPhap == 0)
            {
                if (checkdulieu_BTNguPhap()==0)
                {
                    //try
                    {
                        int Id = 0;
                        Id = int.Parse(dtgv_BTNguPhap.CurrentRow.Cells["Id_BTNguPhap"].Value.ToString());
                        BTNguPhapDAO.EditCauHoi(Id, txb_CauHoi.Text, txb_DapAn1.Text, txb_DapAn2.Text, txb_DapAn3.Text, txb_DapAn4.Text, txb_DapAnDung.Text);
                        MessageBox.Show("Bạn đã sửa dữ liệu thành công", "Thông báo");
                        TrangThai_BTNguPhap = -1;
                        TrangThaiMacdinh_TaskBTNguPhap();

                        LoadDSCauHoiNguPhap();
                        

                    }
                    //      catch
                    // {
                    //     MessageBox.Show("Xảy ra lỗi " + e.ToString());
                    //}
                }
            }
        }
        private void rdb_DapAn1_CheckedChanged(object sender, EventArgs e)
        {
            if (TrangThai_BTNguPhap != -1)
                txb_DapAnDung.Text = txb_DapAn1.Text;
        }

        private void rdb_DapAn2_CheckedChanged(object sender, EventArgs e)
        {
            if (TrangThai_BTNguPhap != -1)
                txb_DapAnDung.Text = txb_DapAn2.Text;
        }

        private void rdb_DapAn3_CheckedChanged(object sender, EventArgs e)
        {
            if (TrangThai_BTNguPhap != -1)
                txb_DapAnDung.Text = txb_DapAn3.Text;

        }

        private void rdb_DapAn4_CheckedChanged(object sender, EventArgs e)
        {
            if (TrangThai_BTNguPhap != -1)
                txb_DapAnDung.Text = txb_DapAn4.Text;
        }
        private void bt_Edit1_Click(object sender, EventArgs e)
        {
            TrangThaiKhiCoSK_TaskBTNguPhap();
            TrangThai_BTNguPhap = 0;
        }



        private void bt_delete1_Click(object sender, EventArgs e)
        {
            if (int.Parse(dtgv_BTNguPhap.CurrentRow.Cells["Id_BTNguPhap"].Value.ToString()) > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa câu hỏi này không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BTNguPhapDAO.DeleteCauHoi(int.Parse(dtgv_BTNguPhap.CurrentRow.Cells["Id_BTNguPhap"].Value.ToString()));
                    LoadDSCauHoiNguPhap();
                    TrangThaiMacdinh_TaskBTNguPhap();
                }
                else
                    MessageBox.Show("Bạn chưa chọn câu hỏi cần xóa");
            }

        }



        // câu hỏi đọc
        private void dtgv_DoanVan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                TrangThaiFormMacDich_CauHoiDoc();
                int i = int.Parse(dtgv_DoanVan.CurrentRow.Cells["Id_Doc"].Value.ToString());
                LoadCauhoiDoc(i);
                txb_DoanVan.Text = dtgv_DoanVan.CurrentRow.Cells["DoanVan"].Value.ToString();

            }
        }

        private void dtgv_Cauhoidoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                txb_DapAnDung_BTDoc.Text = dtgv_Cauhoidoc.CurrentRow.Cells["DapAnDung"].Value.ToString();
                txb_DapAnA_BTDoc.Text = dtgv_Cauhoidoc.CurrentRow.Cells["DapAn1"].Value.ToString();
                txb_DapAnB_BTDoc.Text = dtgv_Cauhoidoc.CurrentRow.Cells["DapAn2"].Value.ToString();
                txb_DapAnC_BTDoc.Text = dtgv_Cauhoidoc.CurrentRow.Cells["DapAn3"].Value.ToString();
                txb_DapAnD_BTDoc.Text = dtgv_Cauhoidoc.CurrentRow.Cells["DapAn4"].Value.ToString();
                Cb_STT.Text = dtgv_Cauhoidoc.CurrentRow.Cells["STT"].Value.ToString();
                bt_Edit_BTDoc.Enabled = true;
                bt_Delete_BTDoc.Enabled = true;
            }
        }

        private void LoadCauhoiDoc(int i)
        {
            dtgv_Cauhoidoc.DataSource = CauHoiDocDAO.LoadDSCauHoiDoc(i);

            dtgv_Cauhoidoc.Columns["DapAn1"].HeaderText = "Đáp Án 1";
            dtgv_Cauhoidoc.Columns["DapAn2"].HeaderText = "Đáp Án 2";
            dtgv_Cauhoidoc.Columns["DapAn3"].HeaderText = "Đáp Án 3";
            dtgv_Cauhoidoc.Columns["DapAn4"].HeaderText = "Đáp Án 4";
            dtgv_Cauhoidoc.Columns["DapAnDung"].HeaderText = "Đáp Án Đúng";
            dtgv_Cauhoidoc.Columns["MaCauHoiDoc"].HeaderText = "Mã  Câu hỏi";

            dtgv_Cauhoidoc.Columns["STT"].Width = 75;
            dtgv_Cauhoidoc.Columns["DapAn1"].Width = 100;
            dtgv_Cauhoidoc.Columns["DapAn2"].Width = 100;
            dtgv_Cauhoidoc.Columns["DapAn3"].Width = 100;
            dtgv_Cauhoidoc.Columns["DapAn4"].Width = 100;
            dtgv_Cauhoidoc.Columns["DapAnDung"].Width = 100;

            Cb_STT.DataSource = CauHoiDocDAO.LoadDSCauHoiDoc(i);
            Cb_STT.DisplayMember = "STT";
            Cb_STT.ValueMember = "MaCauHoiDoc";
            rb_A.Checked = false; rb_B.Checked = false; rb_C.Checked = false; rb_D.Checked = false;
            rb_A.Enabled = false; rb_B.Enabled = false; rb_C.Enabled = false; rb_D.Enabled = false;


        }


        private void TrangThaiFormMacDich_CauHoiDoc()
        {
            txb_DoanVan.Enabled = false; txb_DoanVan.Text = "";
            txb_DapAnDung_BTDoc.Enabled = false; txb_DapAnDung_BTDoc.Text = "";
            txb_DapAnA_BTDoc.Enabled = false; txb_DapAnA_BTDoc.Text = "";
            txb_DapAnB_BTDoc.Enabled = false; txb_DapAnB_BTDoc.Text = "";
            txb_DapAnC_BTDoc.Enabled = false; txb_DapAnC_BTDoc.Text = "";
            txb_DapAnD_BTDoc.Enabled = false; txb_DapAnD_BTDoc.Text = "";

            bt_Add_BTDoc.Enabled = true;
            bt_Edit_BTDoc.Enabled = false;
            bt_Save_BTDoc.Enabled = false;
            bt_Huy_BTDoc.Enabled = false;
            bt_Delete_BTDoc.Enabled = false;
            bt_Exit_BTDoc.Enabled = true;

            rdb_DapAn1.Checked = false;
            rdb_DapAn2.Checked = false;
            rdb_DapAn3.Checked = false;
            rdb_DapAn4.Checked = false;
        }
        private void TrangThaiFormKhiCoSK_CauHoiDoc()
        {
            txb_DoanVan.Enabled = true; //txb_DoanVan.Text = "";
            txb_DapAnDung_BTDoc.Enabled = true; //txb_DapAnDung_BTDoc.Text = "";
            txb_DapAnA_BTDoc.Enabled = true; //txb_DapAnA_BTDoc.Text = "";
            txb_DapAnB_BTDoc.Enabled = true;// txb_DapAnB_BTDoc.Text = "";
            txb_DapAnC_BTDoc.Enabled = true;// txb_DapAnC_BTDoc.Text = "";
            txb_DapAnD_BTDoc.Enabled = true; //txb_DapAnD_BTDoc.Text = "";

            bt_Add_BTDoc.Enabled = false;
            bt_Edit_BTDoc.Enabled = false;
            bt_Save_BTDoc.Enabled = true;
            bt_Huy_BTDoc.Enabled = true;
            bt_Delete_BTDoc.Enabled = false;
            bt_Exit_BTDoc.Enabled = false;
        }



        private bool checkduLieu_BTDoc()
        {
            if (txb_DoanVan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập câu hỏi", "Thông báo");
                return false;
            }
            else if (txb_DapAnA_BTDoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp đáp án 1", "Thông báo"); return false;
            }

            else if (txb_DapAnB_BTDoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp đáp án 2", "Thông báo"); return false;
            }

            else if (txb_DapAnC_BTDoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp đáp án 3", "Thông báo"); return false;
            }

            else if (txb_DapAnD_BTDoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp đáp án 4", "Thông báo"); return false;
            }
            else if (txb_DapAnDung_BTDoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp đáp án 4", "Thông báo"); return false;
            }
            else if (txb_DapAnDung_BTDoc.Text != "")
            {
                if (txb_DapAnDung_BTDoc.Text != txb_DapAnA_BTDoc.Text && txb_DapAnDung_BTDoc.Text != txb_DapAnB_BTDoc.Text && txb_DapAnDung_BTDoc.Text != txb_DapAnC_BTDoc.Text && txb_DapAnDung_BTDoc.Text != txb_DapAnD_BTDoc.Text)
                {
                    MessageBox.Show("Đáp án đúng là một trong 4 đáp án 1,2,3,4! Vui lòng kiểm tra lại");
                    return false;
                }
            }
            return true;
        }

        private void bt_Edit_BTDoc_Click(object sender, EventArgs e)
        {
            TrangThaiFormKhiCoSK_CauHoiDoc();

        }

        private void bt_Save_BTDoc_Click(object sender, EventArgs e)
        {
            if (checkduLieu_BTDoc())
            {
                int i = int.Parse(dtgv_DoanVan.CurrentRow.Cells["Id_Doc"].Value.ToString());
                if (txb_DoanVan.Text != dtgv_DoanVan.CurrentRow.Cells["DoanVan"].Value.ToString())
                {
                    BTDocDAO.EditDoanVan(i, txb_DoanVan.Text);
                    MessageBox.Show("Sửa đoạn văn thành công");
                    LoadDSDoanVan();
                }
                int Id;
                rb_A.Enabled = true; rb_B.Enabled = true; rb_C.Enabled = true; rb_D.Enabled = true;

                Id = int.Parse(dtgv_Cauhoidoc.CurrentRow.Cells["MaCauHoiDoc"].Value.ToString());
                CauHoiDocDAO.Edit_CauHoiDoc(Id, txb_DapAnA_BTDoc.Text, txb_DapAnB_BTDoc.Text, txb_DapAnC_BTDoc.Text, txb_DapAnD_BTDoc.Text, txb_DapAnDung_BTDoc.Text);
                MessageBox.Show("Sửa thành công!");
                LoadCauhoiDoc(i);
                TrangThaiFormMacDich_CauHoiDoc();
            }

        }

        private void bt_Huy_BTDoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thao tác thêm không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TrangThaiFormMacDich_CauHoiDoc();
                dtgv_Cauhoidoc.DataSource = null;
            }

        }

        private void bt_Delete_BTDoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn  xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CauHoiDocDAO.Delete_CauHoiDoc(int.Parse(dtgv_DoanVan.CurrentRow.Cells["Id_Doc"].Value.ToString()));
                BTDocDAO.DeleteDoanVan(int.Parse(dtgv_DoanVan.CurrentRow.Cells["Id_Doc"].Value.ToString()));
                MessageBox.Show("Bạn đã xóa dữ liệu thành công");
                LoadDSDoanVan();
                TrangThaiFormMacDich_CauHoiDoc();
            }
        }

        private void bt_Add_BTDoc_Click(object sender, EventArgs e)
        {
            Form_NhapCauHoi f = new Form_NhapCauHoi();

            f.Show();
            LoadDSDoanVan();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rb_A_CheckedChanged(object sender, EventArgs e)
        {
            txb_DapAnDung_BTDoc.Text = txb_DapAnA_BTDoc.Text;
        }

        private void rb_B_CheckedChanged(object sender, EventArgs e)
        {
            txb_DapAnDung_BTDoc.Text = txb_DapAnB_BTDoc.Text;
        }

        private void rb_C_CheckedChanged(object sender, EventArgs e)
        {
            txb_DapAnDung_BTDoc.Text = txb_DapAnC_BTDoc.Text;
        }

        private void rb_D_CheckedChanged(object sender, EventArgs e)
        {
            txb_DapAnDung_BTDoc.Text = txb_DapAnD_BTDoc.Text;
        }
    }
}
