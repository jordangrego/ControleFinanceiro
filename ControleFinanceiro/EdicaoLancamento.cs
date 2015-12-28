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

namespace ControleFinanceiro
{
    public partial class EdicaoLancamento : Form
    {
        public Lancamento Lancamento { get; set; }

        public EdicaoLancamento(Lancamento lancamento)
        {
            InitializeComponent();
            this.Lancamento = lancamento;
            this.CarregaComboTipoLancamento();
            this.CarregaTela();
        }

        private void CarregaTela()
        {
            if (!this.Lancamento.IdLancamento.Equals(0))
            {
                this.txtObservacao.Text = this.Lancamento.Observacao;
                this.txtDescricao.Text = this.Lancamento.DescricaoLancamento;
                this.txtValorLancamento.Text = this.Lancamento.ValorLancamento.ToString();
                this.dtpData.Value = this.Lancamento.DataLancamento;
                this.cbTipoLancamento.SelectedValue = this.Lancamento.SubTipoLancamento.TipoLancamento.IdTipoLancamento;
                this.CarregaComboSubTipoLancamento();
                this.cbSubTipoLancamento.SelectedValue = this.Lancamento.SubTipoLancamento.IdSubTipoLancamento;
            }
            else
            {
                this.btnExcluir.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                LancamentoBcl lancamentoBcl = new LancamentoBcl();
                this.Lancamento.ValorLancamento = Convert.ToDouble(this.txtValorLancamento.Text);
                this.Lancamento.SubTipoLancamento = (SubTipoLancamento)this.cbSubTipoLancamento.SelectedItem;
                this.Lancamento.Observacao = this.txtObservacao.Text;
                this.Lancamento.DescricaoLancamento = this.txtDescricao.Text;
                this.Lancamento.DataLancamento = new DateTime(this.dtpData.Value.Year, this.dtpData.Value.Month, this.dtpData.Value.Day);

                if (this.Lancamento.IdLancamento.Equals(0))
                {
                    lancamentoBcl.Inserir(this.Lancamento);
                }
                else
                {
                    lancamentoBcl.Atualizar(this.Lancamento);
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Os dados não estão formatados corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var confirmResult =  MessageBox.Show("Confirma exclusão do Lançamento?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == System.Windows.Forms.DialogResult.Yes)
            {
                new LancamentoBcl().Excluir(this.Lancamento.IdLancamento);
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel; 
        }

        private void CarregaComboTipoLancamento()
        {
            this.cbTipoLancamento.DataSource = new TipoLancamentoBcl().RecuperaTiposLancamento();
            this.cbTipoLancamento.DisplayMember = "DescTipoLancamento";
            this.cbTipoLancamento.ValueMember = "IdTipoLancamento";
            this.cbTipoLancamento.SelectedIndex = 0;
        }

        private void cbTipoLancamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CarregaComboSubTipoLancamento();
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
    }
}
