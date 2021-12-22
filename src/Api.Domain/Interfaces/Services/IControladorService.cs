using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Controlador;

namespace Api.Domain.Interfaces.Services
{
    public interface IControladorService
    {
        Task<ControladorDTO> Get(int id);
        Task<IEnumerable<ControladorDTO>> GetAll();
        Task<ControladorDTO> Post(ControladorDTOWrite controlador);
        Task<ControladorDTO> Put(int id, ControladorDTOWrite controlador);
        Task<bool> Delete(int id);
        Task<bool> Inactivate(int id);
    }
}
