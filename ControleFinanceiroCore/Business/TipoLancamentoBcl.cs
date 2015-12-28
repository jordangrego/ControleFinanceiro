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
    public class TipoLancamentoBcl
    {
        public TipoLancamentoDal TipoLancamentoDal { get; set; }

        public TipoLancamentoBcl()
        {
            this.TipoLancamentoDal = new TipoLancamentoDal();
        }

        public List<TipoLancamento> RecuperaTiposLancamento()
        {
            return this.TipoLancamentoDal.RecuperaTiposLancamento();
        }

        public TipoLancamento Recupera(int IdTipoLancamento)
        {
            return this.RecuperaTiposLancamento().Where(t => t.IdTipoLancamento.Equals(IdTipoLancamento)).First<TipoLancamento>();
        }
    }
}
