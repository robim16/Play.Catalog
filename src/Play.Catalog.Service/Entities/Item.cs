using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Play.Catalog.Service.Entities
{

    public class Item : IEntity
    {
        [BsonId]
        [BsonGuidRepresentation(GuidRepresentation.Standard)] // Specify representation for Id
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
