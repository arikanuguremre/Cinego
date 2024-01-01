using Cinego.Models;

namespace Cinego.Data.Services
{
    public interface IActorsService
    {
       Task <IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor updatedActor);
        Task DeleteAsync(int id);
    }
}
