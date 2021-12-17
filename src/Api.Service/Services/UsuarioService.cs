using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Usuario;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.UsuarioService;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IRepository<Usuario> _repository;
        private IRepository<Perfil> _perfilRepository;
        private readonly IMapper _mapper;

        private IUsuarioRepository _usuarioRepository;

        public UsuarioService(IRepository<Usuario> repository, IRepository<Perfil> perfilRepository, IMapper mapper, IUsuarioRepository usuarioRepository)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _perfilRepository = perfilRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UsuarioDTO> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            var perfil = await _perfilRepository.SelectAsync(entity.PerfilID);
            entity.Perfil.Nome = perfil.Nome;
            entity.Perfil.Ativo = perfil.Ativo;
            entity.Perfil.DataCadastro = perfil.DataCadastro;
            entity.Perfil.DataAtualizacao = perfil.DataAtualizacao;
            return _mapper.Map<UsuarioDTO>(entity) ?? new UsuarioDTO();
        }

        public async Task<IEnumerable<UsuarioDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            foreach(var entity in listEntity){
                var perfil = await _perfilRepository.SelectAsync(entity.PerfilID);
                entity.Perfil.Nome = perfil.Nome;
                entity.Perfil.Ativo = perfil.Ativo;
                entity.Perfil.DataCadastro = perfil.DataCadastro;
                entity.Perfil.DataAtualizacao = perfil.DataAtualizacao;
            };
            return _mapper.Map<IEnumerable<UsuarioDTO>>(listEntity);
        }

        public async Task<UsuarioDTOCreateResult> Post(UsuarioDTOCreate usuario)
        {
            var model = _mapper.Map<UsuarioModel>(usuario);

            var entity = _mapper.Map<Usuario>(model);

            entity.Senha = Criptografia.Cripto(entity.Email);

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UsuarioDTOCreateResult>(result);
        }

        public async Task<UsuarioDTOUpdateResult> Put(int id, UsuarioDTOUpdate usuario)
        {
            var model = _mapper.Map<UsuarioModel>(usuario);

            var entity = _mapper.Map<Usuario>(model);

            var entidade = await _repository.SelectAsync(id);

            entity.Senha = entidade.Senha;

            var result = await _repository.UpdateAsync(id, entity);

            return _mapper.Map<UsuarioDTOUpdateResult>(result);
        }

        public async Task<bool> Inactivate(int id)
        {
            var entidade = await _repository.SelectAsync(id);


            if (entidade != null)
            {
                return await _repository.InactivateAsync(id);
            }
            else
            {
                return false;
            }

        }


        public async Task<bool> UpdatePassword(int id, UsuarioDTOPasswordUpdate usuario)
        {

            var entidade = await _repository.SelectAsync(id);


            if(entidade.Senha == usuario.Senha)
            {
               return await _usuarioRepository.SetPassword(id, usuario);
            }
            else{
                return false;
            }

        }

        public async Task<bool> ResetPassword(int id)
        {

            var entidade = await _repository.SelectAsync(id);


            if (entidade != null)
            {
                return await _usuarioRepository.ResetPassword(id);
            }
            else
            {
                return false;
            }

        }
    }
}
