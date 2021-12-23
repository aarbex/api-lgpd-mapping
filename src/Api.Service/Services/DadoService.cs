using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.DTOs.Dado;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class DadoService : IDadoService
    {
        private IRepository<Dado> _repository;
        private readonly IMapper _mapper;

        private IDadoRepository _dadoRepository;



        public DadoService(IRepository<Dado> repository, IMapper mapper, IDadoRepository dadoRepository)
        {
            _repository = repository;
            _dadoRepository = dadoRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<DadoDTO> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<DadoDTO>(entity) ?? new DadoDTO();
        }

        public async Task<IEnumerable<DadoDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<DadoDTO>>(listEntity);
        }

        public async Task<DadoDTO> Post(DadoDTOWrite dado)
        {
            var model = _mapper.Map<DadoModel>(dado);

            var entity = _mapper.Map<Dado>(model);

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<DadoDTO>(result);
        }

        public async Task<DadoDTO> Put(int id, DadoDTOWrite dado)
        {
            var model = _mapper.Map<DadoModel>(dado);

            var entity = _mapper.Map<Dado>(model);

            var result = await _repository.UpdateAsync(id, entity);

            return _mapper.Map<DadoDTO>(result);
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


        public async Task<IEnumerable<DadoDTO>> GetByDataMappingID(int id)
        {
            var dados = await _dadoRepository.GetByDataMappingID(id);

            return _mapper.Map<IEnumerable<DadoDTO>>(dados);
        }
    }
}
