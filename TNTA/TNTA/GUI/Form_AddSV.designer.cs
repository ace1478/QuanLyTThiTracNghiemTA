namespace TNTA.GUI
{
    partial class Form_AddSV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.pl_cha = new System.Windows.Forms.Panel();
            this.lb_Trang = new System.Windows.Forms.Label();
            this.bt_ADD = new System.Windows.Forms.Button();
            this.btn_TrangSau = new System.Windows.Forms.Button();
            this.btn_TrangTruoc = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txb_MaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_noAll = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(203, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Danh sách các sinh viên  chưa đăng ký";
            // 
            // pl_cha
            // 
            this.pl_cha.BackColor = System.Drawing.Color.Transparent;
            this.pl_cha.Location = new System.Drawing.Point(1, 32);
            this.pl_cha.Name = "pl_cha";
            this.pl_cha.Size = new System.Drawing.Size(656, 361);
            this.pl_cha.TabIndex = 28;
            // 
            // lb_Trang
            // 
            this.lb_Trang.AutoSize = true;
            this.lb_Trang.Location = new System.Drawing.Point(306, 468);
            this.lb_Trang.Name = "lb_Trang";
            this.lb_Trang.Size = new System.Drawing.Size(44, 13);
            this.lb_Trang.TabIndex = 0;
            this.lb_Trang.Text = "Trang 1";
            // 
            // bt_ADD
            // 
            this.bt_ADD.BackColor = System.Drawing.Color.White;
            this.bt_ADD.Image = global::TNTA.Properties.Resources.if_add1__32378__1_;
            this.bt_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ADD.Location = new System.Drawing.Point(438, 467);
            this.bt_ADD.Name = "bt_ADD";
            this.bt_ADD.Size = new System.Drawing.Size(95, 48);
            this.bt_ADD.TabIndex = 30;
            this.bt_ADD.Text = "Thêm Mới";
            this.bt_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ADD.UseVisualStyleBackColor = false;
            this.bt_ADD.Click += new System.EventHandler(this.bt_ADD_Click);
            // 
            // btn_TrangSau
            // 
            this.btn_TrangSau.BackColor = System.Drawing.Color.White;
            this.btn_TrangSau.Image = global::TNTA.Properties.Resources.if_go_next_118773;
            this.btn_TrangSau.Location = new System.Drawing.Point(158, 468);
            this.btn_TrangSau.Name = "btn_TrangSau";
            this.btn_TrangSau.Size = new System.Drawing.Size(91, 47);
            this.btn_TrangSau.TabIndex = 32;
            this.btn_TrangSau.Text = "Trang sau";
            this.btn_TrangSau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TrangSau.UseVisualStyleBackColor = false;
            this.btn_TrangSau.Click += new System.EventHandler(this.btn_TrangSau_Click);
            // 
            // btn_TrangTruoc
            // 
            this.btn_TrangTruoc.BackColor = System.Drawing.Color.White;
            this.btn_TrangTruoc.Image = global::TNTA.Properties.Resources.if_back_38976;
            this.btn_TrangTruoc.Location = new System.Drawing.Point(54, 468);
            this.btn_TrangTruoc.Name = "btn_TrangTruoc";
            this.btn_TrangTruoc.Size = new System.Drawing.Size(98, 47);
            this.btn_TrangTruoc.TabIndex = 0;
            this.btn_TrangTruoc.Text = "Trang trước";
            this.btn_TrangTruoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TrangTruoc.UseVisualStyleBackColor = false;
            this.btn_TrangTruoc.Click += new System.EventHandler(this.btn_TrangTruoc_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.White;
            this.bt_Exit.Image = global::TNTA.Properties.Resources.if_Log_Out_27856;
            this.bt_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Exit.Location = new System.Drawing.Point(539, 468);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(87, 47);
            this.bt_Exit.TabIndex = 31;
            this.bt_Exit.Text = "Thoát  ";
            this.bt_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_lammoi);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.txb_MaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(290, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 51);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(287, 20);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(63, 23);
            this.btn_lammoi.TabIndex = 2;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(213, 21);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(67, 23);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_MaSV
            // 
            this.txb_MaSV.Location = new System.Drawing.Point(48, 23);
            this.txb_MaSV.Name = "txb_MaSV";
            this.txb_MaSV.Size = new System.Drawing.Size(161, 20);
            this.txb_MaSV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_noAll);
            this.groupBox2.Controls.Add(this.rb_All);
            this.groupBox2.Location = new System.Drawing.Point(5, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 51);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiện ích";
            // 
            // rb_noAll
            // 
            this.rb_noAll.AutoSize = true;
            this.rb_noAll.Location = new System.Drawing.Point(137, 21);
            this.rb_noAll.Name = "rb_noAll";
            this.rb_noAll.Size = new System.Drawing.Size(101, 17);
            this.rb_noAll.TabIndex = 1;
            this.rb_noAll.TabStop = true;
            this.rb_noAll.Text = "Hủy chọn tất cả";
            this.rb_noAll.UseVisualStyleBackColor = true;
            this.rb_noAll.CheckedChanged += new System.EventHandler(this.rb_noAll_CheckedChanged);
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Location = new System.Drawing.Point(24, 23);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(80, 17);
            this.rb_All.TabIndex = 0;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "Chọn tất cả";
            this.rb_All.UseVisualStyleBackColor = true;
            this.rb_All.CheckedChanged += new System.EventHandler(this.rb_All_CheckedChanged);
            // 
            // Form_AddSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(659, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_ADD);
            this.Controls.Add(this.lb_Trang);
            this.Controls.Add(this.btn_TrangSau);
            this.Controls.Add(this.btn_TrangTruoc);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pl_cha);
            this.Name = "Form_AddSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AddSV_FormClosing);
            this.Load += new System.EventHandler(this.Form_AddSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_ADD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pl_cha;
        private System.Windows.Forms.Button btn_TrangTruoc;
        private System.Windows.Forms.Button btn_TrangSau;
        private System.Windows.Forms.Label lb_Trang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txb_MaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.RadioButton rb_noAll;
    }
}