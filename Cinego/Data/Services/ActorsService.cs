using Cinego.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinego.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly CinegoDbContext _context;

        public ActorsService(CinegoDbContext context)
        {
            _context = context;
        }

        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync (Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

       

        public async Task DeleteAsync(int id)
        {
           var res = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
             _context.Actors.Remove(res);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            result.Reverse();
            return result;
        }

       

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
           var res = await _context.Actors.FirstOrDefaultAsync(n=>n.Id == id);
            return res;
        }

        public Actor update(int id, Actor updatedActor)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> UpdateAsync(int id, Actor updatedActor)
        {
            _context.Update(updatedActor);
            await _context.SaveChangesAsync();
            return updatedActor;
        }
    }
}
