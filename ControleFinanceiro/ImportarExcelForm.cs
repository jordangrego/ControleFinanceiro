using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiroCore.Ofx;
using ControleFinanceiroCore.Exceptions;
using ControleFinanceiroCore.Entities;

namespace ControleFinanceiro
{
    public partial class ImportarExcelForm : Form
    {
        public ImportarExcelForm()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            AbreDialogArquivo();
        }

        public void AbreDialogArquivo()
        {
            try
            {
                OpenFileDialog dialogArquivo = new OpenFileDialog();
                dialogArquivo.Multiselect = false;
                dialogArquivo.Filter = "Excel (.xls, xlsx)|*.xls|Excel 2010 (*.xlsx)|*.xlsx";
                if (dialogArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(dialogArquivo.FileName))
                    {
                        ConversorExcel conversor = new ConversorExcel();
                        DataSet ds = conversor.ImportarArquivoExcel(dialogArquivo.FileName);
                        this.dgvImportacao.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Selecione um Arquivo.");
                    }
                }
            }
            catch (ControleFinanceiroCoreException ex)
            {
                MessageBox.Show(ex.InnerException.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (this.dgvImportacao.SelectedRows.Count > 0)
            {
                if (this.ValidaLinhasSelecionadas())
                {
                    List<Lancamento> listaLancamento = new List<Lancamento>();
                    foreach (DataGridViewRow linha in this.dgvImportacao.SelectedRows)
                    {
                        Lancamento lancamento = new Lancamento();
                        lancamento.ValorLancamento = Math.Abs(Convert.ToDouble(linha.Cells[2].Value.ToString()));
                        lancamento.DataLancamento = Convert.ToDateTime(linha.Cells[0].Value.ToString());
                        lancamento.DescricaoLancamento = linha.Cells[1].Value.ToString();
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
                    MessageBox.Show("Existe um erro em uma das linhas selecionadas, que deve seguir as seguintes regras:\n-A 1º coluna deve ser uma data (formato DD/MM/AAAA).\n-A 2º coluna é o descritivo.\n-A 3º coluna o valor (formato 9,99).", "Erro em uma linha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos uma linha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidaLinhasSelecionadas()
        {
            foreach (DataGridViewRow linhaSelecionada in this.dgvImportacao.SelectedRows)
            {
                if (!this.IsLinhaValida(linhaSelecionada))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsLinhaValida(DataGridViewRow linha)
        {
            try
            {
                DateTime dataLancamento = Convert.ToDateTime(linha.Cells[0].Value.ToString());
                string descricao = linha.Cells[1].Value.ToString();
                Double valor = Convert.ToDouble(linha.Cells[2].Value);
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void ImportarExcelForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção, para o uso desta funcionalidade, o arquivo excel deve seguir as seguintes regras:\n-Será lida apenas a primeira planilha do Arquivo, independente do seu nome.\n-A primeira linha NÃO será lida como nome da coluna, então a primeira linha já será lida como um registro.\n-A 1º coluna deve ser uma data (formato DD/MM/AAAA).\n-A 2º coluna é o descritivo.\n-A 3º coluna o valor (formato 9,99).", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
