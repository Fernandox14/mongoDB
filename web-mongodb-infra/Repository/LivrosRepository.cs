using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_mongodb_domain.Entities;
using web_mongodb_domain.Interfaces;
using web_mongodb_infra.Database;

namespace web_mongodb_infra.Repository
{
    public class LivrosRepository: ILivroRepository
    {
        private DbContext _db = new DbContext();
    
        public IEnumerable<Livro> GetAll()
        {
            return _db.Livros.AsQueryable<Livro>().ToList();
        }

        public async Task<Livro> GetById(string id)
        {
            return await _db.Livros.Find(x=> x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Insert(Livro livro)
        {
            await _db.Livros.InsertOneAsync(livro);
        }

        public async Task Update(Livro livro)
        {
            var filter = Builders<Livro>.Filter.Eq("Id", livro.Id);
            await _db.Livros.ReplaceOneAsync(filter, livro, new ReplaceOptions { IsUpsert = true });
        }
        public async Task Delete(string id)
        {
            var filter = Builders<Livro>.Filter.Eq(Livro => Livro.Id, id);
            await _db.Livros.DeleteOneAsync(filter); 
        }
    }
}
