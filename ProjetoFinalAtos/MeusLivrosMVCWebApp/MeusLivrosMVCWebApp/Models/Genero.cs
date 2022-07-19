using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeusLivrosMVCWebApp.Models
{
    [Table("Generos")]
    public class Genero
    {
        [Key()]
        public int Id { get; set; }
        public string Estilo_Genero { get; set; }


        public static List<Genero> Todos()
        {
            var db = new Contexto();
            return db.genero.ToList();
        }
    }
}
