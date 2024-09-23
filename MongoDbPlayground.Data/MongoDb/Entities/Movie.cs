using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDbPlayground.FX.MongoDb.Bson.Serialization;

namespace MongoDbPlayground.Data.MongoDb.Entities;

public class Movie
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("_id")]
    public string Id { get; set; }

    [BsonElement("plot")]
    public string Plot { get; set; }

    [BsonElement("genres")]
    public List<string> Genres { get; set; }

    [BsonRepresentation(BsonType.Int32)]
    [BsonElement("runtime")]
    public int Runtime { get; set; }

    [BsonElement("cast")]
    public List<string> Cast { get; set; }

    [BsonElement("poster")]
    public string Poster { get; set; }

    [BsonElement("title")]
    public string Title { get; set; }

    [BsonElement("fullplot")]
    public string FullPlot { get; set; }

    [BsonElement("languages")]
    public List<string> Languages { get; set; }

    [BsonElement("released")]
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime Released { get; set; }

    [BsonElement("directors")]
    public List<string> Directors { get; set; }

    [BsonElement("rated")]
    public string Rated { get; set; }

    [BsonElement("awards")]
    public Awards? Awards { get; set; }

    [BsonElement("lastupdated")]
    public string LastUpdated { get; set; }

    [BsonElement("metacritic")]
    public int? Metacritic { get; set; }

    [BsonSerializer(typeof(NullableIntSerializer))]
    [BsonElement("year")]
    public int? Year { get; set; }

    [BsonElement("imdb")]
    public Imdb? Imdb { get; set; }

    [BsonElement("countries")]
    public List<string> Countries { get; set; }

    [BsonElement("type")]
    public string Type { get; set; }

    [BsonElement("tomatoes")]
    public Tomatoes? Tomatoes { get; set; }

    [BsonRepresentation(BsonType.Int32)]
    [BsonElement("num_mflix_comments")]
    public int NumMflixComments { get; set; }

    [BsonElement("writers")]
    public IReadOnlyCollection<string>? Writers { get; set; } = Enumerable.Empty<string>().ToList();
}