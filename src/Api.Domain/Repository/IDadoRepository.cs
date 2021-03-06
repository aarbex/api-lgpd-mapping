using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    public interface IDadoRepository : IRepository<Dado>
    {
        public Task<ICollection<Dado>> GetByDataMappingID(int id);
    }
}
