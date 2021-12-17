using System;
using Api.Domain.DTOs.Perfil;

namespace Api.Domain.DTOs.Usuario
{
    public class UsuarioDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public PerfilDTONested Perfil { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
