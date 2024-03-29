﻿namespace Cinego.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class, IEntityBase
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T>GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task<T> UpdateAsync(int id,T entity);
        Task DeleteAsync(int id);

    }
}
  