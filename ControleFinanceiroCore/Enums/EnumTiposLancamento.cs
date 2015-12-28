using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ControleFinanceiroCore.Enums
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public enum EnumTiposLancamento
    {
        // Tipo de dados.
        [Description("Receitas")]
        RECEITA = 1,
        [Description("Moradia")]
        MORADIA = 2,
        [Description("Transporte")]
        TRANSPORTE = 3,
        [Description("Alimentação")]
        ALIMENTACAO = 4,
        [Description("Educação")]
        EDUCACAO = 5,
        [Description("Comunicação")]
        COMUNICACAO = 6,
        [Description("Lazer")]
        Lazer = 7,
        [Description("Saúde")]
        SAUDE = 8,
        [Description("Diversos")]
        DIVERSOS = 9,
        /*
        [Description("Impostos")]
        IMPOSTOS = 9,
        [Description("Dívidas")]
        DIVIDAS = 10,
        */ 
    }
}
