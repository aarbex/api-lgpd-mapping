using Api.Data.Mapping;
using Api.Data.Mapping.Parametros;
using Api.Domain.Entities;
using Api.Domain.Entities.Parametros;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext: DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Perfil> Formato { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Perfil>(new PerfilMap().Configure);
            modelBuilder.Entity<Formato>(new FormatoMap().Configure);
        }
    }

}
