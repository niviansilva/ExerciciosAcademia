using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioWFDB
{
    public partial class FrmProduto : Form
    {
        public int idProduto;
        public FrmProduto()
        {
            
            InitializeComponent();
            carregarListView(); //Carrega a list view com os produtos já cadastrados em banco

        }
        private void carregarListView()
        {
            BancoDeDados b = new BancoDeDados();

            try
            {

                lstViewProduto.Items.Clear();  //Limpa a tela de produtos

                SqlDataReader dr = b.CarregaProduto();  //Carrega um data reader com todos os produtos em banco

                int i = 0;
                while (dr.Read())  //Enquanto houver dados no data reader a list view vai sendo preenchida
                {


                    decimal valorAformatar = Decimal.Parse(dr["Preco"].ToString());

                    lstViewProduto.Items.Add(dr["ID"].ToString());
                    lstViewProduto.Items[i].SubItems.Add(dr["Nome"].ToString());
                    lstViewProduto.Items[i].SubItems.Add(String.Format("{0:C}", valorAformatar));
                    lstViewProduto.Items[i].SubItems.Add(dr["Estoque"].ToString());
                    
                    i++;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
            finally
            {
                b.fecharConexao();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)  //Abre a tela de cadastro de produtos
        {
            Form cadastroProduto = new frmCadProduto();
            cadastroProduto.Show();
        }

        private void btAtualizarGrid_Click(object sender, EventArgs e)
        {
            carregarListView();  //Recarrega o list view
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            idProduto = int.Parse(lstViewProduto.SelectedItems[0].Text.ToString());

            Form CadProduto = new FrmAtualizaProduto(idProduto);  // Abre o Form de atualização de produto passando o ID produto por parâmetro
            CadProduto.Show();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();  //Fecha o formulário de produto
        }

        private void btApagar_Click(object sender, EventArgs e)
        {

            Produtos P = new Produtos();

            try
            {
                idProduto = int.Parse(lstViewProduto.SelectedItems[0].Text.ToString());
                P.DeletaRegistro(idProduto); // Deleta o registro a partir do ID selecionado na list view
            }
            catch (Exception ex)
            {
                MessageBox.Show("É necessário selecionar uma linha para deleção");

            }

            carregarListView();
        }
    }
}
