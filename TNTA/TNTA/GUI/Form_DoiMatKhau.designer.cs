namespace TNTA.GUI
{
    partial class Form_DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_thongbao2 = new System.Windows.Forms.Label();
            this.lb_thongbao1 = new System.Windows.Forms.Label();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_NLMk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Mkmoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_thongbao2);
            this.groupBox1.Controls.Add(this.lb_thongbao1);
            this.groupBox1.Controls.Add(this.lb_thongbao);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_NLMk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Mkmoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_mk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb_thongbao2
            // 
            this.lb_thongbao2.AutoSize = true;
            this.lb_thongbao2.ForeColor = System.Drawing.Color.Red;
            this.lb_thongbao2.Location = new System.Drawing.Point(44, 200);
            this.lb_thongbao2.Name = "lb_thongbao2";
            this.lb_thongbao2.Size = new System.Drawing.Size(67, 13);
            this.lb_thongbao2.TabIndex = 11;
            this.lb_thongbao2.Text = "Mật khẩu cũ";
            // 
            // lb_thongbao1
            // 
            this.lb_thongbao1.AutoSize = true;
            this.lb_thongbao1.ForeColor = System.Drawing.Color.Red;
            this.lb_thongbao1.Location = new System.Drawing.Point(44, 150);
            this.lb_thongbao1.Name = "lb_thongbao1";
            this.lb_thongbao1.Size = new System.Drawing.Size(67, 13);
            this.lb_thongbao1.TabIndex = 10;
            this.lb_thongbao1.Text = "Mật khẩu cũ";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.ForeColor = System.Drawing.Color.Red;
            this.lb_thongbao.Location = new System.Drawing.Point(44, 99);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(67, 13);
            this.lb_thongbao.TabIndex = 9;
            this.lb_thongbao.Text = "Mật khẩu cũ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(228, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(91, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thay đồi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_NLMk
            // 
            this.tb_NLMk.Location = new System.Drawing.Point(154, 170);
            this.tb_NLMk.Name = "tb_NLMk";
            this.tb_NLMk.Size = new System.Drawing.Size(214, 20);
            this.tb_NLMk.TabIndex = 6;
            this.tb_NLMk.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập lại Mk";
            // 
            // tb_Mkmoi
            // 
            this.tb_Mkmoi.Location = new System.Drawing.Point(154, 120);
            this.tb_Mkmoi.Name = "tb_Mkmoi";
            this.tb_Mkmoi.Size = new System.Drawing.Size(214, 20);
            this.tb_Mkmoi.TabIndex = 4;
            this.tb_Mkmoi.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới";
            // 
            // tb_mk
            // 
            this.tb_mk.Location = new System.Drawing.Point(158, 72);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(214, 20);
            this.tb_mk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // Form_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(561, 386);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DoiMatKhau";
            this.Load += new System.EventHandler(this.Form_DoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_NLMk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Mkmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_thongbao2;
        private System.Windows.Forms.Label lb_thongbao1;
        private System.Windows.Forms.Label lb_thongbao;
    }
}