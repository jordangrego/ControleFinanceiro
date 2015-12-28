using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiroCore.Business;

namespace ControleFinanceiro
{
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
            DadosControleFinanceiro.InicializarDados();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listaDeLancamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LancamentosForm form = new LancamentosForm();
            form.MdiParent = this;
            form.Show();
        }

        private void importarOFXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarArquivoForm form = new ImportarArquivoForm();
            form.MdiParent = this;
            form.Show();
        }

        private void listaDeLanaamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatoriosForm form = new RelatoriosForm();
            form.MdiParent = this;
            form.Show();
        }

        private void graficoPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficosForm form = new GraficosForm();
            form.MdiParent = this;
            form.Show();
        }

        private void graficoTimelineTipoLancamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficoTimeLineTipo form = new GraficoTimeLineTipo();
            form.MdiParent = this;
            form.Show();
        }

        private void graficoTimelineSubTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficoTimeLineSubTipoForm form = new GraficoTimeLineSubTipoForm();
            form.MdiParent = this;
            form.Show();
        }

        private void graficoPizzaSubTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficoPizzaSubTipoForm form = new GraficoPizzaSubTipoForm();
            form.MdiParent = this;
            form.Show();
        }

        private void graficoTimelineLancamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficoTimelineLancamentoForm form = new GraficoTimelineLancamentoForm();
            form.MdiParent = this;
            form.Show();
        }

        private void importarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarExcelForm form = new ImportarExcelForm();
            form.MdiParent = this;
            form.Show();
        }

        private void graficoTimelineReceitaDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficoTimeLineReceitaDespesaForm form = new GraficoTimeLineReceitaDespesaForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
