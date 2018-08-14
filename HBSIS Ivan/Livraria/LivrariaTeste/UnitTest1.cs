using System;

using Livraria.Models;
using Livraria.Controllers.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Livraria.DTO;

namespace LivrariaTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PegaTodosOsLIvros_RetornaTodosOsLivros()
        {
            var controller = new LivrosController();
            var result = controller.PegaLivros() ;

            Assert.IsNotNull(result);
            
        }

        [TestMethod]
        public void Insere_livros()
        {
            var controller = new LivrosController();
            var _livro = new LivroDTO
            {
                Nome = "Livro do Teste",
                Ano = "2018",
                AutorId = 2
            };

            var result = controller.CriarLivros(_livro);

            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void Deleta_livro()
        {
            var controller = new LivrosController();
            int id = 1;

            controller.DeletaLivro(id);
               

        }
        public void Muda_livros()
        {
            var controller = new LivrosController();
            LivroDTO _livro = new LivroDTO
            {
                Nome = "Refazendo o Teste",
                Ano = "2018",
                AutorId = 2
            };

             var result = controller.UpdateLivros(2,_livro);

            Assert.IsNotNull(result);

        }


    }
}
