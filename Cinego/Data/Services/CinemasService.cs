using Cinego.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Cinego.Data.Services
{
    public class CinemasService : ICinemasService
    {
        private readonly CinegoDbContext _context;

        public CinemasService(CinegoDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Cinema cinema)
        {
            await _context.Cinemas.AddAsync(cinema);
            await _context.SaveChangesAsync();
        }

        public Task AddAsync(Director director)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var res = await _context.Cinemas.FirstOrDefaultAsync(x => x.Id == id);
            _context.Cinemas.Remove(res);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cinema>> GetAllAsync()
        {
            var result = await _context.Cinemas.ToListAsync();
           
            return result;
        }

        public async Task<Cinema> GetByIdAsync(int id)
        {
            var res = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
            return res;
        }

        public async Task<Cinema> UpdateAsync(int id, Cinema updatedCinema)
        {
            _context.Update(updatedCinema);
            await _context.SaveChangesAsync();
            return updatedCinema;
        }
    }
}
