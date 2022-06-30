using System;
using System.Data;
using System.Data.SqlClient;

namespace SimplesWindowsFormsBanco
{
    public class Banco
    {
        private string stringConexao = "Data Source=DESKTOP-2HRD8RN\\SQLEXPRESS; Initial Catalog=usuarios_db;TrustServerCertificate=True;Integrated security = True;";

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

        internal void gravaPessoa(Pessoa pessoa)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into pessoa values (@nome, @idade, @cpf, @ende, @bairro, @cep, @cidade,@email);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@idade", SqlDbType.Int);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@ende", SqlDbType.VarChar);
            command.Parameters.Add("@bairro", SqlDbType.VarChar);
            command.Parameters.Add("@cep", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = pessoa.nome;
            command.Parameters[1].Value = pessoa.idade;
            command.Parameters[2].Value = pessoa.cpf;
            command.Parameters[3].Value = pessoa.end;
            command.Parameters[4].Value = pessoa.bairro;
            command.Parameters[5].Value = pessoa.cep;
            command.Parameters[6].Value = pessoa.cidade;
            command.Parameters[7].Value = pessoa.email;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                fecharConexao();
            }
        }

        internal bool DeletaRegistro(int idPessoa)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from Pessoa where idPessoa = @IdPessoa";
            command.Parameters.Add("@IdPessoa", SqlDbType.Int);
            command.Parameters[0].Value = idPessoa;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                fecharConexao();
            }
        }

        internal void AtualizaPessoaBanco(Pessoa pessoa, int ID)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update Pessoa set  Nome = @Nome, CPF = @CPF, Endereco= @Endereco, Bairro = @Bairro, CEP = @CEP, Cidade = @Cidade, Email = @email where idPessoa = @idPessoa";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@idade", SqlDbType.Int);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@Endereco", SqlDbType.VarChar);
            command.Parameters.Add("@bairro", SqlDbType.VarChar);
            command.Parameters.Add("@cep", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@idPessoa", SqlDbType.Int);
            command.Parameters[0].Value = pessoa.nome;
            command.Parameters[1].Value = pessoa.idade;
            command.Parameters[2].Value = pessoa.cpf;
            command.Parameters[3].Value = pessoa.end;
            command.Parameters[4].Value = pessoa.bairro;
            command.Parameters[5].Value = pessoa.cep;
            command.Parameters[6].Value = pessoa.cidade;
            command.Parameters[7].Value = pessoa.email;
            command.Parameters[8].Value = ID;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                fecharConexao();
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

        internal SqlDataReader CarregaBanco()
        {
            try
            {
                abrirConexao();
                string sqlTexto = "select idPessoa, Nome, Idade, CPF, Endereco, Bairro, CEP, Cidade, Email from Pessoa";
                SqlCommand comando = new SqlCommand(sqlTexto, cn);

                SqlDataReader leitor = comando.ExecuteReader();
                return leitor;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
