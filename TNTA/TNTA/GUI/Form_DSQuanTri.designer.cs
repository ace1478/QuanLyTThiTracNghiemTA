namespace TNTA.GUI
{
    partial class Form_DSQuanTri
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
            this.btn_luu = new System.Windows.Forms.Button();
            this.cb_LoaiTV = new System.Windows.Forms.ComboBox();
            this.btn_PhanQuyen = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_HoVaTen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_DSQuanTri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_QuyenTuongung = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSQuanTri)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_QuyenTuongung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.cb_LoaiTV);
            this.groupBox1.Controls.Add(this.btn_PhanQuyen);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_Email);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_HoVaTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_UserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(693, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_luu.Enabled = false;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(140, 248);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(91, 43);
            this.btn_luu.TabIndex = 11;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // cb_LoaiTV
            // 
            this.cb_LoaiTV.Enabled = false;
            this.cb_LoaiTV.FormattingEnabled = true;
            this.cb_LoaiTV.Location = new System.Drawing.Point(140, 192);
            this.cb_LoaiTV.Name = "cb_LoaiTV";
            this.cb_LoaiTV.Size = new System.Drawing.Size(173, 21);
            this.cb_LoaiTV.TabIndex = 10;
            // 
            // btn_PhanQuyen
            // 
            this.btn_PhanQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_PhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhanQuyen.ForeColor = System.Drawing.Color.White;
            this.btn_PhanQuyen.Location = new System.Drawing.Point(16, 248);
            this.btn_PhanQuyen.Name = "btn_PhanQuyen";
            this.btn_PhanQuyen.Size = new System.Drawing.Size(91, 43);
            this.btn_PhanQuyen.TabIndex = 9;
            this.btn_PhanQuyen.Text = "Phân Quyền";
            this.btn_PhanQuyen.UseVisualStyleBackColor = false;
            this.btn_PhanQuyen.Click += new System.EventHandler(this.btn_PhanQuyen_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(261, 248);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(102, 43);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Xóa ";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Loại Thành Viên";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(137, 163);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(0, 13);
            this.lb_Email.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            // 
            // lb_HoVaTen
            // 
            this.lb_HoVaTen.AutoSize = true;
            this.lb_HoVaTen.Location = new System.Drawing.Point(137, 120);
            this.lb_HoVaTen.Name = "lb_HoVaTen";
            this.lb_HoVaTen.Size = new System.Drawing.Size(0, 13);
            this.lb_HoVaTen.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Họ Và Tên";
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Location = new System.Drawing.Point(137, 79);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(0, 13);
            this.lb_UserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName";
            // 
            // dtgv_DSQuanTri
            // 
            this.dtgv_DSQuanTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_DSQuanTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSQuanTri.Location = new System.Drawing.Point(19, 67);
            this.dtgv_DSQuanTri.Name = "dtgv_DSQuanTri";
            this.dtgv_DSQuanTri.Size = new System.Drawing.Size(631, 434);
            this.dtgv_DSQuanTri.TabIndex = 1;
            this.dtgv_DSQuanTri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DSQuanTri_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách quản trị";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_QuyenTuongung);
            this.groupBox2.Location = new System.Drawing.Point(693, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 184);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các quyền hạn tương ứng";
            // 
            // dtgv_QuyenTuongung
            // 
            this.dtgv_QuyenTuongung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_QuyenTuongung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_QuyenTuongung.Enabled = false;
            this.dtgv_QuyenTuongung.Location = new System.Drawing.Point(6, 28);
            this.dtgv_QuyenTuongung.Name = "dtgv_QuyenTuongung";
            this.dtgv_QuyenTuongung.Size = new System.Drawing.Size(363, 150);
            this.dtgv_QuyenTuongung.TabIndex = 0;
            // 
            // Form_DSQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1092, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_DSQuanTri);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_DSQuanTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DSQuanTri";
            this.Load += new System.EventHandler(this.Form_DSQuanTri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSQuanTri)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_QuyenTuongung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_DSQuanTri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_HoVaTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_LoaiTV;
        private System.Windows.Forms.Button btn_PhanQuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_QuyenTuongung;
        private System.Windows.Forms.Button btn_luu;
    }
}