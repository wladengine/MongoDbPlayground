namespace MongoDbPlayground.Data.DTO;

public class TomatoesDto
{
    public ViewerDto Viewer { get; set; }
    public int Fresh { get; set; }
    public CriticDto Critic { get; set; }
    public int Rotten { get; set; }
    public DateTime LastUpdated { get; set; }
}
