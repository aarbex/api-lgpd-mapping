using System.ComponentModel;

namespace Api.Domain.Enums
{
    public enum NaturezaTitularEnum
    {
        [Description("Colaborador")]
        Colaborador = 1,

        [Description("Terceiro")]
        Terceiro = 2,

        [Description("Cliente")]
        Cliente = 3,

        [Description("Fornecedor")]
        Fornecedor = 4
    }
}
