using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.DTOs.Dado;
using Api.Domain.DTOs.DataMapping;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class DataMappingImplementation : BaseRepository<DataMapping>, IDataMappingRepository
    {
        private DbSet<DataMapping> _dataset;

        private DbSet<Dado> _dadoDataset;

        private IDadoService _dadoService;

        public DataMappingImplementation(IDadoService dadoService, MyContext context) : base(context)
        {
            _dataset = context.Set<DataMapping>();
            _dadoDataset = context.Set<Dado>();
            _dadoService = dadoService;
        }

       
    }
}
