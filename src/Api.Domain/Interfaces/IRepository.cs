using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{
    public interface IRepository<T> where T:Base
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(int id, T item);
        Task<bool> DeleteAsync(int id);
        Task<bool> InactivateAsync(int id);
        Task<T> SelectAsync(int id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(int id);

    }
}
