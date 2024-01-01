using Cinego.Models;

namespace Cinego.Data.Services
{
    public interface IDirectorsService
    {
        Task<IEnumerable<Director>> GetAllAsync();
        Task<Director> GetByIdAsync(int id);
        Task AddAsync(Director  director);
        Task<Director> UpdateAsync(int id, Director updatedDirector);
        Task DeleteAsync(int id);
    }
}
