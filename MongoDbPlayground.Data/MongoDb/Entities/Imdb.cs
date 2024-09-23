using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDbPlayground.FX.MongoDb.Bson.Serialization;

namespace MongoDbPlayground.Data.MongoDb.Entities;

[BsonNoId]
public class Imdb
{
    [BsonSerializer(typeof(NullableDoubleSerializer))]
    [BsonElement("rating")]
    public double? Rating { get; set; }

    [BsonSerializer(typeof(NullableIntSerializer))]
    [BsonElement("votes")]
    public int? Votes { get; set; }

    [BsonRepresentation(BsonType.Int32)]
    [BsonElement("id")]
    public int? Id { get; set; }
}
