using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using web_mongodb_domain.Entities;
using web_mongodb_domain.Interfaces;
using web_mongodb_infra.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_mongodb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroRepository _livrosRepository;
        public LivrosController(ILivroRepository livroRepository) {
            _livrosRepository = livroRepository;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public IEnumerable<Livro> Get()
        {
            // return _livrosRepository.GetAll();
            return _livrosRepository.GetAll();
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public async Task<Livro> Get(string id)
        {
            return await _livrosRepository.GetById(id);
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public async Task Post(Livro livro)
        {
            await _livrosRepository.Insert(livro);
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public async Task Put(Livro livro)
        {
            await _livrosRepository.Update(livro);
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _livrosRepository.Delete(id);
        }
    }
}
