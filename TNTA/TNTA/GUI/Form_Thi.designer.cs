namespace TNTA.GUI
{
    partial class Form_Thi
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
            this.components = new System.ComponentModel.Container();
            this.pl_Header = new System.Windows.Forms.Panel();
            this.lb_NamKT = new System.Windows.Forms.Label();
            this.pl_CauHoi = new System.Windows.Forms.Panel();
            this.Pl_CauTraLoi = new System.Windows.Forms.Panel();
            this.Pl_Timer = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.btn_NB = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_MSV = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TC = new System.Windows.Forms.Button();
            this.pl_Header.SuspendLayout();
            this.Pl_Timer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_Header
            // 
            this.pl_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_Header.Controls.Add(this.lb_NamKT);
            this.pl_Header.Location = new System.Drawing.Point(2, 3);
            this.pl_Header.Name = "pl_Header";
            this.pl_Header.Size = new System.Drawing.Size(799, 67);
            this.pl_Header.TabIndex = 0;
            this.pl_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_Header_Paint);
            // 
            // lb_NamKT
            // 
            this.lb_NamKT.AutoSize = true;
            this.lb_NamKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamKT.Location = new System.Drawing.Point(308, 19);
            this.lb_NamKT.Name = "lb_NamKT";
            this.lb_NamKT.Size = new System.Drawing.Size(197, 25);
            this.lb_NamKT.TabIndex = 17;
            this.lb_NamKT.Text = "Chúc bạn may mắn";
            // 
            // pl_CauHoi
            // 
            this.pl_CauHoi.AutoScroll = true;
            this.pl_CauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pl_CauHoi.Location = new System.Drawing.Point(2, 70);
            this.pl_CauHoi.Name = "pl_CauHoi";
            this.pl_CauHoi.Size = new System.Drawing.Size(799, 426);
            this.pl_CauHoi.TabIndex = 1;
            // 
            // Pl_CauTraLoi
            // 
            this.Pl_CauTraLoi.AutoScroll = true;
            this.Pl_CauTraLoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Pl_CauTraLoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pl_CauTraLoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pl_CauTraLoi.Location = new System.Drawing.Point(804, 138);
            this.Pl_CauTraLoi.Name = "Pl_CauTraLoi";
            this.Pl_CauTraLoi.Size = new System.Drawing.Size(252, 358);
            this.Pl_CauTraLoi.TabIndex = 1;
            // 
            // Pl_Timer
            // 
            this.Pl_Timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Pl_Timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pl_Timer.Controls.Add(this.label12);
            this.Pl_Timer.Controls.Add(this.lb_Time);
            this.Pl_Timer.Location = new System.Drawing.Point(804, 70);
            this.Pl_Timer.Name = "Pl_Timer";
            this.Pl_Timer.Size = new System.Drawing.Size(252, 65);
            this.Pl_Timer.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Thời Gian Còn Lại";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.ForeColor = System.Drawing.Color.Red;
            this.lb_Time.Location = new System.Drawing.Point(75, 27);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(96, 25);
            this.lb_Time.TabIndex = 10;
            this.lb_Time.Text = "00:00:00";
            // 
            // btn_NB
            // 
            this.btn_NB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_NB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NB.ForeColor = System.Drawing.Color.White;
            this.btn_NB.Location = new System.Drawing.Point(939, 499);
            this.btn_NB.Name = "btn_NB";
            this.btn_NB.Size = new System.Drawing.Size(117, 44);
            this.btn_NB.TabIndex = 0;
            this.btn_NB.Text = "Nộp bài";
            this.btn_NB.UseVisualStyleBackColor = false;
            this.btn_NB.Click += new System.EventHandler(this.btn_NB_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Purple;
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(5, 501);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(112, 42);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Blue;
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(133, 501);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(112, 42);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_MSV);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(804, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 67);
            this.panel1.TabIndex = 17;
            // 
            // lb_MSV
            // 
            this.lb_MSV.AutoSize = true;
            this.lb_MSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MSV.Location = new System.Drawing.Point(85, 33);
            this.lb_MSV.Name = "lb_MSV";
            this.lb_MSV.Size = new System.Drawing.Size(67, 20);
            this.lb_MSV.TabIndex = 19;
            this.lb_MSV.Text = "Thí sinh:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(85, 5);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(67, 20);
            this.lb_name.TabIndex = 18;
            this.lb_name.Text = "Thí sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "MSV    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thí sinh:";
            // 
            // btn_TC
            // 
            this.btn_TC.BackColor = System.Drawing.Color.Olive;
            this.btn_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TC.ForeColor = System.Drawing.Color.White;
            this.btn_TC.Location = new System.Drawing.Point(821, 499);
            this.btn_TC.Name = "btn_TC";
            this.btn_TC.Size = new System.Drawing.Size(117, 44);
            this.btn_TC.TabIndex = 18;
            this.btn_TC.Text = "Back";
            this.btn_TC.UseVisualStyleBackColor = false;
            this.btn_TC.Click += new System.EventHandler(this.btn_TC_Click);
            // 
            // Form_Thi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 543);
            this.Controls.Add(this.btn_TC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_NB);
            this.Controls.Add(this.Pl_Timer);
            this.Controls.Add(this.Pl_CauTraLoi);
            this.Controls.Add(this.pl_CauHoi);
            this.Controls.Add(this.pl_Header);
            this.Name = "Form_Thi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Thi";
            this.Load += new System.EventHandler(this.Form_Thi_Load);
            this.pl_Header.ResumeLayout(false);
            this.pl_Header.PerformLayout();
            this.Pl_Timer.ResumeLayout(false);
            this.Pl_Timer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_Header;
        private System.Windows.Forms.Panel pl_CauHoi;
        private System.Windows.Forms.Panel Pl_CauTraLoi;
        private System.Windows.Forms.Panel Pl_Timer;
        private System.Windows.Forms.Button btn_NB;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_NamKT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_MSV;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_TC;
    }
}