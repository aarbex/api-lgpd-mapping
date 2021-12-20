using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Parametros.Formato;

namespace Api.Domain.Interfaces.Services.Parametros
{
    public interface IFormatoService
    {
        Task<FormatoDTO> Get(int id);
        Task<IEnumerable<FormatoDTO>> GetAll();
        Task<FormatoDTO> Post(FormatoDTOWrite formato);
        Task<FormatoDTO> Put(int id, FormatoDTOWrite formato);
        Task<bool> Delete(int id);
        Task<bool> Inactivate(int id);
    }
}
