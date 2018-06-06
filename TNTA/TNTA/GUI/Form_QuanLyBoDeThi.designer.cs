namespace TNTA.GUI
{
    partial class Form_QuanLyBoDeThi
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
            this.grb_Header = new System.Windows.Forms.GroupBox();
            this.cb_MaDe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.txb_NdTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgv_CauHoiNP = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgv_DoanVan = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgv_CauHoiDoc = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.grb_Header.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CauHoiNP)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DoanVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CauHoiDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Header
            // 
            this.grb_Header.Controls.Add(this.cb_MaDe);
            this.grb_Header.Controls.Add(this.label1);
            this.grb_Header.Location = new System.Drawing.Point(12, 12);
            this.grb_Header.Name = "grb_Header";
            this.grb_Header.Size = new System.Drawing.Size(462, 47);
            this.grb_Header.TabIndex = 0;
            this.grb_Header.TabStop = false;
            // 
            // cb_MaDe
            // 
            this.cb_MaDe.FormattingEnabled = true;
            this.cb_MaDe.Location = new System.Drawing.Point(176, 13);
            this.cb_MaDe.Name = "cb_MaDe";
            this.cb_MaDe.Size = new System.Drawing.Size(174, 21);
            this.cb_MaDe.TabIndex = 2;
            this.cb_MaDe.SelectedIndexChanged += new System.EventHandler(this.cb_MaDe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đề thi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Timkiem);
            this.groupBox1.Controls.Add(this.txb_NdTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(480, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Location = new System.Drawing.Point(397, 11);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_Timkiem.TabIndex = 3;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // txb_NdTimKiem
            // 
            this.txb_NdTimKiem.Location = new System.Drawing.Point(179, 13);
            this.txb_NdTimKiem.Name = "txb_NdTimKiem";
            this.txb_NdTimKiem.Size = new System.Drawing.Size(163, 20);
            this.txb_NdTimKiem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã đề thi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtgv_CauHoiNP);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 446);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Câu hỏi ngữ pháp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // dtgv_CauHoiNP
            // 
            this.dtgv_CauHoiNP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CauHoiNP.Location = new System.Drawing.Point(6, 51);
            this.dtgv_CauHoiNP.Name = "dtgv_CauHoiNP";
            this.dtgv_CauHoiNP.Size = new System.Drawing.Size(450, 389);
            this.dtgv_CauHoiNP.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_DoanVan);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtgv_CauHoiDoc);
            this.groupBox3.Location = new System.Drawing.Point(480, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 447);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Câu hỏi đọc";
            // 
            // dtgv_DoanVan
            // 
            this.dtgv_DoanVan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_DoanVan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DoanVan.Location = new System.Drawing.Point(0, 52);
            this.dtgv_DoanVan.Name = "dtgv_DoanVan";
            this.dtgv_DoanVan.Size = new System.Drawing.Size(488, 123);
            this.dtgv_DoanVan.TabIndex = 5;
            this.dtgv_DoanVan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DoanVan_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Câu hỏi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đoạn Văn";
            // 
            // dtgv_CauHoiDoc
            // 
            this.dtgv_CauHoiDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CauHoiDoc.Location = new System.Drawing.Point(6, 209);
            this.dtgv_CauHoiDoc.Name = "dtgv_CauHoiDoc";
            this.dtgv_CauHoiDoc.Size = new System.Drawing.Size(488, 232);
            this.dtgv_CauHoiDoc.TabIndex = 0;
            this.dtgv_CauHoiDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CauHoiDoc_CellClick);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(329, 517);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(126, 45);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Blue;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(516, 517);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(126, 45);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "  Xóa";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form_QuanLyBoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(977, 574);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_Header);
            this.Name = "Form_QuanLyBoDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_QuanLyBoDeThi";
            this.Load += new System.EventHandler(this.Form_QuanLyBoDeThi_Load);
            this.grb_Header.ResumeLayout(false);
            this.grb_Header.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CauHoiNP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DoanVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CauHoiDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Header;
        private System.Windows.Forms.ComboBox cb_MaDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.TextBox txb_NdTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_CauHoiNP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgv_CauHoiDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dtgv_DoanVan;
    }
}