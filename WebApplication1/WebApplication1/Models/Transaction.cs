using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication1.Models
{
    public class Transaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("idStr")]
        public string IdStr { get; set; }

        [BsonElement("category")]
        public string Category { get; set; }

        [BsonElement("date")]
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime Date { get; set; }

        [BsonElement("sales")]
        public int Sales { get; set; }

        [BsonElement("sum")]
        public decimal Sum { get; set; }

        [BsonElement("profit")]
        public decimal Profit { get; set; }

        [BsonElement("_class")]
        public string _class { get; set; }
    }
}
