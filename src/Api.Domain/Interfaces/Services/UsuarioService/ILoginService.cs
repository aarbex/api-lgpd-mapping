using System.Threading.Tasks;
using Api.Domain.DTOs;

namespace Api.Domain.Interfaces.Services.UsuarioService
{
    public interface ILoginService
    {
        Task<object> FindByEmail(LoginDTO login);
    }
}
