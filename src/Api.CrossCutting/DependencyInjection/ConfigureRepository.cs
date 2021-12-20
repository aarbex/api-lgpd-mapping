using System;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Implementations.Parametros;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Api.Domain.Repository.Parametros;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUsuarioRepository, UsuarioImplementation>();
            serviceCollection.AddScoped<IPerfilRepository, PerfilImplementation>();
            serviceCollection.AddScoped<IFormatoRepository, FormatoImplementation>();
            serviceCollection.AddScoped<ICategoriaRepository, CategoriaImplementation>();

            if (Environment.GetEnvironmentVariable("DATABASE").ToLower() == "SQLSERVER".ToLower())
            {
                serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer(Environment.GetEnvironmentVariable("DB_CONNECTION"))
                );
            }
        }
    }
}
