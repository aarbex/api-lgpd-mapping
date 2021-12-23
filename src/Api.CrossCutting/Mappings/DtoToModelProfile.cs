using Api.Domain.DTOs.Controlador;
using Api.Domain.DTOs.Dado;
using Api.Domain.DTOs.DataMapping;
using Api.Domain.DTOs.Perfil;
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
            CreateMap<PerfilModel, PerfilDTO>()
            .ReverseMap();
            CreateMap<PerfilModel, PerfilDTOWrite>()
            .ReverseMap();
            CreateMap<PerfilModel, PerfilDTONested>()
            .ReverseMap();
            CreateMap<ControladorModel, ControladorDTO>()
            .ReverseMap();
            CreateMap<ControladorModel, ControladorDTOWrite>()
            .ReverseMap();
            CreateMap<DataMappingModel, DataMappingDTO>()
            .ReverseMap();
            CreateMap<DataMappingModel, DataMappingDTOWrite>()
            .ReverseMap();
            CreateMap<DadoModel, DadoDTO>()
            .ReverseMap();
            CreateMap<DadoModel, DadoDTOWrite>()
            .ReverseMap();
            CreateMap<DadoModel, DadoDTONested>()
            .ReverseMap();
        }
    }
}
