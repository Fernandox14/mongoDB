using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace web_mongodb_domain.Entities
{
    [BsonIgnoreExtraElements]
    public class Livro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [DataMember]
        [BsonElement("Título")]
        public string Título { get; set; }
        [DataMember]
        [BsonElement("Autor")]
        public string Autor { get; set; }
        [DataMember]
        [BsonElement("Ano")]
        public int Ano { get; set; }
        [DataMember]
        [BsonElement("Páginas")]
        public int Paginas { get; set; }
        [DataMember]
        [BsonElement("Assunto")]
        public List<string> Assunto { get; set; }
    }
}
