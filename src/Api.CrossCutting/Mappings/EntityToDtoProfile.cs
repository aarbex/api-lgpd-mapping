using Api.Domain.DTOs.Controlador;
using Api.Domain.DTOs.Perfil;
using Api.Domain.DTOs.Usuario;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UsuarioDTO, Usuario>()
            .ReverseMap();

            CreateMap<UsuarioDTOCreateResult, Usuario>()
            .ReverseMap();

            CreateMap<UsuarioDTOUpdateResult, Usuario>()
            .ReverseMap();

            CreateMap<PerfilDTO, Perfil>()
            .ReverseMap();

            CreateMap<PerfilDTONested, Perfil>()
            .ReverseMap();

            CreateMap<ControladorDTO, Controlador>()
            .ReverseMap();
        }
    }
}
