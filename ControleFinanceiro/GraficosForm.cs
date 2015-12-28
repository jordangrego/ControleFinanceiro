using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ControleFinanceiroCore.Business;
using ControleFinanceiroCore.Entities;

namespace ControleFinanceiro
{
    public partial class GraficosForm : Form
    {
        public GraficosForm()
        {
            InitializeComponent();
        }

        private void GraficosForm_Load(object sender, EventArgs e)
        {
            this.dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.dtpFinal.Value = this.dtpInicio.Value.AddMonths(1).AddDays(-1);
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("ParamPeriodo", "Entre: " + this.dtpInicio.Value.ToShortDateString() + " e " + this.dtpFinal.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parameters);

            ReportDataSource reportDataSource = new ReportDataSource("Lancamentos");
            ReportDataSource reportDataSourceReceitas = new ReportDataSource("Receitas");
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSourceReceitas);
            reportDataSource.Value = new LancamentoBcl().RecuperaListaCompleta().Where(l => l.DataLancamento >= this.dtpInicio.Value && l.DataLancamento <= this.dtpFinal.Value && !l.DescTipo.Equals("Receitas")).ToList<Lancamento>();
            reportDataSourceReceitas.Value = new LancamentoBcl().RecuperaListaCompleta().Where(l => l.DataLancamento >= this.dtpInicio.Value && l.DataLancamento <= this.dtpFinal.Value && l.DescTipo.Equals("Receitas")).ToList<Lancamento>();
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
