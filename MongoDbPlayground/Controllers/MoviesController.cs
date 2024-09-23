using Microsoft.AspNetCore.Mvc;
using MongoDbPlayground.Data.DTO;
using MongoDbPlayground.Services;

namespace MongoDbPlayground.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    // GET: api/Movies
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieDto>>> GetMovies()
    {
        var movies = await _movieService.GetAllMoviesAsync();
        return Ok(movies);
    }

    // GET: api/Movies/5
    [HttpGet("{id}", Name = "GetMovie")]
    public async Task<ActionResult<MovieDto>> GetMovie(string id)
    {
        var movie = await _movieService.GetMovieByIdAsync(id);
        if (movie == null)
        {
            return NotFound();
        }
        return Ok(movie);
    }

    // POST: api/Movies
    [HttpPost]
    public async Task<ActionResult<MovieDto>> PostMovie([FromBody] MovieDto movieDto)
    {
        await _movieService.AddMovieAsync(movieDto);
        return CreatedAtRoute("GetMovie", new { id = movieDto.Id }, movieDto);
    }

    // PUT: api/Movies/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutMovie(string id, [FromBody] MovieDto movieDto)
    {
        var existingMovie = await _movieService.GetMovieByIdAsync(id);
        if (existingMovie == null)
        {
            return NotFound();
        }
        await _movieService.UpdateMovieAsync(id, movieDto);
        return NoContent();
    }

    // DELETE: api/Movies/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(string id)
    {
        var existingMovie = await _movieService.GetMovieByIdAsync(id);
        if (existingMovie == null)
        {
            return NotFound();
        }
        await _movieService.DeleteMovieAsync(id);
        return NoContent();
    }
}
