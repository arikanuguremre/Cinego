using Cinego.Data.ViewModel;
using Cinego.Models;

namespace Cinego.Data.Services
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie> GetByIdAsync(int id);
        Task AddAsync(Movie movie);
        Task<Movie> UpdateAsync(int id, Movie updatedMovie);
        Task DeleteAsync(int id);
        Task<MovieDropdowns> GetMovieDropdownsValues();
        Task AddNewMovieAsync(FreshMovie freshMovie);
    }
}
    