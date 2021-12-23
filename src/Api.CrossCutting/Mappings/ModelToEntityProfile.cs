using Api.Domain.Entities;
using Api.Domain.Models;
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

            CreateMap<Controlador, ControladorModel>()
                .ReverseMap();

            CreateMap<Dado, DadoModel>()
                .ReverseMap();

            CreateMap<DataMapping, DataMappingModel>()
                .ReverseMap();
        }
    }
}
