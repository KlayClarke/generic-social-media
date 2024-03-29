using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Api.Models;

public class Post
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string? Id { get; set; }
  public string Title { get; set; } = null!;
  public string Body { get; set; } = null!;
  public string DateCreated { get; set; } = null!;

  [BsonRepresentation(BsonType.ObjectId)]
  public string AuthorId { get; set; } = null!;
}