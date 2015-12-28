using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiroCore.Ofx;
using ControleFinanceiroCore.Entities;

namespace ControleFinanceiro
{
    public partial class ImportarArquivoForm : Form
    {
        public ImportarArquivoForm()
        {
            InitializeComponent();
        }

        public void AbreDialogArquivo()
        {
            OpenFileDialog dialogArquivo = new OpenFileDialog();
            dialogArquivo.Multiselect = false;
            dialogArquivo.Filter = "Money (.ofx)|*.ofx";
            if (dialogArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dialogArquivo.FileName))
                {
                    ConversorOfx conversor = new ConversorOfx();
                    DataSet ds = conversor.ToDataSet(dialogArquivo.FileName);
                    this.dgvImportacao.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Selecione um Arquivo.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbreDialogArquivo();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (this.dgvImportacao.SelectedRows.Count > 0)
            {
                List<Lancamento> listaLancamento = new List<Lancamento>();
                foreach (DataGridViewRow linha in this.dgvImportacao.SelectedRows)
                {
                    Lancamento lancamento = new Lancamento();
                    lancamento.ValorLancamento = Math.Abs(Convert.ToDouble(linha.Cells[2].Value.ToString().Replace("." ,",")));
                    lancamento.DataLancamento = this.RecuperaData(linha.Cells[1].Value.ToString());
                    lancamento.DescricaoLancamento = linha.Cells[5].Value.ToString();
                    listaLancamento.Add(lancamento);
                }

                DefinicaoImportacao form = new DefinicaoImportacao(listaLancamento);
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DataGridViewRow linha in this.dgvImportacao.SelectedRows)
                    {
                        this.dgvImportacao.Rows.Remove(linha);
                    }

                    MessageBox.Show("Importação Realizada com sucesso!", "Importação Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos uma linha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DateTime RecuperaData(string campoData)
        {
            int ano = Convert.ToInt32(campoData.Substring(0, 4));
            int mes = Convert.ToInt32(campoData.Substring(4, 2));
            int dia = Convert.ToInt32(campoData.Substring(6, 2));

            return new DateTime(ano, mes, dia);
        }
    }
}
