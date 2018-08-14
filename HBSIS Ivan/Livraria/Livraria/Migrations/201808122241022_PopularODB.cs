namespace Livraria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopularODB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Autors (Name) VALUES ('Autor1')");
            Sql("INSERT INTO Autors (Name) VALUES ('Autor2')");
            Sql("INSERT INTO Autors (Name) VALUES ('Autor3')");
            Sql("INSERT INTO Autors (Name) VALUES ('Autor4')");
        }
        
        public override void Down()
        {

        }
    }
}
