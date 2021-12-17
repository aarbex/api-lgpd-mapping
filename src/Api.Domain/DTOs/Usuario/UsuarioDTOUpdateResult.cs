using System;
using Api.Domain.DTOs.Perfil;

namespace Api.Domain.DTOs.Usuario
{
    public class UsuarioDTOUpdateResult
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }

        public int PerfilID { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
