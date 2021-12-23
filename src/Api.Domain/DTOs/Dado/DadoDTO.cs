using System;
using System.Text.Json.Serialization;
using Api.Domain.Entities;
using Api.Domain.Enums;

namespace Api.Domain.DTOs.Dado
{
    public class DadoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public CategoriaEnum Categoria { get; set; }
        public int DataMappingID { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
