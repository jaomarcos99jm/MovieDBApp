using MovieDBApp.Models;
using System.Threading.Tasks;

namespace MovieDBApp.Services
{
    public interface IMovieDBService
    {
        Task<SearchResponse<Movie>> GetUpcomingMoviesAsync(int pageNumber = 1, string language = "en");
        Task<Movie> FindByIdAsync(int movieId, string language = "en");
    }
}
