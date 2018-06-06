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
    public partial class Form_LoaiThanhVien : Form
    {
        private List<CheckBox> listCB = new List<CheckBox>();
        private List<QuyenSD> listQuyen = new List<QuyenSD>();
        private List<QuyenSD> listQuyen_LoaiTV = new List<QuyenSD>();
        private List<CheckBox> listCb_Luu = new List<CheckBox>();
        private List<bool> list = new List<bool>();
        private int TrangThai; private int stt = 0;
        private int TrangThai1=0;// để biết xem chương trình có đang ở trong thêm mơi or sửa hay ko
        public Form_LoaiThanhVien()
        {
            InitializeComponent();
        }

        private void Form_LoaiThanhVien_Load(object sender, EventArgs e)
        {
            
            LoadForm();

            for (int i = 0; i < listCB.Count(); i++)
            {
                list.Add(true);
            }
        }
        private void LoadForm()
        {
            string querry = "Select * from LoaiThanhVien ";
            DataTable tb = DataProvider.instanse.Executequerry(querry);
            dtgv_LoaiThanhVien.DataSource = tb;
            lb_ThongBao.Hide();
            txb_Name.Text = "";
            txb_Name.Enabled = false;
            btn_Add.Enabled = true;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = false;
            btn_Huy.Enabled = false;
            listQuyen = QuyenSDDAO.GetListQuyenSD();
            if (stt == 0)
            {
                GetListQuyen();
            }
            else GetListQuyen1();


            panle_Quyen.Hide();
            panle_Quyen.Enabled = false;
            ResetListCb();// reset check box
            stt++;

        }
        private void GetListQuyen()//ad check box vào trong panle ở dưới
        {
            int i = 0;
            foreach(QuyenSD item in listQuyen)
            {
                if (i % 2 == 0)
                {
                    CheckBox ck = new CheckBox() { Name = item.id_QuyenSD.ToString(), Location = new Point(97, 31 * (2+i / 2)), AutoSize = true,Text=item.TenQuyen };

                    i++;
                    panle_Quyen.Controls.Add(ck);
                    listCB.Add(ck);
                }
                else
                {
                    CheckBox ck = new CheckBox() { Name = item.id_QuyenSD.ToString(), Location = new Point(292, 31 * (2+i / 2)), AutoSize = true,Text = item.TenQuyen };

                    i++;
                    panle_Quyen.Controls.Add(ck);
                    listCB.Add(ck);
                }
               
                
            }
        }
        private void GetListQuyen1()//ad check box vào trong panle ở dưới
        {
            int i = 0;
            foreach (QuyenSD item in listQuyen)
            {
                if (i % 2 == 0)
                {
                    CheckBox ck = new CheckBox() { Name = item.id_QuyenSD.ToString(), Location = new Point(97, 31 * (2 + i / 2)), AutoSize = true, Text = item.TenQuyen };

                    i++;
                    panle_Quyen.Controls.Add(ck);
                 
                }
                else
                {
                    CheckBox ck = new CheckBox() { Name = item.id_QuyenSD.ToString(), Location = new Point(292, 31 * (2 + i / 2)), AutoSize = true, Text = item.TenQuyen };

                    i++;
                    panle_Quyen.Controls.Add(ck);
                    
                }


            }
        }
        private void GetQuyenSH(int id) // những quyền nào tương ứng với loại tv nào thì hiển thị dấu tích
        {
            listQuyen_LoaiTV = QuyenSDDAO.GetListQuyen_LoaiTV(id);
            foreach (QuyenSD item in listQuyen_LoaiTV)
            {
                foreach (CheckBox item1 in listCB)

                    if (item1.Text == item.TenQuyen) item1.Checked = true;
                 
                
            }
        }
        private void ResetListCb()
        {
            foreach (CheckBox item in listCB)
            {
                item.Checked = false;
            }
        }
        private void dtgv_LoaiThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(TrangThai1==0)
            {
                try
                {
                    ResetListCb();
                    txb_Name.Text = dtgv_LoaiThanhVien.CurrentRow.Cells["Name"].Value.ToString();
                    txb_GhiChu.Text = dtgv_LoaiThanhVien.CurrentRow.Cells["GhiChu"].Value.ToString();
                    GetQuyenSH(int.Parse(dtgv_LoaiThanhVien.CurrentRow.Cells["Id_LoaiTV"].Value.ToString()));
                    panle_Quyen.Show();
                    btn_Edit.Enabled = true;
                    btn_Delete.Enabled = true;
                    listCb_Luu = listCB;// lưu lại trạng thái của list trước khi sửa

                }
                catch { }
               
            }
          
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txb_Name.Text = "";
            txb_Name.Enabled = true;
            txb_GhiChu.Enabled = true;
            btn_Add.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_Huy.Enabled = true;
            TrangThai = 0;
            ResetListCb();
            panle_Quyen.Show();
            panle_Quyen.Enabled = true;
            TrangThai1 = 1;//ct đang ở trong trạng thái sửa
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listCB.Count(); i++)
            {
                list[i] = listCB[i].Checked;
            }
            TrangThai1 = 1;// ct đang ở trong trạng thái sửa
            TrangThai = 1;
            txb_GhiChu.Enabled = true;
            txb_Name.Enabled = true;
            btn_Add.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_Huy.Enabled = true;
            panle_Quyen.Show();
            panle_Quyen.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (TrangThai == 0)// Trạng thái thêm mới
            {
                if (txb_Name.Text != "")
                {

                    string querry = " Insert into LoaiThanhVien  values(N'" + txb_Name.Text + "',N'"+ txb_GhiChu.Text+ "')";
                    DataProvider.instanse.ExecuteNonquerry(querry);
                    foreach(CheckBox item in listCB)
                    {
                        int id_LTV = LoaiThanhVienDAO.GetIdCuoi();
                        if (item.Checked == true) QuyenSDDAO.AddQuyen_LoaiTV(id_LTV, int.Parse(item.Name.ToString()));
                    }
                    MessageBox.Show("Thêm dữ liệu thành công");
                    TrangThai1 = 0;
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
               
                if (txb_Name.Text != "")
                {
                  
                    string querry = "update LoaiThanhVien set Name = N'" + txb_Name.Text + "',GhiChu=N'" + txb_GhiChu.Text + "' where ID_LoaiTV =" + dtgv_LoaiThanhVien.CurrentRow.Cells["ID_LoaiTV"].Value.ToString();
                    DataProvider.instanse.ExecuteNonquerry(querry);
                    for(int i=0;i<listCB.Count;i++)
                    {
                        if (listCB[i].Checked == list[i]) { }
                        else if (listCB[i].Checked == true & list[i] == false) QuyenSDDAO.AddQuyen_LoaiTV(int.Parse(dtgv_LoaiThanhVien.CurrentRow.Cells["Id_LoaiTV"].Value.ToString()), int.Parse(listCB[i].Name.ToString()));
                        else if (listCB[i].Checked == false & list[i] == true) QuyenSDDAO.DeleteQuyen_LoaiTV(int.Parse(dtgv_LoaiThanhVien.CurrentRow.Cells["Id_LoaiTV"].Value.ToString()), int.Parse(listCB[i].Name.ToString()));
                    }
                    MessageBox.Show("Sửa dữ liệu thành công");
                    TrangThai1 = 0;
                    LoadForm();
                }
                else
                {
                    lb_ThongBao.Text = "Bạn chưa nhập thông tin ";
                    lb_ThongBao.Show();
                }

            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thao tác thêm không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TrangThai1 = 0;
                LoadForm();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string querry = "Update Account Set Id_LoaiTV=NUll where Id_LoaiTV=" + int.Parse(dtgv_LoaiThanhVien.CurrentRow.Cells["Id_LoaiTV"].Value.ToString());
                string querry1 = "Update QUyen_LoaiTV Set Id_LoaiTV=NUll where Id_LoaiTV=" + int.Parse(dtgv_LoaiThanhVien.CurrentRow.Cells["Id_LoaiTV"].Value.ToString());
                string querry2 = "Delete LoaiThanhVien where Id_LoaiTV=" + int.Parse(dtgv_LoaiThanhVien.CurrentRow.Cells["Id_LoaiTV"].Value.ToString());
                DataProvider.instanse.ExecuteNonquerry(querry);
                DataProvider.instanse.ExecuteNonquerry(querry1);
                DataProvider.instanse.ExecuteNonquerry(querry2);
                LoadForm();
            }
           
        }
    }
}
