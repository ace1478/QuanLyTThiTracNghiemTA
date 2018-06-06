namespace TNTA.GUI
{
    partial class Form_LoaiThanhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_LoaiThanhVien = new System.Windows.Forms.DataGridView();
            this.panle_Quyen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_GhiChu = new System.Windows.Forms.RichTextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lb_ThongBao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LoaiThanhVien)).BeginInit();
            this.panle_Quyen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_LoaiThanhVien);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtgv_LoaiThanhVien
            // 
            this.dtgv_LoaiThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_LoaiThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_LoaiThanhVien.Location = new System.Drawing.Point(0, 9);
            this.dtgv_LoaiThanhVien.Name = "dtgv_LoaiThanhVien";
            this.dtgv_LoaiThanhVien.Size = new System.Drawing.Size(461, 500);
            this.dtgv_LoaiThanhVien.TabIndex = 2;
            this.dtgv_LoaiThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_LoaiThanhVien_CellClick);
            // 
            // panle_Quyen
            // 
            this.panle_Quyen.Controls.Add(this.label3);
            this.panle_Quyen.Location = new System.Drawing.Point(6, 280);
            this.panle_Quyen.Name = "panle_Quyen";
            this.panle_Quyen.Size = new System.Drawing.Size(499, 223);
            this.panle_Quyen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên";
            // 
            // txb_Name
            // 
            this.txb_Name.Enabled = false;
            this.txb_Name.Location = new System.Drawing.Point(164, 38);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(214, 20);
            this.txb_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ghi chú";
            // 
            // txb_GhiChu
            // 
            this.txb_GhiChu.Enabled = false;
            this.txb_GhiChu.Location = new System.Drawing.Point(164, 102);
            this.txb_GhiChu.Name = "txb_GhiChu";
            this.txb_GhiChu.Size = new System.Drawing.Size(214, 69);
            this.txb_GhiChu.TabIndex = 4;
            this.txb_GhiChu.Text = "";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(31, 222);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 39);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Location = new System.Drawing.Point(119, 223);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 39);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(212, 222);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 39);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Enabled = false;
            this.btn_Huy.Location = new System.Drawing.Point(303, 222);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 39);
            this.btn_Huy.TabIndex = 10;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(391, 224);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 39);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lb_ThongBao
            // 
            this.lb_ThongBao.AutoSize = true;
            this.lb_ThongBao.ForeColor = System.Drawing.Color.Red;
            this.lb_ThongBao.Location = new System.Drawing.Point(72, 77);
            this.lb_ThongBao.Name = "lb_ThongBao";
            this.lb_ThongBao.Size = new System.Drawing.Size(60, 13);
            this.lb_ThongBao.TabIndex = 12;
            this.lb_ThongBao.Text = "Tên Quyền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_ThongBao);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Huy);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.txb_GhiChu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txb_Name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panle_Quyen);
            this.groupBox2.Location = new System.Drawing.Point(482, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 509);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(175, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Danh sách các quyền tương ứng";
            // 
            // Form_LoaiThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(990, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_LoaiThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_LoaiThanhVien";
            this.Load += new System.EventHandler(this.Form_LoaiThanhVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LoaiThanhVien)).EndInit();
            this.panle_Quyen.ResumeLayout(false);
            this.panle_Quyen.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_LoaiThanhVien;
        private System.Windows.Forms.Panel panle_Quyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txb_GhiChu;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lb_ThongBao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}