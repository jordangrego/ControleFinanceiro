using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiroCore.Entities
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TimeLineSubTipoCriterio
    {
        public DateTime DiaInicial { get; set; }
        public DateTime DiaFinal { get; set; }
        public SubTipoLancamento SubTipoLancamento { get; set; }
    }
}
