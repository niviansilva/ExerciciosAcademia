using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWFDB
{
    class Cliente
    {
        public string CPF;
        public string Nome;
        public string Endereco;
        public string Bairro;
        public string Cidade;
        public string CEP;
        public string UF;
        public string Telefone;
        public string Email;

        public Cliente(string CPF, string Nome, string Endereco, string Bairro, string Cidade, string CEP, string UF, string Telefone, string Email)
        {
            this.CPF = CPF;
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.CEP = CEP;
            this.UF = UF;
            this.Telefone = Telefone;
            this.Email = Email;
        }

        public Cliente()
        {
        }

        internal void gravaCliente(Cliente c)
        {
           BancoDeDados bd = new BancoDeDados(); // Instanciando a classe Banco de Dados
            bd.gravaCliente(c); //Enviando a classe cliente preenchida para o método grava clientes na classe banco de dados
        }

        internal void AtualizaCliente(Cliente c, int idCliente)
        {
            BancoDeDados bd = new BancoDeDados();
            bd.AtualizaPessoaBanco(c, idCliente);
        }

        internal void DeletaRegistro(int idCliente)
        {
            BancoDeDados bd = new BancoDeDados();
            bd.DeletaRegistro(idCliente);
        }
    }
}