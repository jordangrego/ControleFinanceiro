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
    public enum EnumSubTipoLancamento
    {
        // Receita.
        [Description("Salário")]
        SALARIO = 11,
        [Description("13º Salário")]
        SALARIO_13 = 12,
        [Description("Abono de Férias")]
        ABONO_FERIAS = 13,
        [Description("Aposentadoria")]
        APOSENTADORIA = 14,
        [Description("Benefícios Empresariais")]
        BENEFICIOS_EMPRESARIAIS = 15,
        [Description("Comissões")]
        COMISSOES = 16,
        [Description("Gratificação")]
        GRATIFICACAO = 17,
        [Description("Hora Extra")]
        HORA_EXTRA = 18,
        [Description("Trabalho Temporário")]
        TRABALHO_TEMPORARIO = 19,

        // Moradia
        [Description("Aluguel")]
        ALUGUEL = 21,
        [Description("Água")]
        AGUA = 22,
        [Description("Babá")]
        BABA = 23,
        [Description("Caseiro")]
        CASEIRO = 24,
        [Description("Condomínio")]
        CONDOMINIO = 25,
        [Description("Empregada")]
        EMPREGADA = 26,
        [Description("Gás")]
        GAS = 27,
        [Description("IPTU")]
        IPTU = 28,
        [Description("Jardineiro")]
        JARDINEIRO = 29,
        [Description("ELETRICIDADE")]
        ELETRICIDADE = 210,
        [Description("Material de Construção")]
        MATERIAL_CONSTRUCAO = 211,
        [Description("Outros")]
        OUTROS_MORADIA = 212,
        [Description("Pedreiro")]
        PEDREIRO = 213,
        [Description("Prestação Financiamento")]
        PRESTACAO_FINANCIAMENTO = 214,
        [Description("Sistemas de Segurança")]
        SISTEMAS_SEGURANCA = 215,

        // transporte
        [Description("Combustível")]
        COMBISTIVEL = 31,
        [Description("Estacionamento")]
        ESTACIONAMENTO = 32,
        [Description("Financiamento da caminhonete")]
        FINANCIAMENTO_CAMINHONETE = 33,
        [Description("Financiamento da moto")]
        FINANCIAMENTO_MOTO = 34,
        [Description("Financiamento da carro")]
        FINANCIAMENTO_CARRO = 35,
        [Description("Fretado")]
        FRETADO = 36,
        [Description("IPVA")]
        IPVA = 37,
        [Description("Manutenção")]
        MANUTENCAO = 38,
        [Description("Metrô")]
        METRO = 39,
        [Description("Multas")]
        MULTA = 310,
        [Description("Ônibus")]
        ONIBUS = 311,
        [Description("Outros")]
        OUTROS_TRANSPORTE = 312,
        [Description("Pedágios")]
        PEDAGIO = 313,
        [Description("Seguro da caminhonete")]
        SEGURO_CAMINHONETE = 314,
        [Description("Seguro da moto")]
        SEGURO_MOTO = 315,
        [Description("Seguro do Carro")]
        SEGURO_CARRO = 316,
        [Description("Táxi")]
        TAXI = 317,
        [Description("Transporte Escolar")]
        TRANSPORTE_ESCOLAR = 318,
        [Description("Passagem Avião")]
        PASSAGEM_AVIAO = 319,

        // alimentação
        [Description("Almoço no Trabalho")]
        ALMOCO_TRABALHO = 41,
        [Description("Mercado")]
        MERCADO = 42,
        [Description("Outros")]
        OUTROS_ALIMENTACAO = 43,
        [Description("Padaria")]
        PADARIA = 44,
        [Description("Restaurante")]
        RESTAURANTE = 45,

        // educação
        [Description("Curso de Idioma")]
        CURSO_IDIOMA = 51,
        [Description("Cursos")]
        CURSOS = 52,
        [Description("Doutorado")]
        DOUTORADO = 53,
        [Description("Escola")]
        ESCOLA = 54,
        [Description("Faculdade")]
        FACULDADE = 55,
        [Description("Material Escolar")]
        MATERIAL_ESCOLAR = 56,
        [Description("Maternal")]
        MATERNAL = 57,
        [Description("Mestrado")]
        MESTRADO = 58,
        [Description("Outros")]
        OUTROS_EDUCACAO = 59,
        [Description("Pós Graduação")]
        POS_GRADUACAO = 510,

        // comunicação
        [Description("Aparelho Celular")]
        APARELHO_CELULAR = 61,
        [Description("Conta Celular")]
        CONTA_CELULAR = 62,
        [Description("Outros")]
        OUTROS_COMUNICACAO = 63,
        [Description("Provedor de Internet")]
        PROVEDOR_INTERNET = 64,
        [Description("Telefone Fixo")]
        TELEFONE_FIXO = 65,
        [Description("TV a Cabo")]
        TV_CABO = 66,
        [Description("Recarga Celular")]
        RECARGA_CELULAR = 67,

        // lazer
        [Description("Academia")]
        ACADEMIA = 71,
        [Description("Bar")]
        BAR = 72,
        [Description("Cinema")]
        CINEMA = 73,
        [Description("Clube")]
        CLUBE = 74,
        [Description("Danceteria")]
        DANCETERIA = 75,
        [Description("Hobbie")]
        HOBBIE = 76,
        [Description("Locadora")]
        LOCADORA = 77,
        [Description("Outros")]
        OUTROS_LAZER = 78,
        [Description("Revistas e Jornais")]
        REVISTAS = 79,
        [Description("Shows")]
        SHOWS = 710,
        [Description("Teatro")]
        TEATRO = 711,
        [Description("Livraria")]
        LIVRARIA = 712,

        // saude
        [Description("Cirurgias")]
        Cirurgias = 81,
        [Description("Convênio")]
        CONVENIO = 82,
        [Description("Dentista")]
        DENTISTA = 83,
        [Description("Exames Laboratoriais")]
        EXAME_LABORATORIAIS = 84,
        [Description("Farmácia")]
        FARMACIA = 85,
        [Description("Lentes de contacto")]
        LENTES_CONTACTO = 86,
        [Description("Medicamentos")]
        MEDICAMENTO = 87,
        [Description("Médico Particular")]
        MEDICO_PARTICULAR = 88,
        [Description("Óculos")]
        OCULOS = 89,

        // Diversos
        [Description("Vestuário Feminino")]
        VESTUARIO_FEMININO = 91,
        [Description("Vestuário Masculino")]
        VESTUARIO_MASCULINO = 92,
        [Description("Vestuário Infantil")]
        VESTUARIO_INFANTIL = 93,
        [Description("Cabelereiro / Barbeiro")]
        CABELEREIRO = 94,
        [Description("Doações")]
        DOACOES = 95,
        [Description("Animal de Estimação")]
        ANIMAL_ESTIMACAO = 96,
        [Description("Outros")]
        OUTROS_DIVERSOS = 97,
        [Description("IOF - Banco")]
        IOF_BANCO = 98,
        [Description("Tarifa Banco")]
        TARIFA_BANCO = 99,
        [Description("Hotel")]
        HOTEL = 910,
        [Description("Compra (Diversas)")]
        COMPRA = 911,
        [Description("Emprestimo")]
        EMPRESTIMO = 912,
    }
}
