namespace Livraria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulaLivros : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro1',2018,1)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro1',2018,1)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro2',2018,2)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro3',2018,3)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro4',2018,4)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro4',2018,4)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro2',2018,2)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro2',2018,2)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro3',2018,3)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro3',2018,3)");
            Sql("INSERT INTO Livros (Nome,Ano,AutorId) VALUES ('Livro4',2018,2)");

        }
        
        public override void Down()
        {
        }
    }
}
