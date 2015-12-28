using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiroCore.Entities
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LancamentoCriterio
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public SubTipoLancamento SubTipoLancamento { get; set; }
    }
}
