using Api.Domain.DTOs.Parametros.Formato;
using Api.Domain.DTOs.Perfil;
using Api.Domain.DTOs.Usuario;
using Api.Domain.Entities;
using Api.Domain.Entities.Parametros;
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

            CreateMap<FormatoDTO, Formato>()
            .ReverseMap();

            CreateMap<FormatoDTONested, Formato>()
            .ReverseMap();
        }
    }
}
