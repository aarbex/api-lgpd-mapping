using System.ComponentModel;

namespace Api.Domain.Enums
{
    public enum OrigemEnum
    {
        [Description("Titular")]
        Titular = 1,

        [Description("Responsável Legal")]
        ResponsavelLegal = 2,

        [Description("Terceiro")]
        Terceiro = 3
    }
}
