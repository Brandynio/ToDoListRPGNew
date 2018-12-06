using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace accountDatabase.Models
{
    public class Book
    {
        public ObjectId Id { get; set; }
        [BsonElement("BookId")]
        public int BookId { get; set; }
        [BsonElement("BookName")]
        public string BookName { get; set; }
        [BsonElement("Price")]
        public int Price { get; set; }
        [BsonElement("Category")]
        public string Category { get; set; }
        [BsonElement("Author")]
        public string Author { get; set; }
    }
}
