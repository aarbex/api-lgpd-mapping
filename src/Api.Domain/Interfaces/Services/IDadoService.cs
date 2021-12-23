using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Dado;

namespace Api.Domain.Interfaces.Services
{
    public interface IDadoService
    {
        Task<DadoDTO> Get(int id);
        Task<IEnumerable<DadoDTO>> GetAll();
        Task<DadoDTO> Post(DadoDTOWrite dado);
        Task<DadoDTO> Put(int id, DadoDTOWrite dado);
        Task<bool> Delete(int id);
        Task<bool> Inactivate(int id);
        Task<IEnumerable<DadoDTO>> GetByDataMappingID(int id);
    }
}
