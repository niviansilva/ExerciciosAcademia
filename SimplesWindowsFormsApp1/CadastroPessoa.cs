using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplesWindowsFormsBanco
{
    public partial class CadastroPessoa : Form
    {
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa(tbNome.Text, Convert.ToInt32(tbIdade.Text), tbCPF.Text, tbEnd.Text, tbBairro.Text, tbCEP.Text, tbCidade.Text);
            MessageBox.Show("Nome do individuo" + p.nome + " CPF " + p.cpf);
            tbNome.Text= ""; 
            tbIdade.Text= ""; 
            tbCPF.Text= "";
            tbEnd.Text= "";
            tbBairro.Text= ""; 
            tbCEP.Text= ""; 
            tbCidade.Text= "";
            p.gravarPessoa();
        }
    }
}
