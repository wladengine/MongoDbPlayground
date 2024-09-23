using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbPlayground.Data.MongoDb.Entities;

public class Awards
{
    [BsonRepresentation(BsonType.Int32)]
    [BsonElement("wins")]
    public int Wins { get; set; }

    [BsonRepresentation(BsonType.Int32)]
    [BsonElement("nominations")]
    public int Nominations { get; set; }

    [BsonElement("text")]
    public string Text { get; set; }
}
