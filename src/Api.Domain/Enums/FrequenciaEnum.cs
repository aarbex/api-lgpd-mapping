using System.ComponentModel;

namespace Api.Domain.Enums
{
    public enum FrequenciaEnum
    {
        [Description("Sob Demanda")]
        SobDemanda = 1,

        [Description("Anual")]
        Anual = 2,

        [Description("Semestral")]
        Semestral = 3,

        [Description("Quadrimestral")]
        Quadrimestral = 4,

        [Description("Trimestral")]
        Trimestral = 5,

        [Description("Bimestral")]
        Bimestral = 6,

        [Description("Mensal")]
        Mensal = 7,

        [Description("Quinzenal")]
        Quinzenal = 8,

        [Description("Semanal")]
        Semanal = 9,

        [Description("Diário")]
        Diário = 10

    }
}
