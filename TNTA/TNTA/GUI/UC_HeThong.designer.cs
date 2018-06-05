namespace TNTA.GUI
{
    partial class UC_HeThong
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_DSTV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::TNTA.Properties.Resources.if_010_95923;
            this.button2.Location = new System.Drawing.Point(634, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 243);
            this.button2.TabIndex = 2;
            this.button2.Text = "Quản lý quyền ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TNTA.Properties.Resources.if_edit_user_6020;
            this.button1.Location = new System.Drawing.Point(404, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 243);
            this.button1.TabIndex = 1;
            this.button1.Text = "Phân quyền cho từng loại TV";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_DSTV
            // 
            this.btn_DSTV.BackColor = System.Drawing.Color.Lime;
            this.btn_DSTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSTV.Image = global::TNTA.Properties.Resources.if_userconfig_7388;
            this.btn_DSTV.Location = new System.Drawing.Point(139, 142);
            this.btn_DSTV.Name = "btn_DSTV";
            this.btn_DSTV.Size = new System.Drawing.Size(172, 243);
            this.btn_DSTV.TabIndex = 0;
            this.btn_DSTV.Text = "Quản Lý Danh Sách Quản Trị\r\n";
            this.btn_DSTV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_DSTV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DSTV.UseVisualStyleBackColor = false;
            this.btn_DSTV.Click += new System.EventHandler(this.btn_DSTV_Click);
            // 
            // UC_HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DSTV);
            this.Name = "UC_HeThong";
            this.Size = new System.Drawing.Size(920, 540);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DSTV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
