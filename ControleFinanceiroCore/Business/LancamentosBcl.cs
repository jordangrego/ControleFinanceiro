using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleFinanceiroCore.Entities;
using ControleFinanceiroCore.DataAccess;

namespace ControleFinanceiroCore.Business
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LancamentoBcl
    {
        /// <summary>
        /// 
        /// </summary>
        public LancamentoDal LancamentoDal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public LancamentoBcl()
        {
            this.LancamentoDal = new LancamentoDal();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lancamento"></param>
        public void Inserir(Lancamento lancamento)
        {
            lancamento.IdLancamento = this.RecuperaProxIdLancamento();
            this.LancamentoDal.Inserir(lancamento);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lancamento"></param>
        public void Atualizar(Lancamento lancamento)
        {
            this.LancamentoDal.Atualizar(lancamento);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idLancamento"></param>
        public void Excluir(int idLancamento)
        {
            this.LancamentoDal.Excluir(idLancamento);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idLancamento"></param>
        /// <returns></returns>
        public Lancamento Recuperar(int idLancamento)
        {
            return this.LancamentoDal.Recuperar(idLancamento);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lancamentoCriterio"></param>
        /// <returns></returns>
        public List<Lancamento> Pesquisar(Lancamento lancamentoCriterio)
        {
            return this.LancamentoDal.Pesquisar(lancamentoCriterio);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Lancamento> RecuperaListaCompleta()
        {
            return this.LancamentoDal.RecuperaListaCompleta();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaLancamento"></param>
        public void InserirListaLancamentos(List<Lancamento> listaLancamento)
        {
            this.LancamentoDal.InserirListaLancamentos(listaLancamento);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int RecuperaProxIdLancamento()
        {
            return this.LancamentoDal.RecuperaProxIdLancamento();
        }

        public List<Lancamento> PesquisaTimeLineLancamento(LancamentoCriterio criterio)
        {
            List<Lancamento> listaCompleta = this.RecuperaListaCompleta();

            return listaCompleta.Where(l => l.DataLancamento >= criterio.DataInicial && l.DataLancamento <= criterio.DataFinal && l.SubTipoLancamento.IdSubTipoLancamento.Equals(criterio.SubTipoLancamento.IdSubTipoLancamento)).OrderBy(l => l.DataLancamento).ToList<Lancamento>();
        }
    }
}
