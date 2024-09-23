using Microsoft.Extensions.Options;
using MongoDbPlayground.Data.MongoDb;
using MongoDbPlayground.Data.Repositories;
using MongoDbPlayground.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();

// Add services to the container.

builder.Services.AddControllers();

builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection(nameof(MongoDbSettings)));

builder.Services.AddSingleton<IMovieRepository, MongoMovieRepository>(sp =>
{
    var settings = sp.GetService<IOptions<MongoDbSettings>>()!;
    return new MongoMovieRepository(settings.Value);
});
builder.Services.AddSingleton<IMovieService, MovieService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
