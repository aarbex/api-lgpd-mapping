using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Parametros;
using Api.Domain.Repository.Parametros;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations.Parametros
{
    public class CategoriaImplementation : BaseRepository<Categoria>, ICategoriaRepository
    {
        private DbSet<Categoria> _dataset;

        public CategoriaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Categoria>();
        }
    }
}
