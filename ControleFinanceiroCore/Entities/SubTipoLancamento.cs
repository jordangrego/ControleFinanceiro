using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiroCore.Entities
{
    /// <summary>
    /// Classe Entidade de Sub Tipo de Lançamento.
    /// </summary>
    public class SubTipoLancamento
    {
        public int IdSubTipoLancamento { get; set; }
        public string DescSubTipoLancamento { get; set; }
        public TipoLancamento TipoLancamento { get; set; }
    }
}
