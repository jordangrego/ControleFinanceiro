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
    public partial class GraficoPizzaSubTipoForm : Form
    {
        public GraficoPizzaSubTipoForm()
        {
            InitializeComponent();
        }

        private void GraficoPizzaSubTipoForm_Load(object sender, EventArgs e)
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

            ReportDataSource reportDataSource = new ReportDataSource("Lancamentos");
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            List<Lancamento> listaLancamento = new LancamentoBcl().RecuperaListaCompleta();
            listaLancamento = listaLancamento
                .Where(l => l.DataLancamento >= this.dtpInicio.Value && l.DataLancamento <= this.dtpFinal.Value && l.SubTipoLancamento.TipoLancamento.IdTipoLancamento.Equals(((TipoLancamento)this.cbTipoLancamento.SelectedItem).IdTipoLancamento))
                .ToList<Lancamento>();

            reportDataSource.Value = listaLancamento;
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
