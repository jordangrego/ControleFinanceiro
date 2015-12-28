using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleFinanceiroCore.Entities
{
    /// <summary>
    /// Base do Usuário.
    /// </summary>
    public class Base
    {
        public List<TipoLancamento> DominioTipoLancamento { get; set; }
        public List<SubTipoLancamento> DominioSubTipoLancamento { get; set; }
        public List<Lancamento> ListaLancamentos { get; set; }
    }
}
