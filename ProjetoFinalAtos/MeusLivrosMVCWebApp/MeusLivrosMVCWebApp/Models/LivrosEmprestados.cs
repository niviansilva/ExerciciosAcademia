using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeusLivrosMVCWebApp.Models
{
    [Table("LivrosEmprestados")]
    public class LivrosEmprestados
    {

        internal bool StatusLivro;

        [Key()]
        public int ID { get; set; }
        [ForeignKey("livros")]
        public int IDLivro { get; set; }
        public string NomeAmigo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataDevolucao { get; set; }


        public virtual Livros livros { get; set; }
    }
}
