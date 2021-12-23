using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.DataMapping;

namespace Api.Domain.Interfaces.Services
{
    public interface IDataMappingService
    {
        Task<DataMappingDTO> Get(int id);
        Task<IEnumerable<DataMappingDTO>> GetAll();
        Task<DataMappingDTO> Post(DataMappingDTOWrite dataMapping);
        Task<DataMappingDTO> Put(int id, DataMappingDTOWrite dataMapping);
        Task<bool> Delete(int id);
        Task<bool> Inactivate(int id);
        Task<bool> GetDados(DataMappingDTO dataMapping);
    }
}
