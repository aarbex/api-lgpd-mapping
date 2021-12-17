using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class Perfil : Base
    {
        public string Nome { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
