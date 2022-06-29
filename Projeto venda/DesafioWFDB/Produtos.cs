using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWFDB
{
    class Produtos
    {
        public Int64 CodEAN;
        public string NomeProduto;
        public double Preco;
        public int Estoque;
        public string CaminhoImagem;

        public Produtos()
        {

        }
        public Produtos (Int64 CodEAN, string NomeProduto, double Preco, int Estoque, string CaminhoImagem)
        {
            this.CodEAN = CodEAN;
            this.NomeProduto = NomeProduto;
            this.Preco = Preco;
            this.Estoque = Estoque;
            this.CaminhoImagem = CaminhoImagem;
        }

        internal void GravaProduto(Produtos p)
        {
            BancoDeDados bd = new BancoDeDados();
            bd.GravaProduto(p);
        }

        internal void AtualizaProduto(Produtos p, int idProduto)
        {
            BancoDeDados bd = new BancoDeDados();
            bd.AtualizaProduto(p,idProduto);
        }

        internal void DeletaRegistro(int idProduto)
        {
            BancoDeDados bd = new BancoDeDados();
            bd.DeletaProduto(idProduto);
        }
    }
}
