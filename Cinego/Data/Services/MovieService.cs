

using Cinego.Data.ViewModel;
using Cinego.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Cinego.Data.Services
{
    public class MovieService : IMoviesService
    {

        private readonly CinegoDbContext _context;

        public MovieService(CinegoDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public async Task AddNewMovieAsync(FreshMovie freshMovie)
        {
            var newMovie = new Movie()
            {
                Name = freshMovie.Name,
                Description = freshMovie.Description,
                ImageURL = freshMovie.ImageURL,
                CinemaId = freshMovie.CinemaId,
                StartDate = freshMovie.StartDate,
                FinishDate = freshMovie.FinishDate,
                MoviType = freshMovie.MoviType,
                DirectorId = freshMovie.DirectorId,
            };

            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();

            foreach(var actorId in freshMovie.ActorsIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId,
                };
                await _context.Actors_Movies.AddAsync(newActorMovie);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var res = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
            _context.Movies.Remove(res);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            var allMovie = await _context.Movies.Include(m => m.Cinema).ToListAsync();
            allMovie.Reverse();
            return allMovie;
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            var res = await _context.Movies
                .Include(m => m.Cinema)
                .Include(m => m.Director)
                .Include(m => m.Actors_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);
            return res;
        }

        public async Task<MovieDropdowns> GetMovieDropdownsValues()
        {
            var allDropdownsData = new MovieDropdowns()
            {
                Actors = await _context.Actors.OrderBy(a => a.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(a => a.Name).ToListAsync(),
                Directors = await _context.Directors.OrderBy(a => a.FullName).ToListAsync()
            };
            return allDropdownsData;
        }

        public async Task<Movie> UpdateAsync(int id,Movie updatedMovie)
        {
            _context.Update(updatedMovie);
            await _context.SaveChangesAsync();
            return updatedMovie;
        }

       


     
        
    }
}
