using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_mongodb_domain.Entities;

namespace web_mongodb_infra.Database
{
    public class DbContext
    {
        private static string stringConexao = "mongodb://localhost:27017";
        private static readonly IMongoClient _cliente;
        private static readonly IMongoDatabase _bancoDados;

        static DbContext() {
            _cliente = new MongoClient(stringConexao);
            _bancoDados = _cliente.GetDatabase("Biblioteca");
        }

        public IMongoClient Cliente
        {
            get { return _cliente; }
        }

        public IMongoCollection<Livro> Livros
        {
            get { return _bancoDados.GetCollection<Livro>("Livros"); }
        }
    }
}
