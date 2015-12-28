using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleFinanceiroCore.Entities;
using ControleFinanceiroCore.Util;
using System.IO;
using ControleFinanceiroCore.Enums;

namespace ControleFinanceiroCore.Business
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class DadosControleFinanceiro
    {
        public static void InicializarDados()
        {
            string pathArquivoBase = AppDomain.CurrentDomain.BaseDirectory + "\\Base.xml";

            // verifica se existe o arquivo no local
            if (!File.Exists(pathArquivoBase))
            {
                UtilBase.GravarBase(GeraBase(), pathArquivoBase);
            }
        }

        private static Base GeraBase()
        {
            Base baseLancamento = new Base();
            baseLancamento.DominioTipoLancamento = GeraDominioTipoLancamento();
            baseLancamento.DominioSubTipoLancamento = GeraDominioSubTipoLancamento(baseLancamento.DominioTipoLancamento);
            baseLancamento.ListaLancamentos = new List<Lancamento>();

            return baseLancamento;
        }

        private static List<SubTipoLancamento> GeraDominioSubTipoLancamento(List<TipoLancamento> listaTipoLancamento)
        {
            List<SubTipoLancamento> listaSubTiposLancamento = new List<SubTipoLancamento>();
            var values = Enum.GetValues(typeof(EnumSubTipoLancamento));
            foreach (object o in values)
            {
                EnumSubTipoLancamento dominio = (EnumSubTipoLancamento)o;

                SubTipoLancamento subTipoLancamento = new SubTipoLancamento();
                subTipoLancamento.IdSubTipoLancamento = (int)dominio;
                subTipoLancamento.DescSubTipoLancamento = UtilComum.GetEnumDescription(dominio);
                subTipoLancamento.TipoLancamento = listaTipoLancamento.Where(t => t.IdTipoLancamento.Equals(Convert.ToInt32(subTipoLancamento.IdSubTipoLancamento.ToString().Substring(0,1)))).First<TipoLancamento>();
                listaSubTiposLancamento.Add(subTipoLancamento);
            }

            return listaSubTiposLancamento;
        }

        private static List<TipoLancamento> GeraDominioTipoLancamento()
        {
            List<TipoLancamento> listaTiposLancamento = new List<TipoLancamento>();
            var values = Enum.GetValues(typeof(EnumTiposLancamento));
            foreach (object o in values)
            {
                EnumTiposLancamento dominio = (EnumTiposLancamento)o;

                TipoLancamento tipoLancamento = new TipoLancamento();
                tipoLancamento.IdTipoLancamento = (int)dominio;
                tipoLancamento.DescTipoLancamento = UtilComum.GetEnumDescription(dominio);

                listaTiposLancamento.Add(tipoLancamento);
            }

            return listaTiposLancamento;
        }
    }
}
