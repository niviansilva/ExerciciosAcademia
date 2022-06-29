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
    public partial class frmCadProduto : Form
    {
        OpenFileDialog opnfd = new OpenFileDialog();
        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void btSobeImagem_Click(object sender, EventArgs e)
        {
            
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";  //Funcionalidade para selecionar a imagem do produto, tendo como extensão esperada JPEG ou GIF
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbImagemProduto.Image = new Bitmap(opnfd.FileName);  //Carrega a imagem a partir da caixa de dialogo anterior
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos p = new Produtos(Int64.Parse(tbCodEAN.Text),tbNomeProduto.Text,Double.Parse(mskPreco.Text),int.Parse(tbEstoque.Text), opnfd.FileName);  //Preenchendo o construtor com as informações da tela
            try { 
            p.GravaProduto(p);
                MessageBox.Show("Cadastro realizado com sucesso!!", "Sucesso");
                LimpaCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar!!"+ex.Message,"Erro ao cadastrar");
            }
        }

        private void LimpaCampos()
        {
            tbCodEAN.Text = "";
            tbNomeProduto.Text = "";
            mskPreco.Text = "";
            tbEstoque.Text = "";
            pbImagemProduto.Image = null;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
