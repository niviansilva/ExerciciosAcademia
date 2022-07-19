namespace MeusLivrosMVCWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeusLivros_DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LivrosEmprestados",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDLivro = c.Int(nullable: false),
                        NomeAmigo = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        DataInicio = c.DateTime(nullable: false),
                        DataDevolucao = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Livros", t => t.IDLivro, cascadeDelete: true)
                .Index(t => t.IDLivro);
            
            CreateTable(
                "dbo.VisaoEmprestados",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDLivroEmprestado = c.Int(nullable: false),
                        NomeLivro = c.String(),
                        NomeAmigo = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        DataInicio = c.DateTime(nullable: false),
                        DataDevolucao = c.DateTime(),
                        StatusLivro = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VisaoLivros",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDLivro = c.Int(nullable: false),
                        NomeLivro = c.String(),
                        Autor = c.String(),
                        Editora = c.String(),
                        Genero = c.String(),
                        StatusLivro = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LivrosEmprestados", "IDLivro", "dbo.Livros");
            DropIndex("dbo.LivrosEmprestados", new[] { "IDLivro" });
            DropTable("dbo.VisaoLivros");
            DropTable("dbo.VisaoEmprestados");
            DropTable("dbo.LivrosEmprestados");
        }
    }
}
