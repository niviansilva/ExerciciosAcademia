using System.Configuration;
using System.Data.SqlClient;

namespace Windows_BD_Glicemia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;

        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //string sqlTexto = "SELECT [MedidaGlicemia].idMedidaGlicemia, [MedidaGlicemia].valorGlicemia, [MedidaGlicemia].dataMedida, [Paciente].nome FROM MedidaGlicemia, Paciente WHERE[MedidaGlicemia].idPaciente = [Paciente].idPaciente";
                string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                listView_medidasGlicemias.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                    //listView_medidasGlicemias.Items[i].SubItems.Add(leitor["nome"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                    i++;
                }
                conexao.Close();
                btConectar.Enabled = false;
                MessageBox.Show("Banco conectado com sucesso!", "Atenção");
            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }

        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            carregarListView();
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idMedidaGlicemia = int.Parse(textBox_IdGlicemia.Text);
                int valorGlicemia = int.Parse(textBox_ValorGlicemico.Text);
                string dataMedida = textBox_DataMedicao.Text;
                int idPaciente = int.Parse(textBox_IdPaciente.Text);

                //gerar sentenças SQL
                string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {

                string idMedidaGlicemia = listView_medidasGlicemias.SelectedItems[0].Text.ToString();
                string sqlTexto = "DELETE from MedidaGlicemia where idMedidaGlicemia = @idMedidaGlicemia";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);


                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();

        }

    }
}