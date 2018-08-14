using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class Livros
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string  Ano { get; set; }

        public int AutorId { get; set; }

        public Autor Autor { get; set; }
    }
}