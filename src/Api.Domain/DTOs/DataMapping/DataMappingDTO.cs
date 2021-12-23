using System;
using System.Collections.Generic;
using Api.Domain.DTOs.Dado;
using Api.Domain.Entities;
using Api.Domain.Enums;

namespace Api.Domain.DTOs.DataMapping
{
    public class DataMappingDTO
    {
        public int Id { get; set; }
        public string Area { get; set; }
        public string Processo { get; set; }
        public string DonoProcesso { get; set; }
        public int Volume { get; set; }
        public FormatoEnum Formato { get; set; }
        public FrequenciaEnum Frequencia { get; set; }
        public NaturezaTitularEnum NaturezaTitular { get; set; }
        public OrigemEnum Origem { get; set; }
        public TratamentoEnum Tratamento { get; set; }
        public BasesLegaisEnum BaseLegal { get; set; }
        public bool DadosCriancasAdolescentes { get; set; }
        public string MesReferencia { get; set; }
        public string AnoReferencia { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public virtual ICollection<DadoDTO> Dados { get; set; }
    }
}
