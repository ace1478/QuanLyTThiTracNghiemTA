namespace TNTA.GUI
{
    partial class Form_QuanLyThi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_KyThi = new System.Windows.Forms.ComboBox();
            this.dtgv_ThongTinkyThi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_MaSV = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_MaDe = new System.Windows.Forms.ComboBox();
            this.lb_Diem = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongTinkyThi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_KyThi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 36);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_ThongTinkyThi);
            this.groupBox2.Location = new System.Drawing.Point(3, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 464);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn kỳ thi";
            // 
            // cb_KyThi
            // 
            this.cb_KyThi.FormattingEnabled = true;
            this.cb_KyThi.Location = new System.Drawing.Point(129, 10);
            this.cb_KyThi.Name = "cb_KyThi";
            this.cb_KyThi.Size = new System.Drawing.Size(171, 21);
            this.cb_KyThi.TabIndex = 1;
            this.cb_KyThi.SelectedIndexChanged += new System.EventHandler(this.cb_KyThi_SelectedIndexChanged);
            // 
            // dtgv_ThongTinkyThi
            // 
            this.dtgv_ThongTinkyThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ThongTinkyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ThongTinkyThi.Location = new System.Drawing.Point(3, 16);
            this.dtgv_ThongTinkyThi.Name = "dtgv_ThongTinkyThi";
            this.dtgv_ThongTinkyThi.Size = new System.Drawing.Size(687, 442);
            this.dtgv_ThongTinkyThi.TabIndex = 0;
            this.dtgv_ThongTinkyThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ThongTinkyThi_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_huy);
            this.groupBox3.Controls.Add(this.btn_Luu);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.lb_Diem);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cb_MaDe);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lb_SDT);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lb_MaSV);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lb_Name);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(718, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 464);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ Và Tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(111, 42);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(35, 13);
            this.lb_Name.TabIndex = 4;
            this.lb_Name.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Sinh Viên";
            // 
            // lb_MaSV
            // 
            this.lb_MaSV.AutoSize = true;
            this.lb_MaSV.Location = new System.Drawing.Point(111, 89);
            this.lb_MaSV.Name = "lb_MaSV";
            this.lb_MaSV.Size = new System.Drawing.Size(35, 13);
            this.lb_MaSV.TabIndex = 6;
            this.lb_MaSV.Text = "label5";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Location = new System.Drawing.Point(111, 138);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(35, 13);
            this.lb_SDT.TabIndex = 8;
            this.lb_SDT.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã đề";
            // 
            // cb_MaDe
            // 
            this.cb_MaDe.FormattingEnabled = true;
            this.cb_MaDe.Location = new System.Drawing.Point(81, 225);
            this.cb_MaDe.Name = "cb_MaDe";
            this.cb_MaDe.Size = new System.Drawing.Size(171, 21);
            this.cb_MaDe.TabIndex = 2;
            // 
            // lb_Diem
            // 
            this.lb_Diem.AutoSize = true;
            this.lb_Diem.Location = new System.Drawing.Point(111, 177);
            this.lb_Diem.Name = "lb_Diem";
            this.lb_Diem.Size = new System.Drawing.Size(35, 13);
            this.lb_Diem.TabIndex = 11;
            this.lb_Diem.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Điểm";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Green;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(7, 289);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(91, 47);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Thay Mã Đề";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(100, 289);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(86, 47);
            this.btn_Luu.TabIndex = 13;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(190, 289);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(86, 47);
            this.btn_huy.TabIndex = 14;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // Form_QuanLyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_QuanLyThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_QuanLyThi";
            this.Load += new System.EventHandler(this.Form_QuanLyThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongTinkyThi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_KyThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_ThongTinkyThi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_MaDe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_MaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Diem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_huy;
    }
}