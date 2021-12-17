using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Perfil;

namespace Api.Domain.Interfaces.Services.PerfilService
{
    public interface IPerfilService
    {
        Task<PerfilDTO> Get(int id);
        Task<IEnumerable<PerfilDTO>> GetAll();
        Task<PerfilDTO> Post(PerfilDTOWrite Perfil);
        Task<PerfilDTO> Put(int id, PerfilDTOWrite Perfil);
        Task<bool> Delete(int id);
        Task<bool> Inactivate(int id);
    }
}
