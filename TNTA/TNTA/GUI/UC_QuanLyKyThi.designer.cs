namespace TNTA.GUI
{
    partial class UC_QuanLyKyThi
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
            this.btn_DeThi = new System.Windows.Forms.Button();
            this.btn_SV_DeThi = new System.Windows.Forms.Button();
            this.btn_DSKT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DeThi
            // 
            this.btn_DeThi.BackColor = System.Drawing.Color.Crimson;
            this.btn_DeThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeThi.ForeColor = System.Drawing.Color.White;
            this.btn_DeThi.Image = global::TNTA.Properties.Resources.report_3_128;
            this.btn_DeThi.Location = new System.Drawing.Point(399, 130);
            this.btn_DeThi.Name = "btn_DeThi";
            this.btn_DeThi.Size = new System.Drawing.Size(169, 232);
            this.btn_DeThi.TabIndex = 5;
            this.btn_DeThi.Text = "Quản Lý Bộ Đề Thi";
            this.btn_DeThi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_DeThi.UseVisualStyleBackColor = false;
            this.btn_DeThi.Click += new System.EventHandler(this.btn_DeThi_Click);
            // 
            // btn_SV_DeThi
            // 
            this.btn_SV_DeThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_SV_DeThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SV_DeThi.ForeColor = System.Drawing.Color.White;
            this.btn_SV_DeThi.Image = global::TNTA.Properties.Resources.report_128;
            this.btn_SV_DeThi.Location = new System.Drawing.Point(614, 129);
            this.btn_SV_DeThi.Name = "btn_SV_DeThi";
            this.btn_SV_DeThi.Size = new System.Drawing.Size(167, 232);
            this.btn_SV_DeThi.TabIndex = 4;
            this.btn_SV_DeThi.Text = "Quản lý kỳ thi";
            this.btn_SV_DeThi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_SV_DeThi.UseVisualStyleBackColor = false;
            this.btn_SV_DeThi.Click += new System.EventHandler(this.btn_SV_DeThi_Click);
            // 
            // btn_DSKT
            // 
            this.btn_DSKT.BackColor = System.Drawing.Color.Lime;
            this.btn_DSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSKT.ForeColor = System.Drawing.Color.White;
            this.btn_DSKT.Image = global::TNTA.Properties.Resources.conference_call_128;
            this.btn_DSKT.Location = new System.Drawing.Point(166, 130);
            this.btn_DSKT.Name = "btn_DSKT";
            this.btn_DSKT.Size = new System.Drawing.Size(168, 232);
            this.btn_DSKT.TabIndex = 3;
            this.btn_DSKT.Text = "DS Sinh Viên Tham Gia Kỳ Thi";
            this.btn_DSKT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_DSKT.UseVisualStyleBackColor = false;
            this.btn_DSKT.Click += new System.EventHandler(this.btn_DSKT_Click);
            // 
            // UC_QuanLyKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btn_DeThi);
            this.Controls.Add(this.btn_SV_DeThi);
            this.Controls.Add(this.btn_DSKT);
            this.Name = "UC_QuanLyKyThi";
            this.Size = new System.Drawing.Size(926, 505);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DeThi;
        private System.Windows.Forms.Button btn_SV_DeThi;
        private System.Windows.Forms.Button btn_DSKT;
    }
}
