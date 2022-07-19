using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeusLivrosMVCWebApp.Models
{
    [Table("VisaoLivros")]
    public class VisaoLivros
    {
        private string? nomeGenero;

        public VisaoLivros(int IDLivro, string nomeLivro, string autor, string editora, string? nomeGenero, bool statusLivro)
        {

            this.IDLivro= IDLivro;
            NomeLivro = nomeLivro;
            Autor = autor;
            Editora = editora;
            Genero = nomeGenero;
            StatusLivro = statusLivro;
        }
        public VisaoLivros()
        {

        }

        [Key()]
        public int ID { get; set; }
        public int IDLivro { get; set; }
        public string NomeLivro { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }
        public bool StatusLivro { get; set; }

    }
}
