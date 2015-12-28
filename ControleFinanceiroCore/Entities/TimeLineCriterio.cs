using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiroCore.Entities
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TimeLineCriterio
    {
        public DateTime DiaInicial { get; set; }
        public DateTime DiaFinal { get; set; }
        public TipoLancamento TipoLancamento { get; set; }
    }
}
