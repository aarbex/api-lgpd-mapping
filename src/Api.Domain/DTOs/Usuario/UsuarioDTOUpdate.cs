using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.Usuario
{
    public class UsuarioDTOUpdate
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(60, ErrorMessage = "O nome deve ter no máximo {1} caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório para o Login!")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        [StringLength(100, ErrorMessage = "Email seve ter no máximo {1} caracteres!")]
        public string Email { get; set; }
    }
}
