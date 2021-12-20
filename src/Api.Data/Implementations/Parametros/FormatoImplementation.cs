using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Parametros;
using Api.Domain.Repository.Parametros;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations.Parametros
{
    public class FormatoImplementation : BaseRepository<Formato>, IFormatoRepository
    {
        private DbSet<Formato> _dataset;

        public FormatoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Formato>();
        }
    }
}
