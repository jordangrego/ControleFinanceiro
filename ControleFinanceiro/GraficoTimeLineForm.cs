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
    public partial class GraficoTimeLineForm : Form
    {
        public GraficoTimeLineForm()
        {
            InitializeComponent();
        }

        private void GraficoTimeLineForm_Load(object sender, EventArgs e)
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

        private void CarregaComboSubTipoLancamento()
        {
            TipoLancamento tipoLancamentoCriterio;
            if (this.cbTipoLancamento.SelectedValue is TipoLancamento)
            {
                tipoLancamentoCriterio = ((TipoLancamento)cbTipoLancamento.SelectedValue);
            }
            else
            {
                tipoLancamentoCriterio = new TipoLancamento() { IdTipoLancamento = (int)cbTipoLancamento.SelectedValue };
            }

            this.cbSubTipoLancamento.DataSource = new SubTipoLancamentoBcl().FiltraPorTipoLancamento(tipoLancamentoCriterio);
            cbSubTipoLancamento.DisplayMember = "DescSubTipoLancamento";
            cbSubTipoLancamento.ValueMember = "IdSubTipoLancamento";
        }

        private void cbTipoLancamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CarregaComboSubTipoLancamento();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ParamDescSubTipo", ((SubTipoLancamento) cbSubTipoLancamento.SelectedItem).DescSubTipoLancamento);
            parameters[1] = new ReportParameter("ParamPeriodo", "Entre: " + this.dtpInicio.Value.ToShortDateString() + " e " + this.dtpFinal.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parameters);

            ReportDataSource reportDataSource = new ReportDataSource("TimeLine");
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportDataSource.Value = new TimeLineBcl().PesquisaTimeLineSubTipoLancamento(GeraCriterio());
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }


        private TimeLineSubTipoCriterio GeraCriterio()
        {
            TimeLineSubTipoCriterio timeLineSubTipoCriterio = new TimeLineSubTipoCriterio();
            timeLineSubTipoCriterio.DiaInicial = this.dtpInicio.Value;
            timeLineSubTipoCriterio.DiaFinal = this.dtpFinal.Value;
            timeLineSubTipoCriterio.SubTipoLancamento = new SubTipoLancamento() { IdSubTipoLancamento = Convert.ToInt32(cbSubTipoLancamento.SelectedValue) };
            return timeLineSubTipoCriterio;
        }
    }
}
