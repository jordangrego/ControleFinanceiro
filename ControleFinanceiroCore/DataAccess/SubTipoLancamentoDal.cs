using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleFinanceiroCore.Util;
using ControleFinanceiroCore.Entities;

namespace ControleFinanceiroCore.DataAccess
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SubTipoLancamentoDal
    {
        public List<Entities.SubTipoLancamento> RecuperaCompleto()
        {
            return UtilBase.RecuperarBase().DominioSubTipoLancamento;
        }

        public List<Entities.SubTipoLancamento> FiltraPorTipoLancamento(TipoLancamento tipoLancamentoCriterio)
        {
            List<SubTipoLancamento> listaCompleta = UtilBase.RecuperarBase().DominioSubTipoLancamento;
            return listaCompleta.Where(s => s.TipoLancamento.IdTipoLancamento.Equals(tipoLancamentoCriterio.IdTipoLancamento)).ToList<SubTipoLancamento>();
        }

        public SubTipoLancamento Recuperar(int idSubTipo)
        {
            List<SubTipoLancamento> listaCompleta = UtilBase.RecuperarBase().DominioSubTipoLancamento;
            return listaCompleta.Where(s => s.IdSubTipoLancamento.Equals(idSubTipo)).First<SubTipoLancamento>();
        }
    }
}
