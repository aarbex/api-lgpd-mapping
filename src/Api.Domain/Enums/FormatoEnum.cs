using System.ComponentModel;

namespace Api.Domain.Enums
{
    public enum FormatoEnum
    {
        [Description("Banco de Dados")]
        BancoDados = 1,

        [Description("Mídias Digitais Removíveis")]
        DigitaisRemoviveis = 2,

        [Description("Mídias Digitais Não Removíveis")]
        DigitaisNaoRemoviveis = 3,

        [Description("Mìdias Físicas")]
        Fisicas = 4
    }
}
