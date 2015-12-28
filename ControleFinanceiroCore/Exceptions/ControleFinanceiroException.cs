using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleFinanceiroCore.Resources;
using ControleFinanceiroCore.Enums;

namespace ControleFinanceiroCore.Exceptions
{
    /// <summary>
    /// Exception ControleFinanceiroCore
    /// </summary>
    public class ControleFinanceiroCoreException : System.Exception
    {
        /// <summary>
        /// Construtor simples desta Exception.
        /// </summary>
        public ControleFinanceiroCoreException()
        {
        }

        /// <summary>
        /// Construtor passando a mensagem de erro.
        /// </summary>
        /// <param name="message">Mensagem desta Exception.</param>
        public ControleFinanceiroCoreException(string message) : base(message)
        {
        }

        /// <summary>
        /// Construtor passando a mensagem de erro e uma Exception interna..
        /// </summary>
        /// <param name="message">Mensagem desta Exception.</param>
        /// <param name="innerException">Exception interna.</param>
        public ControleFinanceiroCoreException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Construtor passando o Domínio de Erro.
        /// </summary>
        /// <param name="srcoEnumErro">Dominio de Erro utilizado para lançar essa Exception.</param>
        public ControleFinanceiroCoreException(ControleFinanceiroEnumErro controleFinanceiroEnumErro)
            : this(RecuperaMensagemErro(controleFinanceiroEnumErro))
        {
        }

        /// <summary>
        /// Construtor passando o Domínio de Erro.
        /// </summary>
        /// <param name="srcoEnumErro">Dominio de Erro utilizado para lançar essa Exception.</param>
        /// <param name="descricaoErro">Campo de Validação.</param>
        public ControleFinanceiroCoreException(ControleFinanceiroEnumErro controleFinanceiroEnumErro, string descricaoErro)
            : this(RecuperaMensagemErro(controleFinanceiroEnumErro, descricaoErro))
        {   
        }

        /// <summary>
        /// Construtor passando o Domínio de Erro e outra Exception.
        /// </summary>
        /// <param name="srcoEnumErro">Dominio de Erro utilizado para lançar essa Exception.</param>
        /// <param name="innerException">Exception interna.</param>
        public ControleFinanceiroCoreException(ControleFinanceiroEnumErro controleFinanceiroEnumErro, System.Exception innerException)
            : this(RecuperaMensagemErro(controleFinanceiroEnumErro), innerException)
        {
        }

        /// <summary>
        /// Construtor passando o Domínio de Erro e outra Exception.
        /// </summary>
        /// <param name="srcoEnumErro">Dominio de Erro utilizado para lançar essa Exception.</param>
        /// <param name="descricaoErro">Campo de Validação.</param>
        /// <param name="innerException">Exception interna.</param>
        public ControleFinanceiroCoreException(ControleFinanceiroEnumErro srcoEnumErro, string descricaoErro, System.Exception innerException)
            : this(RecuperaMensagemErro(srcoEnumErro, descricaoErro), innerException)
        {
        }

        /// <summary>
        /// Recupera a descrição do Domínio de Erro.
        /// </summary>
        /// <param name="value">DominioErro para recuperar a descrição.</param>
        /// <returns>Descrição do Domínio de Erro.</returns>
        private static string RecuperaMensagemErro(Enum value)
        {
            return MensagensErro.ResourceManager.GetString(Enum.GetName(typeof(ControleFinanceiroEnumErro), value));
        }

        /// <summary>
        /// Recupera a descrição do Domínio de Erro.
        /// </summary>
        /// <param name="value">DominioErro para recuperar a descrição.</param>
        /// <param name="descricaoErro">Campo de Validação.</param>
        /// <returns>Descrição do Domínio de Erro.</returns>
        private static string RecuperaMensagemErro(Enum value, string descricaoErro)
        {
            return MensagensErro.ResourceManager.GetString(Enum.GetName(typeof(ControleFinanceiroEnumErro), value)) + " : " + descricaoErro;
        }
    }
}
