namespace MeusLivrosMVCWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Generos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Estilo_Genero = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeLivro = c.String(),
                        Autor = c.String(),
                        Editora = c.String(),
                        ID_Genero = c.Int(nullable: false),
                        Sinopse = c.String(),
                        FotoCapa = c.String(),
                        StatusLivro = c.Boolean(nullable: false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Generos", t => t.ID_Genero, cascadeDelete: true)
                .Index(t => t.ID_Genero);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livros", "ID_Genero", "dbo.Generos");
            DropIndex("dbo.Livros", new[] { "ID_Genero" });
            DropTable("dbo.Livros");
            DropTable("dbo.Generos");
            DropColumn("dbo.Livros", "Estilo_Genero");
        }
    }
}
