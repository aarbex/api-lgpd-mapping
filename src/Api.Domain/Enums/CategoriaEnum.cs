using System.ComponentModel;

namespace Api.Domain.Enums
{
    public enum CategoriaEnum
    {
        [Description("Dados Pessoais Comuns")]
        Comuns = 1,

        [Description("Dados Pessoais Sensíveis")]
        Sensiveis = 2,

        [Description("Dados Pessoais de Crianças e Adolescentes")]
        CriancasAdolescentes = 3,
    }
}
