using System.Data.SqlClient;

namespace DesafioWFDB
{
    public partial class Frm_CadastroCliente : Form
    {
        public int idCliente;
        public Frm_CadastroCliente()
        {
            
            InitializeComponent();
            btAtualizar.Enabled = false;// Botão de atualização desabilitado
            carregarListView();  //métodp para carrregar a lista com os clientes cadastrados
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            Mensagem = ValidaCampos(); //método que valida os campos
            if (Mensagem != "")
            {
                MessageBox.Show(Mensagem, "Erro");
                return;
            }
            bool sucesso = true;
            //Carregando construtor com as informações da tela
            Cliente C = new Cliente(tbCPF.Text, tbNome.Text, tbEndereco.Text, tbBairro.Text, tbCidade.Text, tbCEP.Text, CbUF.SelectedText, tbTelefone.Text, tbEmail.Text);
            LimparCampos(); //limpa os campos da tela

            try 
            { 
                C.gravaCliente(C); // Método de envio dos dados do construtor para a classe cliente
                MessageBox.Show("Cliente cadastrado com Sucesso", "Sucesso");
                carregarListView();  //Carrega list view com os dados atualizados após o insert
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a gravação", "Erro");
            }


        }

        private void LimparCampos()
        {
            tbCPF.Text = "";
            tbNome.Text = "";
            tbEndereco.Text = "";
            tbBairro.Text = "";
            tbCidade.Text = "";
            tbCEP.Text = "";
            CbUF.Text = "";
            CbUF.SelectedText = "Selecione";
            tbTelefone.Text = "";
            tbEmail.Text = "";
        }

        public string ValidaCampos()
        {

            if (tbNome.Text == "")
            {
                return "O campo Nome precisa ser Preenchido";
            }
            else if (tbCPF.Text == "")
            {
                return "O campo CPF precisa ser Preenchido";
            }
            else if (tbEndereco.Text == "")
            {
                return "O campo Endereço precisa ser Preenchido";
            }
            else if (tbCidade.Text == "")
            {
                return "O campo Cidade precisa ser Preenchido";
            }
            else if (tbBairro.Text == "")
            {
                return "O campo Bairro precisa ser Preenchido";
            }
            else if (tbTelefone.Text == "")
            {
                return "O campo Telefone precisa ser Preenchido";
            }
            else if (CbUF.SelectedText == "Selecione")
            {
                return "O campo UF precisa ser Preenchido";
            }
            else if (tbCEP.Text == "")
            {
                return "O campo CEP precisa ser Preenchido";
            } 
            else if (tbEmail.Text == "")
            {
                return "O campo E-mail precisa ser Preenchido";
            }
            else
            {
                return "";
            }

        }
        private void carregarListView()
        {
            BancoDeDados b = new BancoDeDados();

            try
            {

                lstView_Cliente.Items.Clear();

                SqlDataReader dr = b.CarregaBanco();

                int i = 0;
                while (dr.Read())
                {

                    lstView_Cliente.Items.Add(dr["ID"].ToString());
                    lstView_Cliente.Items[i].SubItems.Add(dr["CPF"].ToString());
                    lstView_Cliente.Items[i].SubItems.Add(dr["Nome"].ToString());
                    lstView_Cliente.Items[i].SubItems.Add(dr["Endereco"].ToString());
                    lstView_Cliente.Items[i].SubItems.Add(dr["Bairro"].ToString());
                    lstView_Cliente.Items[i].SubItems.Add(dr["Cidade"].ToString());
                    lstView_Cliente.Items[i].SubItems.Add(dr["CEP"].ToString());
                    lstView_Cliente.Items[i].SubItems.Add(dr["UF"].ToString());
                    lstView_Cliente.Items[i].SubItems.Add(dr["Telefone"].ToString());
                    lstView_Cliente.Items[i].SubItems.Add(dr["Email"].ToString());

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
            LimparCampos();
            btCadastrar.Enabled = true;
            btAtualizar.Enabled = false;
        }

        private void btCarregar_Click(object sender, EventArgs e)  //Carrega os campos da tela baseado no dado da list view
        {
            try
            {
                idCliente = int.Parse(lstView_Cliente.SelectedItems[0].Text.ToString());
                tbCPF.Text = lstView_Cliente.SelectedItems[0].SubItems[1].Text.ToString();
                tbNome.Text = lstView_Cliente.SelectedItems[0].SubItems[2].Text.ToString();
                tbEndereco.Text = lstView_Cliente.SelectedItems[0].SubItems[3].Text.ToString();
                tbBairro.Text = lstView_Cliente.SelectedItems[0].SubItems[4].Text.ToString();
                tbCidade.Text = lstView_Cliente.SelectedItems[0].SubItems[5].Text.ToString();
                tbCEP.Text = lstView_Cliente.SelectedItems[0].SubItems[6].Text.ToString();
                CbUF.Text = "";
                CbUF.SelectedText = lstView_Cliente.SelectedItems[0].SubItems[7].Text.ToString();
                tbTelefone.Text = lstView_Cliente.SelectedItems[0].SubItems[8].Text.ToString();
                tbEmail.Text = lstView_Cliente.SelectedItems[0].SubItems[9].Text.ToString();

                btAtualizar.Enabled = true;
                btCadastrar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("É necessário selecionar uma linha para deleção");
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)  //Atualiza os dados informados  na tela
        {
            bool sucesso = true;
            Cliente c = new Cliente(tbCPF.Text, tbNome.Text, tbEndereco.Text, tbBairro.Text, tbCidade.Text, tbCEP.Text, CbUF.SelectedText, tbTelefone.Text, tbEmail.Text);
            LimparCampos();
            try
            {
                c.AtualizaCliente(c, idCliente);
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

        private void btApagar_Click(object sender, EventArgs e)  // Exclui do banco de dados a informação selecionada na list view
        {
            Cliente C = new Cliente();

            try
            {
                idCliente = int.Parse(lstView_Cliente.SelectedItems[0].Text.ToString());
                C.DeletaRegistro(idCliente); // Deleta o registro a partir do ID selecionado na list view
            }
            catch (Exception ex)
            {
                MessageBox.Show("É necessário selecionar uma linha para deleção");

            }

            carregarListView();
        }

        private void btFecharJanela_Click(object sender, EventArgs e)
        {
            Close(); //Fecha o Form
        }
    }
}