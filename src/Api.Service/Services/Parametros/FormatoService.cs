using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Parametros.Formato;
using Api.Domain.Entities.Parametros;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Parametros;
using Api.Domain.Models.Parametros;
using Api.Domain.Repository.Parametros;
using AutoMapper;

namespace Api.Service.Services.Parametros
{
    public class FormatoService : IFormatoService
    {
        private IRepository<Formato> _repository;

        private readonly IMapper _mapper;

        private IFormatoRepository _formatoRepository;

        public FormatoService(IRepository<Formato> repository, IMapper mapper, IFormatoRepository formatoRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _formatoRepository = formatoRepository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<FormatoDTO> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<FormatoDTO>(entity) ?? new FormatoDTO();
        }

        public async Task<IEnumerable<FormatoDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<FormatoDTO>>(listEntity);
        }

        public async Task<bool> Inactivate(int id)
        {
            var entity = await _repository.SelectAsync(id);

            if (entity != null)
            {
                return await _repository.InactivateAsync(id);
            }
            else
            {
                return false;
            }
        }

        public async Task<FormatoDTO> Post(FormatoDTOWrite formato)
        {
            var model = _mapper.Map<FormatoModel>(formato);

            var entity = _mapper.Map<Formato>(model);

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<FormatoDTO>(result);

        }

        public async Task<FormatoDTO> Put(int id, FormatoDTOWrite formato)
        {
            var model = _mapper.Map<FormatoModel>(formato);

            var entity = _mapper.Map<Formato>(model);

            var result = await _repository.UpdateAsync(id, entity);

            return _mapper.Map<FormatoDTO>(result);
        }
    }
}
