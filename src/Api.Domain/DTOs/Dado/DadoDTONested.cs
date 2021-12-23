using System.Text.Json.Serialization;
using Api.Domain.Enums;

namespace Api.Domain.DTOs.Dado
{
    public class DadoDTONested
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public CategoriaEnum Categoria { get; set; }

        public int DataMappingID { get; set; }
    }
}
