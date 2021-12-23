using System.ComponentModel;

namespace Api.Domain.Enums
{
    public enum CategoriaEnum
    {
        [Description("Dados Pessoais Comuns")]
        Comuns = 1,

        [Description("Dados Pessoais Sensíveis")]
        Sensiveis = 2
    }
}
