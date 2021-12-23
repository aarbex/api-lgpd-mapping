using Api.Domain.Enums;

namespace Api.Domain.Entities
{
    public class Dado : Base
    {
        public string Nome { get; set; }
        public CategoriaEnum Categoria { get; set; }
        public int DataMappingID { get; set; }
        public virtual DataMapping DataMapping { get; set; }
    }
}
