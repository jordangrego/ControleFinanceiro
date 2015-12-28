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
    public partial class RelatoriosForm : Form
    {
        public RelatoriosForm()
        {
            InitializeComponent();
        }

        private void RelatoriosForm_Load(object sender, EventArgs e)
        {
            this.dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.dtpFinal.Value = this.dtpInicio.Value.AddMonths(1).AddDays(-1);
            this.CarregaComboTipoLancamento();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();

            if (this.chkRelatorioAgrupado.Checked == true)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleFinanceiro.Relatorios.LancamentosTipo.rdlc";
            }
            else
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleFinanceiro.Relatorios.Lancamentos.rdlc";
            }

            List<Lancamento> listaLancamento = new LancamentoBcl().RecuperaListaCompleta().Where(l => (l.DataLancamento >= this.dtpInicio.Value && l.DataLancamento <= this.dtpFinal.Value)).ToList<Lancamento>();
            ReportParameter[] parameters = new ReportParameter[2];

            switch ((int)this.cbTipoLancamento.SelectedValue)
            {
                case -1:
                    listaLancamento = listaLancamento.Where(l => !l.SubTipoLancamento.TipoLancamento.IdTipoLancamento.Equals(1)).ToList<Lancamento>();
                    parameters[0] = new ReportParameter("ParamTipoLancamento", "Despesas");
                    break;
                case 0:
                    parameters[0] = new ReportParameter("ParamTipoLancamento", "Todos");
                    break;
                default:
                    listaLancamento = listaLancamento.Where(l => l.SubTipoLancamento.TipoLancamento.IdTipoLancamento.Equals((int)this.cbTipoLancamento.SelectedValue)).ToList<Lancamento>();
                    parameters[0] = new ReportParameter("ParamTipoLancamento", ((TipoLancamento)cbTipoLancamento.SelectedItem).DescTipoLancamento);
                    break;
            }

            this.reportViewer1.LocalReport.DataSources.Clear();

            parameters[1] = new ReportParameter("ParamPeriodo", "Entre: " + this.dtpInicio.Value.ToShortDateString() + " e " + this.dtpFinal.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parameters);

            ReportDataSource reportDataSource = new ReportDataSource("Lancamentos");
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportDataSource.Value = listaLancamento;
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void CarregaComboTipoLancamento()
        {
            List<TipoLancamento> lista = new TipoLancamentoBcl().RecuperaTiposLancamento();

            TipoLancamento tipoSelecione = new TipoLancamento()
            {
                IdTipoLancamento = 0,
                DescTipoLancamento = "Todos"
            };

            lista.Insert(0, tipoSelecione);

            TipoLancamento tipoDespesas = new TipoLancamento()
            {
                IdTipoLancamento = -1,
                DescTipoLancamento = "Todas Despesas"
            };

            lista.Insert(0, tipoDespesas);

            this.cbTipoLancamento.DataSource = lista;
            this.cbTipoLancamento.DisplayMember = "DescTipoLancamento";
            this.cbTipoLancamento.ValueMember = "IdTipoLancamento";
            this.cbTipoLancamento.SelectedIndex = 0;
        }
    }
}
