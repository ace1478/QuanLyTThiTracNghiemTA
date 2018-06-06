namespace TNTA.GUI
{
    partial class UC_SinhVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txb_ChuoiTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_ThongBao5 = new System.Windows.Forms.Label();
            this.lb_ThongBao4 = new System.Windows.Forms.Label();
            this.lb_ThongBao1 = new System.Windows.Forms.Label();
            this.lb_ThongBao6 = new System.Windows.Forms.Label();
            this.lb_ThongBao2 = new System.Windows.Forms.Label();
            this.lb_ThongBao3 = new System.Windows.Forms.Label();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.lop = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_ADD = new System.Windows.Forms.Button();
            this.tx_Email = new System.Windows.Forms.TextBox();
            this.tx_SĐT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_MSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvSinhVien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.txb_ChuoiTK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 69);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(261, 26);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txb_ChuoiTK
            // 
            this.txb_ChuoiTK.Location = new System.Drawing.Point(80, 27);
            this.txb_ChuoiTK.Name = "txb_ChuoiTK";
            this.txb_ChuoiTK.Size = new System.Drawing.Size(165, 20);
            this.txb_ChuoiTK.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tên ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbKhoa);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(431, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 69);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo khoa";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(72, 26);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(184, 21);
            this.cbKhoa.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(273, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Tìm kiếm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn Khoa";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(842, 10);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 60);
            this.button9.TabIndex = 3;
            this.button9.Text = "Làm Mới DS";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lb_ThongBao5);
            this.panel1.Controls.Add(this.lb_ThongBao4);
            this.panel1.Controls.Add(this.lb_ThongBao1);
            this.panel1.Controls.Add(this.lb_ThongBao6);
            this.panel1.Controls.Add(this.lb_ThongBao2);
            this.panel1.Controls.Add(this.lb_ThongBao3);
            this.panel1.Controls.Add(this.cb_lop);
            this.panel1.Controls.Add(this.lop);
            this.panel1.Controls.Add(this.dtp_NgaySinh);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.bt_Exit);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_huy);
            this.panel1.Controls.Add(this.bt_Save);
            this.panel1.Controls.Add(this.bt_Edit);
            this.panel1.Controls.Add(this.bt_ADD);
            this.panel1.Controls.Add(this.tx_Email);
            this.panel1.Controls.Add(this.tx_SĐT);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tx_MSV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tx_Name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 215);
            this.panel1.TabIndex = 56;
            // 
            // lb_ThongBao5
            // 
            this.lb_ThongBao5.AutoSize = true;
            this.lb_ThongBao5.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao5.Location = new System.Drawing.Point(378, 65);
            this.lb_ThongBao5.Name = "lb_ThongBao5";
            this.lb_ThongBao5.Size = new System.Drawing.Size(35, 13);
            this.lb_ThongBao5.TabIndex = 36;
            this.lb_ThongBao5.Text = "label5";
            // 
            // lb_ThongBao4
            // 
            this.lb_ThongBao4.AutoSize = true;
            this.lb_ThongBao4.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao4.Location = new System.Drawing.Point(35, 193);
            this.lb_ThongBao4.Name = "lb_ThongBao4";
            this.lb_ThongBao4.Size = new System.Drawing.Size(35, 13);
            this.lb_ThongBao4.TabIndex = 35;
            this.lb_ThongBao4.Text = "label5";
            // 
            // lb_ThongBao1
            // 
            this.lb_ThongBao1.AutoSize = true;
            this.lb_ThongBao1.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao1.Location = new System.Drawing.Point(35, 61);
            this.lb_ThongBao1.Name = "lb_ThongBao1";
            this.lb_ThongBao1.Size = new System.Drawing.Size(35, 13);
            this.lb_ThongBao1.TabIndex = 34;
            this.lb_ThongBao1.Text = "label5";
            // 
            // lb_ThongBao6
            // 
            this.lb_ThongBao6.AutoSize = true;
            this.lb_ThongBao6.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao6.Location = new System.Drawing.Point(378, 131);
            this.lb_ThongBao6.Name = "lb_ThongBao6";
            this.lb_ThongBao6.Size = new System.Drawing.Size(35, 13);
            this.lb_ThongBao6.TabIndex = 33;
            this.lb_ThongBao6.Text = "label5";
            // 
            // lb_ThongBao2
            // 
            this.lb_ThongBao2.AutoSize = true;
            this.lb_ThongBao2.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao2.Location = new System.Drawing.Point(35, 105);
            this.lb_ThongBao2.Name = "lb_ThongBao2";
            this.lb_ThongBao2.Size = new System.Drawing.Size(35, 13);
            this.lb_ThongBao2.TabIndex = 32;
            this.lb_ThongBao2.Text = "label5";
            // 
            // lb_ThongBao3
            // 
            this.lb_ThongBao3.AutoSize = true;
            this.lb_ThongBao3.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao3.Location = new System.Drawing.Point(35, 151);
            this.lb_ThongBao3.Name = "lb_ThongBao3";
            this.lb_ThongBao3.Size = new System.Drawing.Size(35, 13);
            this.lb_ThongBao3.TabIndex = 31;
            this.lb_ThongBao3.Text = "label5";
            this.lb_ThongBao3.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(130, 165);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(203, 21);
            this.cb_lop.TabIndex = 6;
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // lop
            // 
            this.lop.AutoSize = true;
            this.lop.Location = new System.Drawing.Point(35, 172);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(25, 13);
            this.lop.TabIndex = 5;
            this.lop.Text = "Lớp";
            this.lop.Click += new System.EventHandler(this.lop_Click);
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(454, 166);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_NgaySinh.TabIndex = 28;
            this.dtp_NgaySinh.Value = new System.DateTime(2018, 3, 16, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(371, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ngày  sinh";
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Exit.Image = global::TNTA.Properties.Resources.if_Log_Out_27856;
            this.bt_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Exit.Location = new System.Drawing.Point(798, 142);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(75, 47);
            this.bt_Exit.TabIndex = 26;
            this.bt_Exit.Text = "Thoát  ";
            this.bt_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Exit.UseVisualStyleBackColor = false;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_delete.Enabled = false;
            this.bt_delete.Image = global::TNTA.Properties.Resources.if_edit_trash_9263;
            this.bt_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_delete.Location = new System.Drawing.Point(697, 142);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(91, 47);
            this.bt_delete.TabIndex = 25;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_huy.Enabled = false;
            this.bt_huy.Image = global::TNTA.Properties.Resources.if_Cancel_728918;
            this.bt_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_huy.Location = new System.Drawing.Point(798, 79);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 45);
            this.bt_huy.TabIndex = 24;
            this.bt_huy.Text = "Hủy     ";
            this.bt_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Save.Enabled = false;
            this.bt_Save.Image = global::TNTA.Properties.Resources.if_Save_70652;
            this.bt_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Save.Location = new System.Drawing.Point(697, 79);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(91, 45);
            this.bt_Save.TabIndex = 23;
            this.bt_Save.Text = "Lưu       ";
            this.bt_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Edit.Enabled = false;
            this.bt_Edit.Image = global::TNTA.Properties.Resources.if_edit_validated_85309;
            this.bt_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Edit.Location = new System.Drawing.Point(798, 18);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(75, 48);
            this.bt_Edit.TabIndex = 22;
            this.bt_Edit.Text = "Sửa    ";
            this.bt_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_ADD
            // 
            this.bt_ADD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_ADD.Image = global::TNTA.Properties.Resources.if_add1__32378__1_;
            this.bt_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ADD.Location = new System.Drawing.Point(693, 17);
            this.bt_ADD.Name = "bt_ADD";
            this.bt_ADD.Size = new System.Drawing.Size(95, 48);
            this.bt_ADD.TabIndex = 21;
            this.bt_ADD.Text = "Thêm Mới";
            this.bt_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ADD.UseVisualStyleBackColor = false;
            this.bt_ADD.Click += new System.EventHandler(this.bt_ADD_Click);
            // 
            // tx_Email
            // 
            this.tx_Email.Enabled = false;
            this.tx_Email.Location = new System.Drawing.Point(454, 96);
            this.tx_Email.Name = "tx_Email";
            this.tx_Email.Size = new System.Drawing.Size(203, 20);
            this.tx_Email.TabIndex = 20;
            // 
            // tx_SĐT
            // 
            this.tx_SĐT.Enabled = false;
            this.tx_SĐT.Location = new System.Drawing.Point(128, 124);
            this.tx_SĐT.Name = "tx_SĐT";
            this.tx_SĐT.Size = new System.Drawing.Size(203, 20);
            this.tx_SĐT.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(371, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số điện thoại";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.rdb_Nu);
            this.panel2.Controls.Add(this.rdb_Nam);
            this.panel2.Location = new System.Drawing.Point(454, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 39);
            this.panel2.TabIndex = 16;
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Location = new System.Drawing.Point(67, 12);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(39, 17);
            this.rdb_Nu.TabIndex = 1;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Location = new System.Drawing.Point(3, 12);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(47, 17);
            this.rdb_Nam.TabIndex = 0;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Giới Tính";
            // 
            // tx_MSV
            // 
            this.tx_MSV.Enabled = false;
            this.tx_MSV.Location = new System.Drawing.Point(128, 78);
            this.tx_MSV.Name = "tx_MSV";
            this.tx_MSV.Size = new System.Drawing.Size(203, 20);
            this.tx_MSV.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã Sinh Viên";
            // 
            // tx_Name
            // 
            this.tx_Name.Enabled = false;
            this.tx_Name.Location = new System.Drawing.Point(128, 34);
            this.tx_Name.Name = "tx_Name";
            this.tx_Name.Size = new System.Drawing.Size(203, 20);
            this.tx_Name.TabIndex = 12;
            this.tx_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Name_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(28, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Họ Và Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(370, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thông Tin Chi Tiết";
            // 
            // dtgvSinhVien
            // 
            this.dtgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSinhVien.Location = new System.Drawing.Point(13, 78);
            this.dtgvSinhVien.Name = "dtgvSinhVien";
            this.dtgvSinhVien.Size = new System.Drawing.Size(900, 254);
            this.dtgvSinhVien.TabIndex = 37;
            this.dtgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSinhVien_CellClick);
            // 
            // UC_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dtgvSinhVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_SinhVien";
            this.Size = new System.Drawing.Size(940, 554);
            this.Load += new System.EventHandler(this.UC_SinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txb_ChuoiTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_ADD;
        private System.Windows.Forms.TextBox tx_Email;
        private System.Windows.Forms.TextBox tx_SĐT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_MSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Label lop;
        private System.Windows.Forms.Label lb_ThongBao3;
        private System.Windows.Forms.Label lb_ThongBao2;
        private System.Windows.Forms.Label lb_ThongBao6;
        private System.Windows.Forms.Label lb_ThongBao5;
        private System.Windows.Forms.Label lb_ThongBao4;
        private System.Windows.Forms.Label lb_ThongBao1;
        private System.Windows.Forms.DataGridView dtgvSinhVien;
    }
}
