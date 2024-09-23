using MongoDbPlayground.Data.DTO;
using MongoDbPlayground.Data.Repositories;

namespace MongoDbPlayground.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<IEnumerable<MovieDto>> GetAllMoviesAsync() 
        => await _movieRepository.GetAllMoviesAsync();

    public async Task<MovieDto> GetMovieByIdAsync(string id) 
        => await _movieRepository.GetMovieByIdAsync(id);

    public async Task AddMovieAsync(MovieDto movieDto) 
        => await _movieRepository.AddMovieAsync(movieDto);

    public async Task UpdateMovieAsync(string id, MovieDto movieDto) 
        => await _movieRepository.UpdateMovieAsync(id, movieDto);

    public async Task DeleteMovieAsync(string id) 
        => await _movieRepository.DeleteMovieAsync(id);
}
