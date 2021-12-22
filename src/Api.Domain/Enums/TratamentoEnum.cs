using System.ComponentModel;

namespace Api.Domain.Enums
{
    public enum TratamentoEnum
    {
        [Description("Coleta")]
        Coleta = 1,

        [Description("Produção")]
        Producao = 2,

        [Description("Recepção")]
        Recepcao = 3,

        [Description("Classificação")]
        Classificacao = 4,

        [Description("Utilização")]
        Utilizacao = 5,

        [Description("Acesso")]
        Acesso = 6,

        [Description("Reprodução")]
        Reproducao =7,

        [Description("Transmissão")]
        Transmissao = 8,

        [Description("Distribuição")]
        Distribuicao = 9,

        [Description("Processamento")]
        Processamento = 10,

        [Description("Eliminação")]
        Eliminacao = 11,

        [Description("Avaliação ou controle da informação")]
        Avaliacao = 12,

        [Description("Modificação")]
        Modificacao = 13,

        [Description("Comunicação")]
        Comunicacao = 14,

        [Description("Transferência")]
        Transferencia = 15,

        [Description("Difusão")]
        Difusao = 16,

        [Description("Extração")]
        Extracao = 17
    }
}
