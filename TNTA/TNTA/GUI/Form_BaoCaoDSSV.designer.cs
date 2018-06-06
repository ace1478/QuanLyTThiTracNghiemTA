namespace TNTA.GUI
{
    partial class Form_BaoCaoDSSV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_XemBC_SV = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nGANHANGCAUHOIDataSet = new TNTA.NGANHANGCAUHOIDataSet();
            this.vWHienThiSVTheoKyThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_HienThiSVTheoKyThiTableAdapter = new TNTA.NGANHANGCAUHOIDataSetTableAdapters.VW_HienThiSVTheoKyThiTableAdapter();
            this.thongTinKyThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinKyThiTableAdapter = new TNTA.NGANHANGCAUHOIDataSetTableAdapters.ThongTinKyThiTableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGCAUHOIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWHienThiSVTheoKyThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinKyThiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_XemBC_SV);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(200, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kỳ thi bạn muốn in danh sách Sinh Vien";
            // 
            // btn_XemBC_SV
            // 
            this.btn_XemBC_SV.Location = new System.Drawing.Point(279, 29);
            this.btn_XemBC_SV.Name = "btn_XemBC_SV";
            this.btn_XemBC_SV.Size = new System.Drawing.Size(85, 23);
            this.btn_XemBC_SV.TabIndex = 1;
            this.btn_XemBC_SV.Text = "Xem báo cáo";
            this.btn_XemBC_SV.UseVisualStyleBackColor = true;
            this.btn_XemBC_SV.Click += new System.EventHandler(this.btn_XemBC_SV_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.thongTinKyThiBindingSource;
            this.comboBox1.DisplayMember = "TenKyThi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "MaTTKT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 365);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.vWHienThiSVTheoKyThiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TNTA.DSSVKyThi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(836, 365);
            this.reportViewer1.TabIndex = 0;
            // 
            // nGANHANGCAUHOIDataSet
            // 
            this.nGANHANGCAUHOIDataSet.DataSetName = "NGANHANGCAUHOIDataSet";
            this.nGANHANGCAUHOIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWHienThiSVTheoKyThiBindingSource
            // 
            this.vWHienThiSVTheoKyThiBindingSource.DataMember = "VW_HienThiSVTheoKyThi";
            this.vWHienThiSVTheoKyThiBindingSource.DataSource = this.nGANHANGCAUHOIDataSet;
            // 
            // vW_HienThiSVTheoKyThiTableAdapter
            // 
            this.vW_HienThiSVTheoKyThiTableAdapter.ClearBeforeFill = true;
            // 
            // thongTinKyThiBindingSource
            // 
            this.thongTinKyThiBindingSource.DataMember = "ThongTinKyThi";
            this.thongTinKyThiBindingSource.DataSource = this.nGANHANGCAUHOIDataSet;
            // 
            // thongTinKyThiTableAdapter
            // 
            this.thongTinKyThiTableAdapter.ClearBeforeFill = true;
            // 
            // Form_BaoCaoDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_BaoCaoDSSV";
            this.Text = "Form_BaoCaoDSSV";
            this.Load += new System.EventHandler(this.Form_BaoCaoDSSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGCAUHOIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWHienThiSVTheoKyThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinKyThiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_XemBC_SV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private NGANHANGCAUHOIDataSet nGANHANGCAUHOIDataSet;
        private System.Windows.Forms.BindingSource vWHienThiSVTheoKyThiBindingSource;
        private NGANHANGCAUHOIDataSetTableAdapters.VW_HienThiSVTheoKyThiTableAdapter vW_HienThiSVTheoKyThiTableAdapter;
        private System.Windows.Forms.BindingSource thongTinKyThiBindingSource;
        private NGANHANGCAUHOIDataSetTableAdapters.ThongTinKyThiTableAdapter thongTinKyThiTableAdapter;
    }
}