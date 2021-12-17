using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
    public class Usuario : Base
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        [NotMapped]
        public string SenhaNova { get; set; }
    }
}
