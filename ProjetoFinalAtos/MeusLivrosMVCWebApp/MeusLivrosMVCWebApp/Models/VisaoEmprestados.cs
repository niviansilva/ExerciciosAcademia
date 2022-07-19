using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeusLivrosMVCWebApp.Models
{
    public class VisaoEmprestados
    {

        public VisaoEmprestados(int IDLivroEmprestado, string NomeLivro, string NomeAmigo, string Telefone, string Email,DateTime DataInicio, DateTime? DataDevolucao, bool statusLivro)
        {

            this.IDLivroEmprestado = IDLivroEmprestado;
            this.NomeLivro = NomeLivro;
            this.NomeAmigo = NomeAmigo;
            this.Telefone = Telefone;
            this.Email = Email;
            this.DataInicio = DataInicio;
            this.DataDevolucao = DataDevolucao;
            this.StatusLivro = statusLivro;
        }

        public VisaoEmprestados( int ID,int IDLivroEmprestado, string NomeLivro, string NomeAmigo, string Telefone, string Email, DateTime DataInicio, DateTime? DataDevolucao, bool statusLivro)
        {
            this.ID = ID;
            this.IDLivroEmprestado = IDLivroEmprestado;
            this.NomeLivro = NomeLivro;
            this.NomeAmigo = NomeAmigo;
            this.Telefone = Telefone;
            this.Email = Email;
            this.DataInicio = DataInicio;
            this.DataDevolucao = DataDevolucao;
            this.StatusLivro = statusLivro;
        }



        public VisaoEmprestados(int IDLivroEmprestado, string NomeLivro, string NomeAmigo, string Telefone, string Email, DateTime DataInicio, bool statusLivro)
        {

            this.IDLivroEmprestado = IDLivroEmprestado;
            this.NomeLivro = NomeLivro;
            this.NomeAmigo = NomeAmigo;
            this.Telefone = Telefone;
            this.Email = Email;
            this.DataInicio = DataInicio;
            this.StatusLivro = statusLivro;
        }
        public VisaoEmprestados()
        {

        }

        [Key()]
        public int ID { get; set; }
        public int IDLivroEmprestado { get; set; }
        public string NomeLivro { get; set; }
        public string NomeAmigo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public bool StatusLivro { get; set; }


    }
}
