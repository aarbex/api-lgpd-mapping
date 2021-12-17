using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.DTOs.Perfil;

namespace Api.Domain.DTOs.Usuario
{
    public class UsuarioDTOCreateResult
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public int PerfilID { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
