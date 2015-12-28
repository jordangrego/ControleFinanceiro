using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiroCore.Business;
using ControleFinanceiroCore.Entities;

namespace ControleFinanceiro
{
    public partial class DefinicaoImportacao : Form
    {
        public List<Lancamento> LancamentosSelecionados { get; set; }

        public DefinicaoImportacao()
        {
            InitializeComponent();
        }

        public DefinicaoImportacao(List<Lancamento> listaLancamentos)
        {
            InitializeComponent();
            this.LancamentosSelecionados = listaLancamentos;
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

        private void DefinicaoImportacao_Load(object sender, EventArgs e)
        {
            this.CarregaComboTipoLancamento();
            this.CarregaValorTotal();
        }

        private void CarregaValorTotal()
        {
            this.txtValorTotal.Text = this.LancamentosSelecionados.Select(l => l.ValorLancamento).Sum().ToString();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            LancamentoBcl lancamentoBcl = new LancamentoBcl();
            SubTipoLancamentoBcl subTipoLancamentoBcl = new SubTipoLancamentoBcl();
            int proxValor = lancamentoBcl.RecuperaProxIdLancamento();
            foreach (Lancamento lancamento in this.LancamentosSelecionados)
            {
                lancamento.IdLancamento = proxValor;
                lancamento.SubTipoLancamento = subTipoLancamentoBcl.Recuperar(Convert.ToInt32(this.cbSubTipoLancamento.SelectedValue));
                lancamento.Observacao = this.txtObservacao.Text;
                proxValor++;
            }

            lancamentoBcl.InserirListaLancamentos(this.LancamentosSelecionados);

            this.DialogResult = System.Windows.Forms.DialogResult.OK; 
        }

        private void cbSubTipoLancamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
