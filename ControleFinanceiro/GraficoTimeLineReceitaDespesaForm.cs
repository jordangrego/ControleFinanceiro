using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiroCore.Entities;
using ControleFinanceiroCore.Business;
using Microsoft.Reporting.WinForms;

namespace ControleFinanceiro
{
    public partial class GraficoTimeLineReceitaDespesaForm : Form
    {
        public GraficoTimeLineReceitaDespesaForm()
        {
            InitializeComponent();
        }

        private void GraficoTimeLineReceitaDespesaForm_Load(object sender, EventArgs e)
        {
            this.dtpInicio.Value = new DateTime(DateTime.Today.Year -1, DateTime.Today.Month, 1);
            this.dtpFinal.Value = (new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)).AddDays(-1);
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            TimeLineCriterio criterio = new TimeLineCriterio();
            criterio.DiaInicial = this.dtpInicio.Value;
            criterio.DiaFinal = this.dtpFinal.Value;

            List<TimeLine> lista = new TimeLineBcl().ListaTimeLineReceitaDespesa(criterio);

            this.rpvGrafico.LocalReport.DataSources.Clear();
            /*
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ParamDescSubTipo", ((SubTipoLancamento)cbSubTipoLancamento.SelectedItem).DescSubTipoLancamento);
            parameters[1] = new ReportParameter("ParamPeriodo", "Entre: " + this.dtpInicio.Value.ToShortDateString() + " e " + this.dtpFinal.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parameters);
            */
            ReportDataSource reportDataSource = new ReportDataSource("TimeLine");
            this.rpvGrafico.LocalReport.DataSources.Add(reportDataSource);
            reportDataSource.Value = lista;
            this.rpvGrafico.LocalReport.Refresh();
            this.rpvGrafico.RefreshReport();

        }
    }
}
