using MongoDbPlayground.Data.DTO;

namespace MongoDbPlayground.Data.Repositories;

public interface IMovieRepository
{
    Task<IEnumerable<MovieDto>> GetAllMoviesAsync();
    Task<MovieDto> GetMovieByIdAsync(string id);
    Task AddMovieAsync(MovieDto movieDto);
    Task UpdateMovieAsync(string id, MovieDto movieDto);
    Task DeleteMovieAsync(string id);
}
