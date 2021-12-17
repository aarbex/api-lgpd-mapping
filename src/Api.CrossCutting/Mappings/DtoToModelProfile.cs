using Api.Domain.DTOs.Usuario;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UsuarioModel, UsuarioDTO>()
            .ReverseMap();
            CreateMap<UsuarioModel, UsuarioDTOCreate>()
            .ReverseMap();
            CreateMap<UsuarioModel, UsuarioDTOUpdate>()
            .ReverseMap();
            CreateMap<UsuarioModel, UsuarioDTOPasswordUpdate>()
            .ReverseMap();
        }
    }
}
