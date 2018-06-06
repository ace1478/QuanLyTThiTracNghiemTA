using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TNTA.GUI
{
    public partial class Form_BaoCaoDSSV : Form
    {
        public Form_BaoCaoDSSV()
        {
            InitializeComponent();
        }

        private void Form_BaoCaoDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nGANHANGCAUHOIDataSet.ThongTinKyThi' table. You can move, or remove it, as needed.
            this.thongTinKyThiTableAdapter.Fill(this.nGANHANGCAUHOIDataSet.ThongTinKyThi);
            // TODO: This line of code loads data into the 'nGANHANGCAUHOIDataSet.VW_HienThiSVTheoKyThi' table. You can move, or remove it, as needed.
            this.vW_HienThiSVTheoKyThiTableAdapter.Fill(this.nGANHANGCAUHOIDataSet.VW_HienThiSVTheoKyThi);
            this.reportViewer1.RefreshReport();
            SetParameter(comboBox1.SelectedValue.ToString(), comboBox1.Text);
            reportViewer1.RefreshReport();
        }

        private void SetParameter(String MaKyThi, String TenKyThi)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("MaKyThi");
            rp[1] = new ReportParameter("TenKyThi");

            rp[0].Values.Add(MaKyThi);
            rp[1].Values.Add(TenKyThi);
            reportViewer1.LocalReport.SetParameters(rp);

        }

        private void btn_XemBC_SV_Click(object sender, EventArgs e)
        {
            SetParameter(comboBox1.SelectedValue.ToString(), comboBox1.Text);
            reportViewer1.RefreshReport();
        }
    }
}
