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
    public class TipoLancamentoDal
    {
        public List<TipoLancamento> RecuperaTiposLancamento()
        {
            return UtilBase.RecuperarBase().DominioTipoLancamento;
        }
    }
}
