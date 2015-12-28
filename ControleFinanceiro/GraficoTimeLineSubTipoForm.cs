using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiroCore.Business;
using Microsoft.Reporting.WinForms;
using ControleFinanceiroCore.Entities;

namespace ControleFinanceiro
{
    public partial class GraficoTimeLineSubTipoForm : Form
    {
        public GraficoTimeLineSubTipoForm()
        {
            InitializeComponent();
        }

        private void GraficoTimeLineSubTipoForm_Load(object sender, EventArgs e)
        {
            this.dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.dtpFinal.Value = this.dtpInicio.Value.AddMonths(1).AddDays(-1);
            this.CarregaComboTipoLancamento();
        }

        private void CarregaComboTipoLancamento()
        {
            this.cbTipoLancamento.DataSource = new TipoLancamentoBcl().RecuperaTiposLancamento();
            this.cbTipoLancamento.DisplayMember = "DescTipoLancamento";
            this.cbTipoLancamento.ValueMember = "IdTipoLancamento";
            this.cbTipoLancamento.SelectedIndex = 0;
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ParamTipoLancamento", ((TipoLancamento)cbTipoLancamento.SelectedItem).DescTipoLancamento);
            parameters[1] = new ReportParameter("ParamPeriodo", "Entre: " + this.dtpInicio.Value.ToShortDateString() + " e " + this.dtpFinal.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parameters);

            ReportDataSource reportDataSource = new ReportDataSource("TimeLine");
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportDataSource.Value = new TimeLineBcl().PesquisaTimeline(GeraCriterio());
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private TimeLineCriterio GeraCriterio()
        {
            TimeLineCriterio criterio = new TimeLineCriterio();
            criterio.DiaInicial = new DateTime(this.dtpInicio.Value.Year, this.dtpInicio.Value.Month, this.dtpInicio.Value.Day);
            criterio.DiaFinal = new DateTime(this.dtpFinal.Value.Year, this.dtpFinal.Value.Month, this.dtpFinal.Value.Day);
            criterio.TipoLancamento = (TipoLancamento)this.cbTipoLancamento.SelectedItem;
            return criterio;
        }
    }
}
