using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class PerfilImplementation : BaseRepository<Perfil>, IPerfilRepository
    {
        private DbSet<Perfil> _dataset;

        public PerfilImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Perfil>();
        }
    }
}
