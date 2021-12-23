using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Dado;
using Api.Domain.DTOs.DataMapping;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class DataMappingService : IDataMappingService
    {
        private IRepository<DataMapping> _repository;
        private IDadoRepository _dadoRepository;
        private readonly IMapper _mapper;

        private IDataMappingRepository _dataMappingRepository;



        public DataMappingService(IRepository<DataMapping> repository, IDadoRepository dadoRepository, IMapper mapper, IDataMappingRepository dataMappingRepository)
        {
            _repository = repository;
            _dadoRepository = dadoRepository;
            _dataMappingRepository = dataMappingRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<DataMappingDTO> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);

            var listDados = await _dadoRepository.GetByDataMappingID(entity.Id);

            entity.Dados = listDados;

            return _mapper.Map<DataMappingDTO>(entity) ?? new DataMappingDTO();
        }

        public async Task<IEnumerable<DataMappingDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();

            foreach (var entity in listEntity)
            {
                var listDados = await _dadoRepository.GetByDataMappingID(entity.Id);

                entity.Dados = listDados;
            };

            return _mapper.Map<IEnumerable<DataMappingDTO>>(listEntity);
        }

        public async Task<DataMappingDTO> Post(DataMappingDTOWrite dataMapping)
        {
            var model = _mapper.Map<DataMappingModel>(dataMapping);

            var entity = _mapper.Map<DataMapping>(model);

            var listDados = entity.Dados;

            foreach (var dado in listDados)
            {
                dado.Ativo = true;
                dado.DataMappingID = entity.Id;
                dado.DataCadastro = DateTime.UtcNow;
            }

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<DataMappingDTO>(result);
        }

        public async Task<DataMappingDTO> Put(int id, DataMappingDTOWrite dataMapping)
        {
            var model = _mapper.Map<DataMappingModel>(dataMapping);

            var entity = _mapper.Map<DataMapping>(model);

            var dados = entity.Dados;

            foreach (var dado in dados){
                if(dado.Id == 0){
                    await _dadoRepository.InsertAsync(dado);
                }
            }

            entity.Dados.Clear();

            var result = await _repository.UpdateAsync(id, entity);

            var listDados = await _dadoRepository.GetByDataMappingID(entity.Id);

            result.Dados = listDados;

            return _mapper.Map<DataMappingDTO>(result);
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

        public Task<bool> GetDados(DataMappingDTO dataMapping)
        {
            throw new System.NotImplementedException();
        }
    }
}
