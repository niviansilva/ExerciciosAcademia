using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DesafioWFDB
{
    public partial class FrmVendas : Form
    {
        //public int IdProduto;
        public int Estoque;
        public double TotalListaVenda;
        public int ID_Venda = 0;
        public FrmVendas()
        {
            InitializeComponent();
            CarregaClientes();
            CarregaProdutos();
        }

        public void CarregaClientes()
        {
            BancoDeDados b = new BancoDeDados();

            try
            {

                cbClientes.DisplayMember = "Nome";
                cbClientes.ValueMember = "ID";
                cbClientes.DataSource = b.CarregaComboClientes().Tables["Clientes"];
            }
            catch (Exception ex)
            {

            }
        }
        public void CarregaProdutos()
        {
            BancoDeDados b = new BancoDeDados();

            try
            {

                cbProdutos.DisplayMember = "Nome";
                cbProdutos.ValueMember = "ID";
                cbProdutos.DataSource = b.CarregaComboProdutos().Tables["Produtos"];
            }
            catch (Exception ex)
            {

            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {

            BancoDeDados bd = new BancoDeDados();
            
            
           SqlDataReader dr = bd.BuscaProduto(int.Parse(cbProdutos.SelectedValue.ToString()));
            while (dr.Read())
            {
              this.Estoque =int.Parse(dr["Estoque"].ToString());

              if (this.Estoque < int.Parse(tbQuantidade.Text))
                {
                    MessageBox.Show("Não tem estoque suficente para a compra", "Estoque insuficiente");
                    return;
                }
                cbClientes.Enabled = false;
                lstViewVendas.Items.Add(this.cbProdutos.GetItemText(this.cbProdutos.SelectedItem));
                lstViewVendas.Items[lstViewVendas.Items.Count - 1].SubItems.Add(tbQuantidade.Text);

                lstViewVendas.Items[lstViewVendas.Items.Count - 1].SubItems.Add(String.Format("{0:C}",(double.Parse(dr["Preco"].ToString())* int.Parse(tbQuantidade.Text)).ToString()));
            }

            TotalListaVenda = 0.00;

            for (int n = lstViewVendas.Items.Count - 1; n >= 0; --n)
            {
                string ValorAux = lstViewVendas.Items[n].SubItems[2].Text.ToString();
               TotalListaVenda = TotalListaVenda + double.Parse(ValorAux) ;
                
            }

            lbValorTotal.Text = TotalListaVenda.ToString();

            decimal valorAformatar = Decimal.Parse(lbValorTotal.Text);
            lbValorTotal.Text = String.Format("{0:C}", valorAformatar);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            for (int n = lstViewVendas.Items.Count - 1; n >= 0; --n)
            {
                lstViewVendas.Items.RemoveAt(n);
                
            }

            cbClientes.Enabled = true;
            TotalListaVenda = 0.00;
            lbValorTotal.Text = TotalListaVenda.ToString();
            decimal valorAformatar = Decimal.Parse(lbValorTotal.Text);
            lbValorTotal.Text = String.Format("{0:C}", valorAformatar);
        }

        private void btRemoveItem_Click(object sender, EventArgs e)
        {
            string Produto = lstViewVendas.SelectedItems[0].Text.ToString();

            for (int n = lstViewVendas.Items.Count - 1; n >= 0; --n)
            {
                if (lstViewVendas.Items[n].ToString().Contains(Produto))
                {
                    lstViewVendas.Items.RemoveAt(n);
                }
            }
            TotalListaVenda = 0.00;
            for (int n = lstViewVendas.Items.Count - 1; n >= 0; --n)
            {
                string ValorAux = lstViewVendas.Items[n].SubItems[2].Text.ToString();
                TotalListaVenda = TotalListaVenda + double.Parse(ValorAux);

            }

            lbValorTotal.Text = TotalListaVenda.ToString();

            decimal valorAformatar = Decimal.Parse(lbValorTotal.Text);
            lbValorTotal.Text = String.Format("{0:C}", valorAformatar);

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFinalizaCompra_Click(object sender, EventArgs e)
        {
            ItemVenda IV = new ItemVenda();
            string id_Cliente = cbClientes.SelectedValue.ToString();
            Vendas v = new Vendas(int.Parse(id_Cliente), double.Parse(lbValorTotal.Text.Replace("R$","")));

            int ID_Produto = 0;
            try
            {
                ID_Venda = v.GravaVenda(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a comprar!!" + ex.Message, "Erro!!");
                return;
            }

            List<ItemVenda> iv = new List<ItemVenda>();

            for (int n = lstViewVendas.Items.Count - 1; n >= 0; --n)
            {
                ID_Produto = v.BuscaIDProduto(lstViewVendas.Items[n].SubItems[0].Text.ToString());
                iv.Add(new ItemVenda(ID_Venda, ID_Produto, (double.Parse(lstViewVendas.Items[n].SubItems[2].Text.ToString()) / int.Parse(lstViewVendas.Items[n].SubItems[1].Text.ToString())), int.Parse(lstViewVendas.Items[n].SubItems[1].Text.ToString()), (double.Parse(lstViewVendas.Items[n].SubItems[2].Text.ToString()))));
            }
            try
            {
                if (ID_Venda == 0)
                {
                    MessageBox.Show("Ocorreu um erro ao realizar a comprar!!", "Erro!!");
                    return;
                }
                else
                {
                    IV.GravaItemVenda(iv);
                    MessageBox.Show("Compra finalizada com sucesso!!", "Sucesso!!");
                    IV.Atualiza_Estoque(ID_Venda);
                    
                    for (int n = lstViewVendas.Items.Count - 1; n >= 0; --n)
                    {
                        lstViewVendas.Items.RemoveAt(n);

                    }

                    cbClientes.Enabled = true;


                    lbValorTotal.Text = "R$0,00";
                    tbQuantidade.Text = "";


                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocorreu um erro ao realizar a comprar!!" + ex.Message, "Erro!!");
            }

        }
    }
}
