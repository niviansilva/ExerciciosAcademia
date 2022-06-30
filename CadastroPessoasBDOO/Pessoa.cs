using System;
using System.Data;
using System.Data.SqlClient;

namespace SimplesWindowsFormsBanco
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public string cpf;
        public string end;
        public string bairro;
        public string cep;
        public string cidade;
        public string email;
        public Pessoa(string nome, int idade, string cpf, string end, string bairro, string cep, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.end = end;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            gerarEmail();
        }
        public Pessoa()
        {

        }

        public void gravarPessoa(Pessoa p)
        {
            Banco banco = new Banco();
            banco.gravaPessoa(p);
            
        }
        private void gerarEmail()
        {
            string[] vetorDados = this.nome.Split(' ');
            this.email = vetorDados[vetorDados.Length - 1] + "." + vetorDados[0] + "@ufn.edu.br";
            this.email = this.email.ToLower();
        }

        public void AtualizaPessoa(Pessoa p, int idPessoa)
        {
            Banco banco = new Banco();
            banco.AtualizaPessoaBanco(p, idPessoa);
        }

        internal bool DeletaRegistro(int idPessoa)
        {
            Banco banco = new Banco();
         return  banco.DeletaRegistro(idPessoa);
        }
    }
}
