using System.ComponentModel;

namespace Api.Domain.Enums
{
    public enum BasesLegaisEnum
    {

        [Description("Consentimento do titular")]
        Consentimento = 1,

        [Description("Cumprimento de obrigação legal ou regulatória")]
        ObrigacaoLegal = 2,

        [Description("Execução de políticas públicas")]
        PoliticasPublicas = 3,

        [Description("Realização de estudos por órgão de pesquisa")]
        Pesquisa = 4,

        [Description("Execução ou criação de contrato")]
        ExecucaoContrato = 5,

        [Description("Exercício regular de direitos")]
        ExercicioDireitos = 6,

        [Description("Proteção da vida")]
        ProtecaoVida = 7,

        [Description("Tutela da saúde")]
        TutelaSaude = 8,

        [Description("Legítimo interesse")]
        LegitimoInteresse = 9,

        [Description("Proteção do crédito")]
        ProtecaoCredito = 10
    }
}
