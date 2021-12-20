using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Parametros.Categoria;
using Api.Domain.DTOs.Parametros.Formato;

namespace Api.Domain.Interfaces.Services.Parametros
{
    public interface ICategoriaService
    {
        Task<CategoriaDTO> Get(int id);
        Task<IEnumerable<CategoriaDTO>> GetAll();
        Task<CategoriaDTO> Post(CategoriaDTOWrite categoria);
        Task<CategoriaDTO> Put(int id, CategoriaDTOWrite categoria);
        Task<bool> Delete(int id);
        Task<bool> Inactivate(int id);
    }
}
