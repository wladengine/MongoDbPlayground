using MongoDbPlayground.Data.DTO;

namespace MongoDbPlayground.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDto>> GetAllMoviesAsync();
        Task<MovieDto> GetMovieByIdAsync(string id);
        Task AddMovieAsync(MovieDto movieDto);
        Task UpdateMovieAsync(string id, MovieDto movieDto);
        Task DeleteMovieAsync(string id);
    }
}
