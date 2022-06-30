using System.Data;
using System.Data.SqlClient;

namespace Windows_BD_Glicemia
{
    public class Banco
    {
        //private string stringConexao = "Data Source=localhost; Initial Catalog=ATOSUFN; User ID=usuario; password='senha';language=Portuguese";
        string stringConexao = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=glicemia_db;TrustServerCertificate=True;Integrated Security=True";
        private SqlConnection cn;

        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                //faz algo se deu erro
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
        public DataSet CarregaCombo()
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand("Select idPaciente, nome from Paciente", cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Paciente");//adaptar preenche o datatable com os dados do command

                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
        public SqlDataReader CarregaBanco()
        {
            try
            {
                abrirConexao();
                string sqlTexto = "SELECT m.idMedidaGlicemia, m.valorGlicemia, m.dataMedida, p.Nome FROM MedidaGlicemia m inner join Paciente p on m.idPaciente = p.idPaciente";
                SqlCommand comando = new SqlCommand(sqlTexto, cn);

                SqlDataReader leitor = comando.ExecuteReader();
                return leitor;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        internal void DeletaMarcacao(string idMedidaGlicemia)
        {
            try
            {
                abrirConexao();
                string sqlTexto = "DELETE from MedidaGlicemia where idMedidaGlicemia = @idMedidaGlicemia";
                SqlCommand comando = new SqlCommand(sqlTexto, cn);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);


                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                fecharConexao();
            }
        }

        internal void GravaGlicemia(int valorGlicemia, DateTime data, int idPaciente)
        {
            try
            {
                abrirConexao();
                string sqlTexto = "INSERT INTO MedidaGlicemia (valorGlicemia, dataMedida, idPaciente) VALUES(@valorGlicemia, @dataMedida, @idPaciente)";
                SqlCommand comando = new SqlCommand(sqlTexto, cn);
                //  comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", data);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fecharConexao();
            }
        }
    }
}