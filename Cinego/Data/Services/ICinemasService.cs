using Cinego.Models;

namespace Cinego.Data.Services
{
    public interface ICinemasService
    {
        Task<IEnumerable<Cinema>> GetAllAsync();
        Task<Cinema> GetByIdAsync(int id);
        Task AddAsync(Director director);
        Task AddAsync(Cinema cinema);
        Task<Cinema> UpdateAsync(int id, Cinema updatedCinema);
        Task DeleteAsync(int id);

    }
}
