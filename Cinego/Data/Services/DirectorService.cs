using Cinego.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinego.Data.Services
{
    public class DirectorService : IDirectorsService
    {
        private readonly CinegoDbContext _context;

        public DirectorService(CinegoDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Director director)
        {
            await _context.Directors.AddAsync(director);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var res = await _context.Directors.FirstOrDefaultAsync(x => x.Id == id);
            _context.Directors.Remove(res);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Director>> GetAllAsync()
        {
            var result = await _context.Directors.ToListAsync();
            result.Reverse();
            return result;
        }

        public async Task<Director> GetByIdAsync(int id)
        {
            var res = await _context.Directors.FirstOrDefaultAsync(n => n.Id == id);
            return res;
        }

        public async Task<Director> UpdateAsync(int id, Director updatedDirector)
        {
            _context.Update(updatedDirector);
            await _context.SaveChangesAsync();
            return updatedDirector;
        }

      
    }
}
