using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.DTOs.Dado;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class DadoImplementation : BaseRepository<Dado>, IDadoRepository
    {
        private DbSet<Dado> _dataset;

        public DadoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Dado>();
        }

        public async Task<ICollection<Dado>> GetByDataMappingID(int id)
        {
            var dados = await SelectAsync();

            return dados.Where(d => d.DataMappingID.Equals(id)).ToList();
        }
    }
}
