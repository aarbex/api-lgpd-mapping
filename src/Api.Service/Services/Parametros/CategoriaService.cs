using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.DTOs.Parametros.Categoria;
using Api.Domain.DTOs.Parametros.Formato;
using Api.Domain.Entities.Parametros;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Parametros;
using Api.Domain.Models.Parametros;
using Api.Domain.Repository.Parametros;
using AutoMapper;

namespace Api.Service.Services.Parametros
{
    public class CategoriaService : ICategoriaService
    {
        private IRepository<Categoria> _repository;

        private readonly IMapper _mapper;

        private ICategoriaRepository _categoriaRepository;

        public CategoriaService(IRepository<Categoria> repository, IMapper mapper, ICategoriaRepository categoriaRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _categoriaRepository = categoriaRepository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CategoriaDTO> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<CategoriaDTO>(entity) ?? new CategoriaDTO();
        }

        public async Task<IEnumerable<CategoriaDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<CategoriaDTO>>(listEntity);
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

        public async Task<CategoriaDTO> Post(CategoriaDTOWrite categoria)
        {
            var model = _mapper.Map<CategoriaModel>(categoria);

            var entity = _mapper.Map<Categoria>(model);

            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<CategoriaDTO>(result);

        }

        public async Task<CategoriaDTO> Put(int id, CategoriaDTOWrite categoria)
        {
            var model = _mapper.Map<CategoriaModel>(categoria);

            var entity = _mapper.Map<Categoria>(model);

            var result = await _repository.UpdateAsync(id, entity);

            return _mapper.Map<CategoriaDTO>(result);
        }
    }
}
