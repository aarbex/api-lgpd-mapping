using System;

namespace Api.Domain.DTOs.Perfil
{
    public class PerfilDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
