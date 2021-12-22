using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Controlador;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class ControladorService : IControladorService
    {
        private IRepository<Controlador> _repository;
        private readonly IMapper _mapper;

        private IControladorRepository _controladorRepository;



        public ControladorService(IRepository<Controlador> repository, IMapper mapper, IControladorRepository controladorRepository)
        {
            _repository = repository;
            _controladorRepository = controladorRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ControladorDTO> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ControladorDTO>(entity) ?? new ControladorDTO();
        }

        public async Task<IEnumerable<ControladorDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ControladorDTO>>(listEntity);
        }

        public async Task<ControladorDTO> Post(ControladorDTOWrite controlador)
        {
            var model = _mapper.Map<ControladorModel>(controlador);

            var entity = _mapper.Map<Controlador>(model);

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ControladorDTO>(result);
        }

        public async Task<ControladorDTO> Put(int id, ControladorDTOWrite controlador)
        {
            var model = _mapper.Map<ControladorModel>(controlador);

            var entity = _mapper.Map<Controlador>(model);

            var result = await _repository.UpdateAsync(id, entity);

            return _mapper.Map<ControladorDTO>(result);
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
