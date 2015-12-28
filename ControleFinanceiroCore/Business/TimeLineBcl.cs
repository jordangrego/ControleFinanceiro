using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleFinanceiroCore.Entities;
using System.Globalization;

namespace ControleFinanceiroCore.Business
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TimeLineBcl
    {
        public List<TimeLine> PesquisaTimeLineTipoLancamento(TimeLineCriterio criterio)
        {
            List<TimeLine> lista = new List<TimeLine>();

            List<Lancamento> lancamentosEnvolvidos = (new LancamentoBcl().RecuperaListaCompleta())
                .Where(l => l.DataLancamento >= criterio.DiaInicial && l.DataLancamento <= criterio.DiaFinal && l.SubTipoLancamento.TipoLancamento.IdTipoLancamento.Equals(criterio.TipoLancamento.IdTipoLancamento))
                .OrderBy(l => l.DataLancamento)
                .ToList<Lancamento>();

            int mesAtual = criterio.DiaInicial.Month;
            int anoAtual = criterio.DiaInicial.Year;

            int mesFinal = (criterio.DiaFinal.Month + 1).Equals(13) ? 1 : criterio.DiaFinal.Month + 1;
            int anoFinal = (criterio.DiaFinal.Month + 1).Equals(13) ? (criterio.DiaFinal.Year + 1) : criterio.DiaFinal.Year;

            while (!(mesAtual.Equals(mesFinal) && anoAtual.Equals(anoFinal)))
            {
                TimeLine registro = new TimeLine();
                registro.Ano = anoAtual;
                registro.Mes = mesAtual;
                registro.Total = lancamentosEnvolvidos.Where(l => l.DataLancamento.Month.Equals(mesAtual) && l.DataLancamento.Year.Equals(anoAtual)).Sum(o => o.ValorLancamento);
                registro.NomeMes = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(new DateTime(anoAtual, mesAtual, 1).ToString("MMM", CultureInfo.CurrentCulture));
                lista.Add(registro);

                if (mesAtual < 12)
                {
                    mesAtual++;
                }
                else
                {
                    mesAtual = 1;
                    anoAtual++;
                }
            }

            return lista.OrderBy(t => t.Ano).ThenBy(t => t.Mes).ToList<TimeLine>();
        }

        public List<TimeLine> PesquisaTimeLineSubTipoLancamento(TimeLineSubTipoCriterio criterio)
        {
            List<TimeLine> lista = new List<TimeLine>();

            List<Lancamento> lancamentosEnvolvidos = (new LancamentoBcl().RecuperaListaCompleta())
                .Where(l => l.DataLancamento >= criterio.DiaInicial && l.DataLancamento <= criterio.DiaFinal && l.SubTipoLancamento.IdSubTipoLancamento.Equals(criterio.SubTipoLancamento.IdSubTipoLancamento))
                .OrderBy(l => l.DataLancamento)
                .ToList<Lancamento>();

            int mesAtual = criterio.DiaInicial.Month;
            int anoAtual = criterio.DiaInicial.Year;

            int mesFinal = (criterio.DiaFinal.Month + 1).Equals(13) ? 1 : criterio.DiaFinal.Month + 1;
            int anoFinal = (criterio.DiaFinal.Month + 1).Equals(13) ? (criterio.DiaFinal.Year + 1) : criterio.DiaFinal.Year;

            while (!(mesAtual.Equals(mesFinal) && anoAtual.Equals(anoFinal)))
            {
                TimeLine registro = new TimeLine();
                registro.Ano = anoAtual;
                registro.Mes = mesAtual;
                registro.Total = lancamentosEnvolvidos.Where(l => l.DataLancamento.Month.Equals(mesAtual) && l.DataLancamento.Year.Equals(anoAtual)).Sum(o => o.ValorLancamento);
                registro.NomeMes = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(new DateTime(anoAtual, mesAtual, 1).ToString("MMM", CultureInfo.CurrentCulture));
                lista.Add(registro);

                if (mesAtual < 12)
                {
                    mesAtual++;
                }
                else
                {
                    mesAtual = 1;
                    anoAtual++;
                }

            }

            return lista.OrderBy(t => t.Ano).ThenBy(t => t.Mes).ToList<TimeLine>();
        }

        public List<TimeLine> PesquisaTimeline(TimeLineCriterio criterio)
        {
            List<TimeLine> lista = new List<TimeLine>();

            List<Lancamento> lancamentosEnvolvidos = (new LancamentoBcl().RecuperaListaCompleta())
                .Where(l => l.DataLancamento >= criterio.DiaInicial && l.DataLancamento <= criterio.DiaFinal && l.SubTipoLancamento.TipoLancamento.IdTipoLancamento.Equals(criterio.TipoLancamento.IdTipoLancamento))
                .OrderBy(l => l.DataLancamento)
                .ToList<Lancamento>();

            List<SubTipoLancamento> listaSubTipo = new SubTipoLancamentoBcl().FiltraPorTipoLancamento(new TipoLancamento() { IdTipoLancamento = criterio.TipoLancamento.IdTipoLancamento });

            foreach (SubTipoLancamento subTipo in listaSubTipo)
            {
                int mesAtual = criterio.DiaInicial.Month;
                int anoAtual = criterio.DiaInicial.Year;

                int mesFinal = (criterio.DiaFinal.Month + 1).Equals(13) ? 1 : criterio.DiaFinal.Month + 1;
                int anoFinal = (criterio.DiaFinal.Month + 1).Equals(13) ? (criterio.DiaFinal.Year + 1) : criterio.DiaFinal.Year;

                while (!(mesAtual.Equals(mesFinal) && anoAtual.Equals(anoFinal)))
                {
                    TimeLine registro = new TimeLine();
                    registro.DesSubTipo = subTipo.DescSubTipoLancamento;
                    registro.Ano = anoAtual;
                    registro.Mes = mesAtual;
                    registro.Total = lancamentosEnvolvidos.Where(l => l.DataLancamento.Month.Equals(mesAtual) && l.DataLancamento.Year.Equals(anoAtual) && l.SubTipoLancamento.IdSubTipoLancamento.Equals(subTipo.IdSubTipoLancamento)).Sum(o => o.ValorLancamento);
                    registro.NomeMes = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(new DateTime(anoAtual, mesAtual, 1).ToString("MMM", CultureInfo.CurrentCulture));
                    lista.Add(registro);

                    if (mesAtual < 12)
                    {
                        mesAtual++;
                    }
                    else
                    {
                        mesAtual = 1;
                        anoAtual++;
                    }
                }

                double valorTotalSubTipo = lista.Where(t => t.DesSubTipo.Equals(subTipo.DescSubTipoLancamento)).Sum(t => t.Total);

                if (valorTotalSubTipo.Equals(0))
                {
                    lista.RemoveAll(t => t.DesSubTipo.Equals(subTipo.DescSubTipoLancamento));
                }
            }

            return lista.OrderBy(t => t.Ano).ThenBy(t => t.Mes).ToList<TimeLine>();
        }

        public List<TimeLine> ListaTimeLineReceitaDespesa(TimeLineCriterio criterio)
        {
            List<TimeLine> lista = new List<TimeLine>();

            List<Lancamento> lancamentosEnvolvidos = (new LancamentoBcl().RecuperaListaCompleta())
                .Where(l => l.DataLancamento >= criterio.DiaInicial && l.DataLancamento <= criterio.DiaFinal)
                .OrderBy(l => l.DataLancamento)
                .ToList<Lancamento>();

            foreach(Lancamento lancamento in lancamentosEnvolvidos)
            {
                string tipoLancamento = lancamento.SubTipoLancamento.TipoLancamento.DescTipoLancamento.Equals("Receitas") ? "Receitas" : "Despesas";

                // localiza o registro na lista
                TimeLine registro = lista.Where(t => t.Mes.Equals(lancamento.DataLancamento.Month) && t.Ano.Equals(lancamento.DataLancamento.Year) && t.DesSubTipo.Equals(tipoLancamento)).FirstOrDefault<TimeLine>();

                if (registro == null)
                {
                    registro = new TimeLine();
                    registro.DesSubTipo = tipoLancamento;
                    registro.Ano = lancamento.DataLancamento.Year;
                    registro.Mes = lancamento.DataLancamento.Month;
                    registro.NomeMes = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(new DateTime(lancamento.DataLancamento.Year, lancamento.DataLancamento.Month, 1).ToString("MMM", CultureInfo.CurrentCulture));
                    registro.Total = 0;
                    lista.Add(registro);
                }

                registro.Total = registro.Total + lancamento.ValorLancamento;
            }

            return lista;
        }
    }
}
