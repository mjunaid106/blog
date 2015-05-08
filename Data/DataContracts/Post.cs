using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DataContracts
{
    public class Post
    {
        public ObjectId Id { get; set; }
        
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("text")]
        public string Text { get; set; }

        [BsonElement("posted_on")]
        public DateTime PostedOn { get; set; }

        [BsonElement("last_modified")]
        public DateTime LastModified { get; set; }

    }
}
