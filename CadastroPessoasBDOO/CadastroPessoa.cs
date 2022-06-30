using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SimplesWindowsFormsBanco
{
    public partial class CadastroPessoa : Form
    {
        public int idPessoa;
        public string email = "";
        public CadastroPessoa()
        {
            InitializeComponent();
            carregarListView();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            Mensagem = ValidaCampos();
            if (Mensagem !="")
            {
                MessageBox.Show(Mensagem, "Erro");
                return;
            }
            bool sucesso = true;
            string[] ValidaNome;

            ValidaNome = tbNome.Text.Split(' ');

            if (ValidaNome.Length < 2)
            {
                MessageBox.Show("Deve ser digitado Nome e Sobrenome", "Atenção!");
                return;
            }


            Pessoa p = new Pessoa(tbNome.Text, Convert.ToInt32(tbIdade.Text), tbCPF.Text, tbEnd.Text, tbBairro.Text, tbCEP.Text, tbCidade.Text);
            LimparCampos();
            try
            {
                p.gravarPessoa(p);
                if (sucesso)
                {
                    MessageBox.Show("Cadastro Realizado com sucesso", "Sucesso");
                    carregarListView();
                }
                else
                {
                    MessageBox.Show("erro ao gerar o cadastro", "Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao gerar o cadastro" + ex.Message, "Erro");
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            
            
            Pessoa p = new Pessoa();

            try
            {
                idPessoa = int.Parse(lsViewCadastro.SelectedItems[0].Text.ToString());
                p.DeletaRegistro(idPessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("É necessário selecionar uma linha para deleção");

            }

            carregarListView();

            
        }

        private void btCarregar_Click(object sender, EventArgs e)
        {

            try
            {
                idPessoa = int.Parse(lsViewCadastro.SelectedItems[0].Text.ToString());
                tbNome.Text = lsViewCadastro.SelectedItems[0].SubItems[1].Text.ToString();
                tbCPF.Text = lsViewCadastro.SelectedItems[0].SubItems[2].Text.ToString();
                tbIdade.Text = lsViewCadastro.SelectedItems[0].SubItems[3].Text.ToString();
                tbEnd.Text = lsViewCadastro.SelectedItems[0].SubItems[4].Text.ToString();
                tbBairro.Text = lsViewCadastro.SelectedItems[0].SubItems[5].Text.ToString();
                tbCidade.Text = lsViewCadastro.SelectedItems[0].SubItems[6].Text.ToString();
                tbCEP.Text = lsViewCadastro.SelectedItems[0].SubItems[7].Text.ToString();
                email = lsViewCadastro.SelectedItems[0].SubItems[8].Text.ToString();

                btAtualizar.Enabled = true;
                btSalvar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("É necessário selecionar uma linha para deleção");
            }


        }

        private void carregarListView()
        {
            Banco b = new Banco();

            try
            {

                lsViewCadastro.Items.Clear();

                SqlDataReader dr = b.CarregaBanco();

                int i = 0;
                while (dr.Read())
                {

                    lsViewCadastro.Items.Add(dr["idPessoa"].ToString());
                    lsViewCadastro.Items[i].SubItems.Add(dr["Nome"].ToString());
                    lsViewCadastro.Items[i].SubItems.Add(dr["CPF"].ToString());
                    lsViewCadastro.Items[i].SubItems.Add(dr["Idade"].ToString());
                    lsViewCadastro.Items[i].SubItems.Add(dr["Endereco"].ToString());
                    lsViewCadastro.Items[i].SubItems.Add(dr["Bairro"].ToString());
                    lsViewCadastro.Items[i].SubItems.Add(dr["Cidade"].ToString());
                    lsViewCadastro.Items[i].SubItems.Add(dr["CEP"].ToString());
                    lsViewCadastro.Items[i].SubItems.Add(dr["Email"].ToString());

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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            btAtualizar.Enabled = false;
            btSalvar.Enabled = true;
            LimparCampos();
        }

        private void LimparCampos()
        {
            tbNome.Text = "";
            tbCPF.Text = "";
            tbIdade.Text = "";
            tbEnd.Text = "";
            tbBairro.Text = "";
            tbCidade.Text = "";
            tbCEP.Text = "";

        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            bool sucesso = true;
            Pessoa p = new Pessoa(tbNome.Text, Convert.ToInt32(tbIdade.Text), tbCPF.Text, tbEnd.Text, tbBairro.Text, tbCEP.Text, tbCidade.Text);
            LimparCampos();
            try
            {
                p.AtualizaPessoa(p, idPessoa);
                if (sucesso)
                {
                    MessageBox.Show("Cadastro Atualizado com sucesso", "Sucesso");
                    carregarListView();
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
        public string ValidaCampos()
        {

            if (tbNome.Text == "")
            {
                return "O campo Nome precisa ser Preenchido";
            }
            else if (tbIdade.Text == "")
            {
                return "O campo Idade precisa ser Preenchido";
            }
            else if (tbCPF.Text == "")
            {
                return "O campo CPF precisa ser Preenchido";
            }
            else if (tbEnd.Text == "")
            {
                return "O campo Endereço precisa ser Preenchido";
            }
            else if (tbBairro.Text == "")
            {
                return "O campo Bairro precisa ser Preenchido";
            }
            else if (tbCEP.Text == "")
            {
                return "O campo CEP precisa ser Preenchido";
            }
            else if (tbCidade.Text == "")
            {
                return "O campo Cidade precisa ser Preenchido";

            }
            else
            {
                return "";
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
