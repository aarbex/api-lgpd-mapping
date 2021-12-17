using System.Threading.Tasks;
using Api.Domain.DTOs.Usuario;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> FindByEmail(string email);

        Task<bool> SetPassword(int id, UsuarioDTOPasswordUpdate usuario);
        Task<bool> ResetPassword(int id);

    }
}
