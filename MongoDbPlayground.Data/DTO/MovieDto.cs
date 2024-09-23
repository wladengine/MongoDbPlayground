namespace MongoDbPlayground.Data.DTO;

public class MovieDto
{
    public string Id { get; set; }
    public string Plot { get; set; }
    public List<string> Genres { get; set; }
    public int Runtime { get; set; }
    public List<string> Cast { get; set; }
    public string Poster { get; set; }
    public string Title { get; set; }
    public string FullPlot { get; set; }
    public List<string> Languages { get; set; }
    public DateTime Released { get; set; }
    public List<string> Directors { get; set; }
    public string Rated { get; set; }
    public AwardsDto Awards { get; set; }
    public string LastUpdated { get; set; }
    public int? Year { get; set; }
    public ImdbDto Imdb { get; set; }
    public List<string> Countries { get; set; }
    public string Type { get; set; }
    public TomatoesDto Tomatoes { get; set; }
    public int NumMflixComments { get; set; }
}