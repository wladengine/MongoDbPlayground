using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDbPlayground.Data.DTO;
using MongoDbPlayground.Data.MongoDb.Entities;
using MongoDbPlayground.Data.Repositories;

namespace MongoDbPlayground.Data.MongoDb;

public class MongoMovieRepository : IMovieRepository
{
    private readonly IMongoCollection<Movie> _movies;
    private readonly IMongoCollection<BsonDocument> _moviesCollection;

    public MongoMovieRepository(MongoDbSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);
        _movies = database.GetCollection<Movie>("movies");
        _moviesCollection = database.GetCollection<BsonDocument>("movies");
    }

    public async Task<IEnumerable<MovieDto>> GetAllMoviesAsync()
    {
        var collection = await _movies.Find(movie => true)
            .ToListAsync();
        return collection.Select(x => x.ToMovieDto());
    }

    public async Task<MovieDto> GetMovieByIdAsync(string id)
    {
        var entity = await _movies.Find<Movie>(movie => movie.Id == id).FirstOrDefaultAsync();
        return entity.ToMovieDto();
    }

    public async Task AddMovieAsync(MovieDto movieDto) 
        => await _movies.InsertOneAsync(movieDto.ToMovie());

    public async Task UpdateMovieAsync(string id, MovieDto movieDto) 
        => await _movies.ReplaceOneAsync(m => m.Id == id, movieDto.ToMovie());

    public async Task DeleteMovieAsync(string id) 
        => await _movies.DeleteOneAsync(m => m.Id == id);
}
