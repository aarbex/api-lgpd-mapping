using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email é um campo obrigatório para o Login!")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é um campo obrigatório para o Login!")]
        public string Senha { get; set; }
    }
}
