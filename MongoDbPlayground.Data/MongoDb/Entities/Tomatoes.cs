using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbPlayground.Data.MongoDb.Entities;

public class Tomatoes
{
    [BsonElement("boxOffice")]
    public string? BoxOffice { get; set; } = string.Empty;

    [BsonElement("consensus")]
    public string? Consensus { get; set; } = string.Empty;

    [BsonElement("viewer")]
    public Viewer Viewer { get; set; }

    [BsonRepresentation(BsonType.Int32)]
    [BsonElement("fresh")]
    public int Fresh { get; set; }

    [BsonElement("critic")]
    public Critic Critic { get; set; }

    [BsonElement("dvd")]
    [BsonDateTimeOptions(DateOnly = true, Kind = DateTimeKind.Utc)]
    public DateTime? Dvd { get; set; }

    [BsonRepresentation(BsonType.Int32)]
    [BsonElement("rotten")]
    public int Rotten { get; set; }

    [BsonElement("lastUpdated")]
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime LastUpdated { get; set; }

    [BsonElement("production")]
    public string? Production { get; set; } = string.Empty;

    [BsonElement("website")]
    public string? Website { get; set; } = string.Empty;
}
