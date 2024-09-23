using MongoDbPlayground.Data.DTO;
using MongoDbPlayground.Data.MongoDb.Entities;

namespace MongoDbPlayground.Data.MongoDb;

public static class DtoToMongoMapper
{
    public static Movie ToMovie(this MovieDto dto)
    {
        if (dto == null) return null;

        return new Movie
        {
            Id = dto.Id,
            Plot = dto.Plot,
            Genres = dto.Genres,
            Runtime = dto.Runtime,
            Cast = dto.Cast,
            Poster = dto.Poster,
            Title = dto.Title,
            FullPlot = dto.FullPlot,
            Languages = dto.Languages,
            Released = dto.Released,
            Directors = dto.Directors,
            Rated = dto.Rated,
            Awards = dto.Awards?.ToAwards(),
            LastUpdated = dto.LastUpdated,
            Year = dto.Year,
            Imdb = dto.Imdb?.ToImdb(),
            Countries = dto.Countries,
            Type = dto.Type,
            Tomatoes = dto.Tomatoes?.ToTomatoes(),
            NumMflixComments = dto.NumMflixComments
        };
    }

    public static MovieDto ToMovieDto(this Movie movie)
    {
        if (movie == null) return null;

        return new MovieDto
        {
            Id = movie.Id,
            Plot = movie.Plot,
            Genres = movie.Genres,
            Runtime = movie.Runtime,
            Cast = movie.Cast,
            Poster = movie.Poster,
            Title = movie.Title,
            FullPlot = movie.FullPlot,
            Languages = movie.Languages,
            Released = movie.Released,
            Directors = movie.Directors,
            Rated = movie.Rated,
            Awards = movie.Awards?.ToAwardsDto(),
            LastUpdated = movie.LastUpdated,
            Year = movie.Year,
            Imdb = movie.Imdb?.ToImdbDto(),
            Countries = movie.Countries,
            Type = movie.Type,
            Tomatoes = movie.Tomatoes?.ToTomatoesDto(),
            NumMflixComments = movie.NumMflixComments
        };
    }

    public static Awards ToAwards(this AwardsDto dto)
    {
        if (dto == null) return null;

        return new Awards
        {
            Wins = dto.Wins,
            Nominations = dto.Nominations,
            Text = dto.Text
        };
    }

    public static AwardsDto ToAwardsDto(this Awards awards)
    {
        if (awards == null) return null;

        return new AwardsDto
        {
            Wins = awards.Wins,
            Nominations = awards.Nominations,
            Text = awards.Text
        };
    }

    public static Imdb ToImdb(this ImdbDto dto)
    {
        if (dto == null) return null;

        return new Imdb
        {
            Rating = dto.Rating,
            Votes = dto.Votes,
            Id = dto.Id
        };
    }

    public static ImdbDto ToImdbDto(this Imdb imdb)
    {
        if (imdb == null) return null;

        return new ImdbDto
        {
            Rating = imdb.Rating,
            Votes = imdb.Votes,
            Id = imdb.Id
        };
    }

    public static Tomatoes ToTomatoes(this TomatoesDto dto)
    {
        if (dto == null) return null;

        return new Tomatoes
        {
            Viewer = dto.Viewer?.ToViewer(),
            Fresh = dto.Fresh,
            Critic = dto.Critic?.ToCritic(),
            Rotten = dto.Rotten,
            LastUpdated = dto.LastUpdated
        };
    }

    public static TomatoesDto ToTomatoesDto(this Tomatoes tomatoes)
    {
        if (tomatoes == null) return null;

        return new TomatoesDto
        {
            Viewer = tomatoes.Viewer?.ToViewerDto(),
            Fresh = tomatoes.Fresh,
            Critic = tomatoes.Critic?.ToCriticDto(),
            Rotten = tomatoes.Rotten,
            LastUpdated = tomatoes.LastUpdated
        };
    }

    public static Viewer ToViewer(this ViewerDto dto)
    {
        if (dto == null) return null;

        return new Viewer
        {
            Rating = dto.Rating,
            NumReviews = dto.NumReviews,
            Meter = dto.Meter
        };
    }

    public static ViewerDto ToViewerDto(this Viewer viewer)
    {
        if (viewer == null) return null;

        return new ViewerDto
        {
            Rating = viewer.Rating,
            NumReviews = viewer.NumReviews,
            Meter = viewer.Meter
        };
    }

    public static Critic ToCritic(this CriticDto dto)
    {
        if (dto == null) return null;

        return new Critic
        {
            Rating = dto.Rating,
            NumReviews = dto.NumReviews,
            Meter = dto.Meter
        };
    }

    public static CriticDto ToCriticDto(this Critic critic)
    {
        if (critic == null) return null;

        return new CriticDto
        {
            Rating = critic.Rating,
            NumReviews = critic.NumReviews,
            Meter = critic.Meter
        };
    }
}
