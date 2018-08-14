using System.Collections.Generic;

namespace Livraria.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Livros> Livro { get; set; }
    }
}