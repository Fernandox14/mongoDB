using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_mongodb_domain.Entities;

namespace web_mongodb_domain.Interfaces
{
    public interface ILivroRepository
    {
        public IEnumerable<Livro> GetAll();
        public Task<Livro> GetById(string id);
        public Task Insert(Livro livro);
        public Task Update(Livro livro);
        public Task Delete(string id);
    }
}
