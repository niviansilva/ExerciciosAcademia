using MeusLivrosMVCWebApp.Models;
using System.Data.Entity;

namespace MeusLivrosMVCWebApp
{
    public class Contexto : DbContext
    {

        public Contexto() : base("MeusLivros_DB") { }
        public DbSet<Livros> Livro { get; set; }
        public DbSet<Genero> genero { get; set; }
        public DbSet<LivrosEmprestados> livrosemprestados { get; set; }
        public DbSet<VisaoLivros> visaoLivros { get; set; }
        public DbSet<VisaoEmprestados> visaoEmprestados { get; set; }

    
    }


}

