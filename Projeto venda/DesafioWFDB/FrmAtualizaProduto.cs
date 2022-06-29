using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioWFDB
{
    public partial class FrmAtualizaProduto : Form
    {
        OpenFileDialog opnfd = new OpenFileDialog();
        DataTable dtProduto = new DataTable();
        int idProduto;
        string CaminhoProduto;
        public FrmAtualizaProduto(int idproduto)
        {
            InitializeComponent();
            CarregaProduto(idproduto);
        }

        private void CarregaProduto(int idproduto)
        {
           BancoDeDados bd = new BancoDeDados();
           dtProduto= bd.CarregaProduto(idproduto);

            decimal valorAformatar = Decimal.Parse(dtProduto.Rows[0]["Preco"].ToString());
            

            idProduto = int.Parse(dtProduto.Rows[0]["ID"].ToString());
            tbCodEAN.Text = dtProduto.Rows[0]["CodEAN"].ToString();
            tbNomeProduto.Text= dtProduto.Rows[0]["Nome"].ToString();
            mskPreco.Text = String.Format("{0:C}", valorAformatar);//dtProduto.Rows[0]["Preco"].ToString();
            tbEstoque.Text = dtProduto.Rows[0]["Estoque"].ToString();
            pbImagemProduto.Image = new Bitmap((string)dtProduto.Rows[0]["CaminhoImagem"].ToString());
            CaminhoProduto = dtProduto.Rows[0]["CaminhoImagem"].ToString();

        }

        private void btAtualiza_Click(object sender, EventArgs e)
        {
            if(opnfd.FileName != "")
            {
                if(opnfd.FileName != CaminhoProduto)
                {
                    CaminhoProduto = opnfd.FileName;
                }
            }

            bool sucesso = true;
            Produtos p = new Produtos(Int64.Parse(tbCodEAN.Text), tbNomeProduto.Text, Double.Parse(mskPreco.Text.Replace("R$","")), int.Parse(tbEstoque.Text), CaminhoProduto);

           
            try
            {
                p.AtualizaProduto(p, idProduto);
                if (sucesso)
                {
                    MessageBox.Show("Cadastro Atualizado com sucesso", "Sucesso");
                }
                else
                {
                    MessageBox.Show("erro ao Atualizar", "Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao Atualizar" + ex.Message, "Erro");
            }
           
        }

        private void btSobeImagem_Click(object sender, EventArgs e)
        {
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbImagemProduto.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
