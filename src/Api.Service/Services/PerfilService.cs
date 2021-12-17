using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Perfil;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.PerfilService;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class PerfilService : IPerfilService
    {
        private IRepository<Perfil> _repository;
        private readonly IMapper _mapper;

        private IPerfilRepository _perfilRepository;



        public PerfilService(IRepository<Perfil> repository, IMapper mapper, IPerfilRepository perfilRepository)
        {
            _repository = repository;
            _perfilRepository = perfilRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<PerfilDTO> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<PerfilDTO>(entity) ?? new PerfilDTO();
        }

        public async Task<IEnumerable<PerfilDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<PerfilDTO>>(listEntity);
        }

        public async Task<PerfilDTO> Post(PerfilDTOWrite perfil)
        {
            var model = _mapper.Map<PerfilModel>(perfil);

            var entity = _mapper.Map<Perfil>(model);

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<PerfilDTO>(result);
        }

        public async Task<PerfilDTO> Put(int id, PerfilDTOWrite perfil)
        {
            var model = _mapper.Map<PerfilModel>(perfil);

            var entity = _mapper.Map<Perfil>(model);

            var result = await _repository.UpdateAsync(id, entity);

            return _mapper.Map<PerfilDTO>(result);
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
    }
}
