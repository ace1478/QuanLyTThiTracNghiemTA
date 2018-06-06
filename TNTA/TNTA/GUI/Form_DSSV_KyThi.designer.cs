namespace TNTA.GUI
{
    partial class Form_DSSV_KyThi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_ADD = new System.Windows.Forms.Button();
            this.dtgv_DSSVThi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_DDThi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_ngaythi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TenKT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSSVThi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.bt_delete);
            this.panel2.Controls.Add(this.bt_ADD);
            this.panel2.Controls.Add(this.dtgv_DSSVThi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(62, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 379);
            this.panel2.TabIndex = 19;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Navy;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.White;
            this.bt_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_delete.Location = new System.Drawing.Point(466, 298);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(91, 47);
            this.bt_delete.TabIndex = 26;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_ADD
            // 
            this.bt_ADD.BackColor = System.Drawing.Color.Green;
            this.bt_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ADD.ForeColor = System.Drawing.Color.White;
            this.bt_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ADD.Location = new System.Drawing.Point(339, 298);
            this.bt_ADD.Name = "bt_ADD";
            this.bt_ADD.Size = new System.Drawing.Size(95, 48);
            this.bt_ADD.TabIndex = 23;
            this.bt_ADD.Text = "Thêm Mới";
            this.bt_ADD.UseVisualStyleBackColor = false;
            this.bt_ADD.Click += new System.EventHandler(this.bt_ADD_Click);
            // 
            // dtgv_DSSVThi
            // 
            this.dtgv_DSSVThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_DSSVThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSSVThi.Location = new System.Drawing.Point(4, 26);
            this.dtgv_DSSVThi.Name = "dtgv_DSSVThi";
            this.dtgv_DSSVThi.Size = new System.Drawing.Size(904, 266);
            this.dtgv_DSSVThi.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Danh Sách Sinh Viên Tham Gia Thi";
            // 
            // lb_DDThi
            // 
            this.lb_DDThi.AutoSize = true;
            this.lb_DDThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DDThi.Location = new System.Drawing.Point(631, 60);
            this.lb_DDThi.Name = "lb_DDThi";
            this.lb_DDThi.Size = new System.Drawing.Size(84, 16);
            this.lb_DDThi.TabIndex = 18;
            this.lb_DDThi.Text = "Địa Điểm Thi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Địa Điểm Thi";
            // 
            // lb_ngaythi
            // 
            this.lb_ngaythi.AutoSize = true;
            this.lb_ngaythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaythi.Location = new System.Drawing.Point(292, 94);
            this.lb_ngaythi.Name = "lb_ngaythi";
            this.lb_ngaythi.Size = new System.Drawing.Size(63, 16);
            this.lb_ngaythi.TabIndex = 16;
            this.lb_ngaythi.Text = "Ngày Thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày Thi:";
            // 
            // lb_TenKT
            // 
            this.lb_TenKT.AutoSize = true;
            this.lb_TenKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKT.Location = new System.Drawing.Point(292, 60);
            this.lb_TenKT.Name = "lb_TenKT";
            this.lb_TenKT.Size = new System.Drawing.Size(72, 16);
            this.lb_TenKT.TabIndex = 14;
            this.lb_TenKT.Text = "Tên Kỳ Thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Kỳ Thi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Magenta;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(421, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thông Tin Kỳ Thi";
            // 
            // Form_DSSV_KyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1019, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_DDThi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_ngaythi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_TenKT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Form_DSSV_KyThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DSSV_KyThi";
            this.Load += new System.EventHandler(this.Form_SVKyThi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSSVThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_ADD;
        private System.Windows.Forms.DataGridView dtgv_DSSVThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_DDThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_ngaythi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_TenKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}