using Api.Domain.Entities;
using Api.Domain.Entities.Parametros;
using Api.Domain.Models;
using Api.Domain.Models.Parametros;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<Usuario, UsuarioModel>()
                .ReverseMap();

            CreateMap<Perfil, PerfilModel>()
                .ReverseMap();

            CreateMap<Formato, FormatoModel>()
                .ReverseMap();
        }
    }
}
