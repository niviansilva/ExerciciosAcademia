
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeusLivrosMVCWebApp.Models
{
    [Table("Livros")]
    public class Livros
    {
        [Key()]
        public int Id { get; set; }
        public string NomeLivro { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        [ForeignKey("Generos")]
        public int ID_Genero { get; set; }
        public string Sinopse { get; set; }
        public string FotoCapa { get; set; }
        public bool StatusLivro { get; set; }

        public virtual Genero Generos { get; set; }


        public static List<Livros> Todos()
        {
            var db = new Contexto();
            return db.Livro.ToList();
        }

        public void AdicionaLivros()
        {
            var teste = new Contexto();
            Livros L = new Livros() { NomeLivro = "TesteMVC", Autor = "AutorMVC", Editora = "EditoraMVC", ID_Genero = 1, Sinopse = "Teste MVC", FotoCapa = "ABC", StatusLivro = true };
            teste.Livro.Add(L);
            teste.SaveChanges();
        
        } 
    }
           
}
