using System;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : Base
    {

        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result == null)
                    return false;
                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                // if (item.Id == Guid.Empty)
                // {
                //     item.Id = Guid.NewGuid();
                // }

                item.DataCadastro = DateTime.UtcNow;
                item.DataAtualizacao = null;
                item.Ativo = true;
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
            return item;
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }

        public async Task<T> SelectAsync(int id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }
        }

        public async Task<System.Collections.Generic.IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception ("Error: ", ex);
            }
        }

        public async Task<T> UpdateAsync(int id, T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result == null)
                    return null;

                item.Id = result.Id;
                item.DataAtualizacao = DateTime.UtcNow;
                item.DataCadastro = result.DataCadastro;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Error: ", ex);
            }

            return item;
        }
    }
}
