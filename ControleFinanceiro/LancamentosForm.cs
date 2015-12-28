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
    public partial class LancamentosForm : Form
    {
        public LancamentosForm()
        {
            InitializeComponent();
        }

        private void LancamentosForm_Load(object sender, EventArgs e)
        {
            this.dgvLancamentos.AutoGenerateColumns = false;            
            this.dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.dtpFinal.Value = this.dtpInicio.Value.AddMonths(1).AddDays(-1);
            this.CarregaComboTipoLancamento();
            this.PesquisarLancamentos();
        }

        private void CarregaComboTipoLancamento()
        {
            List<TipoLancamento> listaTipoLancamento = new TipoLancamentoBcl().RecuperaTiposLancamento();
            listaTipoLancamento.Insert(0, new TipoLancamento() { IdTipoLancamento = 0, DescTipoLancamento = "Todos" });
            this.cbTipoLancamento.DataSource = listaTipoLancamento;
            this.cbTipoLancamento.DisplayMember = "DescTipoLancamento";
            this.cbTipoLancamento.ValueMember = "IdTipoLancamento";
            this.cbTipoLancamento.SelectedIndex = 0;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.PesquisarLancamentos();
        }

        private void PesquisarLancamentos()
        {
            List<Lancamento> listaCompleta = new LancamentoBcl().RecuperaListaCompleta();

            List<Lancamento> listaFiltrada = listaCompleta.Where(l => l.DataLancamento >= this.dtpInicio.Value && l.DataLancamento <= this.dtpFinal.Value).ToList<Lancamento>();

            if (this.cbSubTipoLancamento.Enabled && this.cbSubTipoLancamento.SelectedIndex > 0)
            {
                listaFiltrada = listaFiltrada.Where(l => l.SubTipoLancamento.IdSubTipoLancamento.Equals(((SubTipoLancamento)this.cbSubTipoLancamento.SelectedItem).IdSubTipoLancamento)).ToList<Lancamento>();
            }
            else if (this.cbTipoLancamento.SelectedIndex > 0)
            {
                listaFiltrada = listaFiltrada.Where(l => l.SubTipoLancamento.TipoLancamento.IdTipoLancamento.Equals(((TipoLancamento)this.cbTipoLancamento.SelectedItem).IdTipoLancamento)).ToList<Lancamento>();
            }

            if (!txtDescricaoObservacaoCriterio.Text.Equals(string.Empty))
            {
                listaFiltrada = listaFiltrada.Where(l => l.Observacao.ToUpper().Contains(this.txtDescricaoObservacaoCriterio.Text.ToUpper()) || l.DescricaoLancamento.ToUpper().Contains(this.txtDescricaoObservacaoCriterio.Text.ToUpper())).ToList<Lancamento>();
            }

            this.dgvLancamentos.DataSource = listaFiltrada.OrderBy(l => l.DataLancamento).ToList<Lancamento>();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvLancamentos.SelectedRows.Count.Equals(1))
            {
                int idLancamento = Convert.ToInt32(this.dgvLancamentos.SelectedRows[0].Cells[0].Value);
                Lancamento lancamento = new LancamentoBcl().Recuperar(idLancamento);

                EdicaoLancamento form = new EdicaoLancamento(lancamento);

                DialogResult resultado = form.ShowDialog();

                if (resultado == System.Windows.Forms.DialogResult.OK) 
                {
                    MessageBox.Show("Salvo com Sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Excluído com Sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecione 1 linha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.PesquisarLancamentos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            EdicaoLancamento form = new EdicaoLancamento(new Lancamento());

            DialogResult resultado = form.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Salvo com Sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado == System.Windows.Forms.DialogResult.None)
            {
                MessageBox.Show("Excluído com Sucesso", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.PesquisarLancamentos();
        }

        private void btnSomaLancamentos_Click(object sender, EventArgs e)
        {
            if (this.dgvLancamentos.SelectedRows.Count > 1)
            {
                double valorTotal = 0;
                foreach (DataGridViewRow linha in this.dgvLancamentos.SelectedRows)
                {
                    valorTotal = valorTotal + Convert.ToDouble(linha.Cells[5].Value);
                }
                MessageBox.Show("Valor Total: " + valorTotal, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione pelo menos 2 linhas", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTipoLancamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CarregaComboSubTipoLancamento();
        }

        private void CarregaComboSubTipoLancamento()
        {
            if (!((TipoLancamento)this.cbTipoLancamento.SelectedItem).IdTipoLancamento.Equals(0))
            {
                cbSubTipoLancamento.Enabled = true;
                TipoLancamento tipoLancamentoCriterio;
                if (this.cbTipoLancamento.SelectedValue is TipoLancamento)
                {
                    tipoLancamentoCriterio = ((TipoLancamento)cbTipoLancamento.SelectedValue);
                }
                else
                {
                    tipoLancamentoCriterio = new TipoLancamento() { IdTipoLancamento = (int)cbTipoLancamento.SelectedValue };
                }

                List<SubTipoLancamento> listaSubTipo = new SubTipoLancamentoBcl().FiltraPorTipoLancamento(tipoLancamentoCriterio);

                listaSubTipo.Insert(0, new SubTipoLancamento() { IdSubTipoLancamento = 0, DescSubTipoLancamento = "Todos" });

                this.cbSubTipoLancamento.DataSource = listaSubTipo;
                this.cbSubTipoLancamento.DisplayMember = "DescSubTipoLancamento";
                this.cbSubTipoLancamento.ValueMember = "IdSubTipoLancamento";
            }
            else
            {
                this.cbSubTipoLancamento.Enabled = false;
                this.cbSubTipoLancamento.DataSource = null;
            }
            
        }

        private void dgvLancamentos_ColumnHeaderMouse_lick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // MessageBox.Show("Coluna: " + e.ColumnIndex + " | " + this.dgvLancamentos.Columns[e.ColumnIndex].ValueType.ToString());
            // this.dgvLancamentos.Sort(this.dgvLancamentos.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (this.dgvLancamentos.SelectedRows.Count > 1)
            {
                double valorTotal = 0;
                foreach (DataGridViewRow linha in this.dgvLancamentos.SelectedRows)
                {
                    valorTotal = valorTotal + Convert.ToDouble(linha.Cells[5].Value);
                }

                double media = valorTotal / this.dgvLancamentos.SelectedRows.Count;

                MessageBox.Show("Média: " + media, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione pelo menos 2 linhas", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelecionaTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in this.dgvLancamentos.Rows)
            {
                linha.Selected = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.dtpFinal.Value = this.dtpInicio.Value.AddMonths(1).AddDays(-1);
            this.cbTipoLancamento.SelectedIndex = 0;
            this.CarregaComboTipoLancamento();
            this.PesquisarLancamentos();
        }
    }
}
