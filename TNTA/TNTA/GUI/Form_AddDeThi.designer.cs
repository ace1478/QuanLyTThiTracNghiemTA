namespace TNTA.GUI
{
    partial class Form_AddDeThi
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
            this.Txb_made = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.tx_DoanVan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_NP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.Txb_made);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.btn_ADD);
            this.groupBox1.Controls.Add(this.tx_DoanVan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_NP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Txb_made
            // 
            this.Txb_made.Location = new System.Drawing.Point(160, 40);
            this.Txb_made.Name = "Txb_made";
            this.Txb_made.Size = new System.Drawing.Size(165, 20);
            this.Txb_made.TabIndex = 5;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(19, 43);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(52, 13);
            this.c.TabIndex = 4;
            this.c.Text = "Mã đề thi";
            // 
            // btn_ADD
            // 
            this.btn_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ADD.ForeColor = System.Drawing.Color.White;
            this.btn_ADD.Location = new System.Drawing.Point(135, 182);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(105, 33);
            this.btn_ADD.TabIndex = 1;
            this.btn_ADD.Text = "Tạo bộ đề thi mới";
            this.btn_ADD.UseVisualStyleBackColor = false;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // tx_DoanVan
            // 
            this.tx_DoanVan.Location = new System.Drawing.Point(160, 132);
            this.tx_DoanVan.Name = "tx_DoanVan";
            this.tx_DoanVan.Size = new System.Drawing.Size(165, 20);
            this.tx_DoanVan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số câu hỏi đoạn văn";
            // 
            // txb_NP
            // 
            this.txb_NP.Location = new System.Drawing.Point(160, 87);
            this.txb_NP.Name = "txb_NP";
            this.txb_NP.Size = new System.Drawing.Size(165, 20);
            this.txb_NP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số câu hỏi ngữ pháp";
            // 
            // Form_AddDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 245);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_AddDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddDeThi";
            this.Load += new System.EventHandler(this.Form_AddDeThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.TextBox tx_DoanVan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_NP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_made;
        private System.Windows.Forms.Label c;
    }
}