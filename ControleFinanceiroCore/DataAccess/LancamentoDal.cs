using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleFinanceiroCore.Entities;
using ControleFinanceiroCore.Util;

namespace ControleFinanceiroCore.DataAccess
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LancamentoDal
    {
        /// <summary>
        /// Insere Lançamento
        /// </summary>
        /// <param name="lancamento">Entidade Lançamento</param>
        public void Inserir(Lancamento lancamento)
        {
            List<Lancamento> lista = this.RecuperaLancamentosBase();
            lista.Add(lancamento);
            this.GravaLancamentos(lista);
        }

        /// <summary>
        /// Atualiza Lançamento
        /// </summary>
        /// <param name="lancamentoUpdate">Entidade Lançamento</param>
        public void Atualizar(Lancamento lancamentoUpdate)
        {
            List<Lancamento> lista = this.RecuperaLancamentosBase();
            Lancamento lancamento = lista.Where(l => l.IdLancamento.Equals(lancamentoUpdate.IdLancamento)).First<Lancamento>();
            lancamento.ValorLancamento = lancamentoUpdate.ValorLancamento;
            lancamento.DescricaoLancamento = lancamentoUpdate.DescricaoLancamento;
            lancamento.DataLancamento = lancamentoUpdate.DataLancamento;
            lancamento.SubTipoLancamento = lancamentoUpdate.SubTipoLancamento;
            lancamento.Observacao = lancamentoUpdate.Observacao;
            this.GravaLancamentos(lista);
        }

        /// <summary>
        /// Excluir Lançamento
        /// </summary>
        /// <param name="idLancamento">Id do Lançamento</param>
        public void Excluir(int idLancamento)
        {
            List<Lancamento> lista = this.RecuperaLancamentosBase();
            lista.RemoveAll(l => l.IdLancamento.Equals(idLancamento));
            this.GravaLancamentos(lista);
        }

        /// <summary>
        /// Recupera um Lançamento.
        /// </summary>
        /// <param name="idLancamento">Id do Lançamento.</param>
        /// <returns>Entidade Lançamento.</returns>
        public Lancamento Recuperar(int idLancamento)
        {
            List<Lancamento> lista = this.RecuperaLancamentosBase();
            Lancamento lancamento = lista.Where(l => l.IdLancamento.Equals(idLancamento)).First<Lancamento>();
            return lancamento;
        }

        /// <summary>
        /// Pesquisa Lançamentos
        /// </summary>
        /// <param name="lancamentoCriterio">Criterio de Consulta.</param>
        /// <returns>Lista de Lançamentos.</returns>
        public List<Lancamento> Pesquisar(Lancamento lancamentoCriterio)
        {
            List<Lancamento> lista = this.RecuperaLancamentosBase();
            return lista;
        }

        /// <summary>
        /// Recupera Todos os Lançamentos.
        /// </summary>
        /// <returns>Lista de Lançamentos.</returns>
        public List<Lancamento> RecuperaListaCompleta()
        {
            List<Lancamento> lista = this.RecuperaLancamentosBase();
            return lista;
        }

        /// <summary>
        /// Recupera Lancamentos Base
        /// </summary>
        /// <returns>Lista de Lançamentos.</returns>
        private List<Lancamento> RecuperaLancamentosBase()
        {
            return UtilBase.RecuperarBase().ListaLancamentos;
        }

        private void GravaLancamentos(List<Lancamento> listaLancamentos)
        {
            Base baseLancamentos = UtilBase.RecuperarBase();
            baseLancamentos.ListaLancamentos = listaLancamentos;
            UtilBase.GravarBase(baseLancamentos);
        }

        public void InserirListaLancamentos(List<Lancamento> listaLancamento)
        {
            List<Lancamento> lista = this.RecuperaLancamentosBase();

            foreach (Lancamento lancamento in listaLancamento)
            {
                lista.Add(lancamento);
            }

            this.GravaLancamentos(lista);
        }

        public int RecuperaProxIdLancamento()
        {
            List<Lancamento> lista = this.RecuperaLancamentosBase();

            if (lista != null && lista.Count > 0)
            {
                return lista.Select(l => l.IdLancamento).Max() + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
