using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class ControladorImplementation : BaseRepository<Controlador>, IControladorRepository
    {
        private DbSet<Controlador> _dataset;

        public ControladorImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Controlador>();
        }
    }
}
