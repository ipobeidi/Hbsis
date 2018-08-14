using AutoMapper;
using Livraria.Contexto;
using Livraria.DTO;
using Livraria.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Livraria.Controllers.API
{
    public class LivrosController : ApiController
    {
        private DBContexto _contexto;
        
        //get/api/livros
        public LivrosController()
        {
           _contexto =  new DBContexto();
        }

        [HttpGet]
        public IEnumerable<LivroDTO> PegaLivros()
        {
            return _contexto.Livros.ToList().Select(Mapper.Map<Livros,LivroDTO>);
        }
        [HttpGet]
        public IHttpActionResult PegaLivros(int id)
        {
            var livro= _contexto.Livros.SingleOrDefault(l => l.Id == id);

            if (livro == null)
                return NotFound();

            return Ok(Mapper.Map<Livros,LivroDTO>(livro));
        }

        // post /api/livros
        [HttpPost]
        public IHttpActionResult CriarLivros(LivroDTO livrosDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var livros = Mapper.Map<LivroDTO,Livros>(livrosDTO);

            _contexto.Livros.Add(livros);
            _contexto.SaveChanges();

            livrosDTO.Id = livros.Id;

            return Created(new Uri(Request.RequestUri + "/" + livros.Id), livrosDTO);
        }
        [HttpPut]
        public IHttpActionResult UpdateLivros(int id , LivroDTO livroDTO)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var livrosNoDb = _contexto.Livros.SingleOrDefault(l => l.Id == id);

            if (livrosNoDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            //auto Mapper
            Mapper.Map<LivroDTO, Livros>(livroDTO, livrosNoDb);

            _contexto.SaveChanges();

            return Ok(livroDTO);

        }

        public void DeletaLivro(int id)
        {
            
            var livrosNoDb = _contexto.Livros.SingleOrDefault(l => l.Id == id);
            if (livrosNoDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _contexto.Livros.Remove(livrosNoDb);
            _contexto.SaveChanges();

        }


    }
}
