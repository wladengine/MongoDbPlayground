using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbPlayground.Data.MongoDb.Entities;

public class Viewer
{
    [BsonRepresentation(BsonType.Double)]
    [BsonElement("rating")]
    public double Rating { get; set; }

    [BsonRepresentation(BsonType.Int32)]
    [BsonElement("numReviews")]
    public int NumReviews { get; set; }

    [BsonRepresentation(BsonType.Int32)]
    [BsonElement("meter")]
    public int Meter { get; set; }
}
