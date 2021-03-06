using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext: DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Controlador> Controlador { get; set; }
        public DbSet<Dado> Dado { get; set; }
        public DbSet<DataMapping> DataMapping { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Perfil>(new PerfilMap().Configure);
            modelBuilder.Entity<Controlador>(new ControladorMap().Configure);
            modelBuilder.Entity<Dado>(new DadoMap().Configure);
            modelBuilder.Entity<DataMapping>(new DataMappingMap().Configure);
        }
    }

}
