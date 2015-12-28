using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiroCore.Entities
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TimeLine
    {
        public string NomeMes { get; set; }
        public string DesSubTipo { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public double Total { get; set; }
    }
}
