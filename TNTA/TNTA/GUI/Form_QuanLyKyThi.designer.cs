namespace TNTA.GUI
{
    partial class Form_QuanLyKyThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyKyThi));
            this.btn_XemDanhSach = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgv_ThongTinKyThi = new System.Windows.Forms.DataGridView();
            this.dtp_NgayThi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_ADD = new System.Windows.Forms.Button();
            this.txb_CoQuanToChuc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_DiaDiem = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_TenKyThi = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_ThoiGian = new System.Windows.Forms.TextBox();
            this.lb_ThongBao1 = new System.Windows.Forms.Label();
            this.lb_ThongBao2 = new System.Windows.Forms.Label();
            this.lb_ThongBao3 = new System.Windows.Forms.Label();
            this.lb_ThongBao4 = new System.Windows.Forms.Label();
            this.txb_MatKhau = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_ThongBao5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongTinKyThi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XemDanhSach
            // 
            this.btn_XemDanhSach.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_XemDanhSach, "btn_XemDanhSach");
            this.btn_XemDanhSach.Name = "btn_XemDanhSach";
            this.btn_XemDanhSach.UseVisualStyleBackColor = true;
            this.btn_XemDanhSach.Click += new System.EventHandler(this.btn_XemDanhSach_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Name = "label7";
            // 
            // dtgv_ThongTinKyThi
            // 
            this.dtgv_ThongTinKyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgv_ThongTinKyThi, "dtgv_ThongTinKyThi");
            this.dtgv_ThongTinKyThi.Name = "dtgv_ThongTinKyThi";
            this.dtgv_ThongTinKyThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ThongTinKyThi_CellClick);
            // 
            // dtp_NgayThi
            // 
            this.dtp_NgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtp_NgayThi, "dtp_NgayThi");
            this.dtp_NgayThi.Name = "dtp_NgayThi";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Name = "label6";
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.White;
            this.bt_Exit.Image = global::TNTA.Properties.Resources.if_Log_Out_27856;
            resources.ApplyResources(this.bt_Exit, "bt_Exit");
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bt_delete, "bt_delete");
            this.bt_delete.Image = global::TNTA.Properties.Resources.if_edit_trash_9263;
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bt_huy, "bt_huy");
            this.bt_huy.Image = global::TNTA.Properties.Resources.if_Cancel_728918;
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bt_Save, "bt_Save");
            this.bt_Save.Image = global::TNTA.Properties.Resources.if_Save_70652;
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bt_Edit, "bt_Edit");
            this.bt_Edit.Image = global::TNTA.Properties.Resources.if_edit_validated_85309;
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_ADD
            // 
            this.bt_ADD.BackColor = System.Drawing.Color.White;
            this.bt_ADD.Image = global::TNTA.Properties.Resources.if_add1__32378__1_;
            resources.ApplyResources(this.bt_ADD, "bt_ADD");
            this.bt_ADD.Name = "bt_ADD";
            this.bt_ADD.UseVisualStyleBackColor = false;
            this.bt_ADD.Click += new System.EventHandler(this.bt_ADD_Click);
            // 
            // txb_CoQuanToChuc
            // 
            resources.ApplyResources(this.txb_CoQuanToChuc, "txb_CoQuanToChuc");
            this.txb_CoQuanToChuc.Name = "txb_CoQuanToChuc";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Name = "label4";
            // 
            // txb_DiaDiem
            // 
            resources.ApplyResources(this.txb_DiaDiem, "txb_DiaDiem");
            this.txb_DiaDiem.Name = "txb_DiaDiem";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Name = "label2";
            // 
            // txb_TenKyThi
            // 
            resources.ApplyResources(this.txb_TenKyThi, "txb_TenKyThi");
            this.txb_TenKyThi.Name = "txb_TenKyThi";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Name = "label5";
            // 
            // txb_ThoiGian
            // 
            resources.ApplyResources(this.txb_ThoiGian, "txb_ThoiGian");
            this.txb_ThoiGian.Name = "txb_ThoiGian";
            // 
            // lb_ThongBao1
            // 
            resources.ApplyResources(this.lb_ThongBao1, "lb_ThongBao1");
            this.lb_ThongBao1.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao1.Name = "lb_ThongBao1";
            // 
            // lb_ThongBao2
            // 
            resources.ApplyResources(this.lb_ThongBao2, "lb_ThongBao2");
            this.lb_ThongBao2.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao2.Name = "lb_ThongBao2";
            // 
            // lb_ThongBao3
            // 
            resources.ApplyResources(this.lb_ThongBao3, "lb_ThongBao3");
            this.lb_ThongBao3.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao3.Name = "lb_ThongBao3";
            // 
            // lb_ThongBao4
            // 
            resources.ApplyResources(this.lb_ThongBao4, "lb_ThongBao4");
            this.lb_ThongBao4.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao4.Name = "lb_ThongBao4";
            // 
            // txb_MatKhau
            // 
            resources.ApplyResources(this.txb_MatKhau, "txb_MatKhau");
            this.txb_MatKhau.Name = "txb_MatKhau";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Name = "label8";
            // 
            // lb_ThongBao5
            // 
            resources.ApplyResources(this.lb_ThongBao5, "lb_ThongBao5");
            this.lb_ThongBao5.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao5.Name = "lb_ThongBao5";
            // 
            // Form_QuanLyKyThi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lb_ThongBao5);
            this.Controls.Add(this.txb_MatKhau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_ThongBao4);
            this.Controls.Add(this.lb_ThongBao3);
            this.Controls.Add(this.lb_ThongBao2);
            this.Controls.Add(this.lb_ThongBao1);
            this.Controls.Add(this.btn_XemDanhSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgv_ThongTinKyThi);
            this.Controls.Add(this.dtp_NgayThi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_ADD);
            this.Controls.Add(this.txb_CoQuanToChuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_DiaDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_TenKyThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_ThoiGian);
            this.Name = "Form_QuanLyKyThi";
            this.Load += new System.EventHandler(this.Form_QuanLyKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongTinKyThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_XemDanhSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgv_ThongTinKyThi;
        private System.Windows.Forms.DateTimePicker dtp_NgayThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_ADD;
        private System.Windows.Forms.RichTextBox txb_CoQuanToChuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txb_DiaDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txb_TenKyThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_ThoiGian;
        private System.Windows.Forms.Label lb_ThongBao1;
        private System.Windows.Forms.Label lb_ThongBao2;
        private System.Windows.Forms.Label lb_ThongBao3;
        private System.Windows.Forms.Label lb_ThongBao4;
        private System.Windows.Forms.RichTextBox txb_MatKhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_ThongBao5;
    }
}