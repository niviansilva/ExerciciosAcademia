using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWFDB
{
    internal class ItemVenda
    {
        public int ID_Venda;
        public int ID_Produto;
        public double ValorUnitario;
        public int Quantidade;
        public double ValorTotal;
    
        public ItemVenda()
        {

        }
        public ItemVenda (int ID_Venda,int ID_Produto, double ValorUnitario, int Quantidade, double ValorTotal)
        {
            this.ID_Venda = ID_Venda;
            this.ID_Produto = ID_Produto;
            this.ValorUnitario = ValorUnitario;
            this.Quantidade = Quantidade;
            this.ValorTotal = ValorTotal;
        }

        internal void GravaItemVenda(List<ItemVenda> iv)
        {
            BancoDeDados bd = new BancoDeDados();
            foreach (ItemVenda ProdutosComprados in iv)
            {
                bd.GravaItemVenda(ProdutosComprados.ID_Venda, ProdutosComprados.ID_Produto, ProdutosComprados.ValorUnitario, ProdutosComprados.Quantidade, ProdutosComprados.ValorTotal);
            }
            
        }

        internal void Atualiza_Estoque(int iD_Venda)
        {
            BancoDeDados bd = new BancoDeDados();
            bd.Atualiza_Estoque(iD_Venda);
        }
    }
}
