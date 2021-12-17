using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Usuario;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.UsuarioService
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO> Get(int id);
        Task<IEnumerable<UsuarioDTO>> GetAll();
        Task<UsuarioDTOCreateResult> Post(UsuarioDTOCreate usuario);
        Task<UsuarioDTOUpdateResult> Put(int id, UsuarioDTOUpdate usuario);
        Task<bool> Delete(int id);
        Task<bool> UpdatePassword(int id, UsuarioDTOPasswordUpdate usuario);
        Task<bool> ResetPassword(int id);
    }
}

