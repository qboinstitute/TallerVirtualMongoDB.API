using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TallerVirtualMongoDB.API.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


    }
}
