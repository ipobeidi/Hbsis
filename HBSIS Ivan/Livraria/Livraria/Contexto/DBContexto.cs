using Livraria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Livraria.Contexto
{
    public class DBContexto :  DbContext
    {
        public DbSet<Livros> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }


        public DBContexto() : base("Name=LivrariaDb")
        {

        }

        //FluentAPI
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Autor
            modelBuilder.Entity<Autor>()
                .Property(a => a.Name)
                .HasMaxLength(255)
                .IsRequired();

            //Livros
            modelBuilder.Entity<Livros>()
                .HasRequired(l => l.Autor)
                .WithMany(a => a.Livro)
                .HasForeignKey(l => l.AutorId);

            modelBuilder.Entity<Livros>()
                .Property(l => l.Nome)
                .IsRequired()
                .HasMaxLength(255);

                
                
            
                
        }
    }
}