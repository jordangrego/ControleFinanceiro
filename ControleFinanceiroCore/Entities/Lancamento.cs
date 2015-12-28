using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiroCore.Entities
{
    /// <summary>
    /// Classe Entidade de Lançamento.
    /// </summary>
    public class Lancamento
    {
        public int IdLancamento { get; set; }
        public DateTime DataLancamento { get; set; }
        public string DescricaoLancamento { get; set; }
        public double ValorLancamento { get; set; }
        public SubTipoLancamento SubTipoLancamento { get; set; }
        public string Observacao { get; set; }

        public string DescSubTipo 
        {   
            get 
            {
                if (this.SubTipoLancamento != null)
                {
                    return this.SubTipoLancamento.DescSubTipoLancamento;
                }
                else
                {
                    return string.Empty;
                }
            } 
        }

        public string DescTipo 
        { 
            get 
            {
                if (this.SubTipoLancamento != null && this.SubTipoLancamento.TipoLancamento != null)
                {
                    return this.SubTipoLancamento.TipoLancamento.DescTipoLancamento;
                }
                else
                {
                    return string.Empty;
                }

            }
        }

        public string DataLancamentoDesc
        {
            get
            {
                string retorno = string.Empty;
                if (!this.DataLancamento.Equals(DateTime.MinValue))
                {
                    retorno = this.DataLancamento.ToString("dd/MM/yyyy");
                }
                return retorno;
            }
        }
    }
}
