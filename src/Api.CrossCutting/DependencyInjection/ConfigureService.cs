using Api.Domain.Interfaces.Services.Parametros;
using Api.Domain.Interfaces.Services.PerfilService;
using Api.Domain.Interfaces.Services.UsuarioService;
using Api.Service.Services;
using Api.Service.Services.Parametros;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection servicesCollection)
        {
            servicesCollection.AddTransient<IUsuarioService, UsuarioService>();
            servicesCollection.AddTransient<ILoginService, LoginService>();
            servicesCollection.AddTransient<IPerfilService, PerfilService>();
            servicesCollection.AddTransient<IFormatoService, FormatoService>();
        }
    }
}
