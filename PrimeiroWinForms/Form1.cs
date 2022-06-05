using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("cliquei no botao OK");
            MessageBox.Show("O nome digitado pelo usuário é: " + TbNome.Text +  "\n o email digitado é: " + tBemail.Text + "\n o endereço é: "+ tbEnd.Text + "\n o telefone digitado é: "+tbtelefone.Text + "\n o bairro digitado é: " + tbbairro.Text + "\n a cidade digitada é: " + tbcidade.Text + " o sexo digitado é: " + tbsexo.Text );
            MessageBox.Show(" Cadastro efetuado!");
            TbNome.Clear();
            tBemail.Clear();    
            tbEnd.Clear();
            tbbairro.Text = " ";
            tbcidade.Text = "Nova Cidade";
            tbtelefone.Text = " ";
            lblMSG.Text = "CADASTRO EFETUADO COM SUCESSO! INSIRA UM NOVO REGISTRO!";

        }


        private void BTCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão cancelar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo a este lindo programa");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
