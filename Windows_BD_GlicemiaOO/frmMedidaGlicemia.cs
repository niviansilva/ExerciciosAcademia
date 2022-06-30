using System.Data.SqlClient;

namespace Windows_BD_Glicemia
{
    public partial class frmMedidaGlicemia : Form
    {
        public frmMedidaGlicemia()
        {
            InitializeComponent();
            carregarListView();
        }

        private void carregarListView()
        {
            Banco b = new Banco();

            try
            {

                cbPaciente.DisplayMember = "Nome";
                cbPaciente.ValueMember = "idPaciente";
                cbPaciente.DataSource = b.CarregaCombo().Tables["Paciente"];

                listView_medidasGlicemias.Items.Clear();

                SqlDataReader dr = b.CarregaBanco();

                int i = 0;
                while (dr.Read())
                {
                    listView_medidasGlicemias.Items.Add(dr["idMedidaGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(dr["valorGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(dr["dataMedida"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(dr["Nome"].ToString());
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

        private void btConectar_Click(object sender, EventArgs e)
        {
            carregarListView();
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            Banco b = new Banco();

            try
            {
                //capturar valores das variáveis
                int valorGlicemia = int.Parse(textBox_ValorGlicemico.Text);
                string dataMedida = dtPicker.Value.Month.ToString().PadLeft(2, '0') + "/" + dtPicker.Value.Day.ToString().PadLeft(2, '0') + "/" + dtPicker.Value.Year.ToString();
                int idPaciente = int.Parse(cbPaciente.SelectedValue.ToString());
                DateTime Data = DateTime.Parse(dataMedida);

                b.GravaGlicemia(valorGlicemia, Data, idPaciente);

                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao cadastrar" + ex.Message.ToString(), "Erro!");
            }

            //recarregar ListView
            carregarListView();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            string idMedidaGlicemia = "";
            bool continua = true;

            try
            {
                idMedidaGlicemia = listView_medidasGlicemias.SelectedItems[0].Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("É necessário selecionar uma linha para deleção");
                continua = false;
            }

            if (continua)
            {
                Banco b = new Banco();
                try
                {


                    b.DeletaMarcacao(idMedidaGlicemia);

                    MessageBox.Show("Exclusão realizada com sucesso", "Sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao deletar" + ex.Message.ToString(), "Erro!");
                }
                //recarregar ListView
                carregarListView();

            }
        }

    }
}