using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWFDB
{
    internal class Vendas
    {
        public int ID_Produto;
        public int ID_Cliente;
        public double ValorTotal;

        public Vendas()
        {

        }
        public Vendas (int ID_Cliente, double ValorTotal)
        {
            this.ID_Cliente = ID_Cliente;
            this.ValorTotal = ValorTotal;  
        }

        internal int GravaVenda(Vendas v)
        {

            BancoDeDados bd = new BancoDeDados();
            return bd.GravaVenda(v);
        }

        internal int BuscaIDProduto(string Nome_Produto)
        {
            BancoDeDados bd = new BancoDeDados();
            return bd.BuscaIDProduto(Nome_Produto);
        }
    }
}
