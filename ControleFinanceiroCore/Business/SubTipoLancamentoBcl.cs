using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleFinanceiroCore.DataAccess;
using ControleFinanceiroCore.Entities;

namespace ControleFinanceiroCore.Business
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SubTipoLancamentoBcl
    {
        private SubTipoLancamentoDal SubTipoLancamentoDal { get; set; }

        public SubTipoLancamentoBcl()
        {
            this.SubTipoLancamentoDal = new SubTipoLancamentoDal();
        }

        public List<SubTipoLancamento> RecuperaCompleto()
        {
            return this.SubTipoLancamentoDal.RecuperaCompleto();
        }

        public SubTipoLancamento Recuperar(int idSubTipo)
        {
            return this.SubTipoLancamentoDal.Recuperar(idSubTipo);
        }

        public List<SubTipoLancamento> FiltraPorTipoLancamento(TipoLancamento tipoLancamento)
        {
            return this.SubTipoLancamentoDal.FiltraPorTipoLancamento(tipoLancamento);
        }
    }
}
