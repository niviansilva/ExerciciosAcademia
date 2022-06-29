using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesafioWFDB
{
    public class BancoDeDados
    {
        private string stringConexao = "Data Source=Notebook\\SQLEXPRESS; Initial Catalog=SisVendaDB;TrustServerCertificate=True;Integrated security = True;";

        private SqlConnection cn;

        private void conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        internal DataTable CarregaProduto(int idproduto)
        {
            DataTable dt = new DataTable();
            try
            { 
            abrirConexao();
            string sqlTexto = "select ID, CodEAN, Nome, Preco, Estoque, CaminhoImagem from Produtos where ID = "+idproduto.ToString();
            SqlCommand comando = new SqlCommand(sqlTexto, cn);

            SqlDataAdapter da = new SqlDataAdapter(comando);
            

            da.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                fecharConexao();
            }

            return dt;
            
        }

        internal void DeletaProduto(int idProduto)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from Produtos where ID = @ID";
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters[0].Value = idProduto;
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

        internal int BuscaIDProduto(string NomeProduto_Produto)
        {
            int ID_Produto = 0;
            abrirConexao();
            string sqlTexto = "select ID from Produtos where Nome='"+NomeProduto_Produto+"'";
            SqlCommand comando = new SqlCommand(sqlTexto, cn);

            SqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                ID_Produto = int.Parse(leitor["ID"].ToString());
            }

            return ID_Produto;
        }

        internal void Atualiza_Estoque(int iD_Venda)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update p set p.estoque =(p.Estoque - Iv.Quantidade) " +
                "from ItemVenda IV join Produtos p " +
                "on p.ID = iV.ID_Produto "+
                "where iv.ID_Venda = @ID_Venda";
            command.Parameters.Add("@ID_Venda", SqlDbType.Int);
            command.Parameters[0].Value = iD_Venda;
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

        internal void GravaItemVenda(int ID_Venda, int ID_Produto, double valorUnitario, int quantidade, double valorTotal)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into ItemVenda (ID_Venda,ID_Produto,ValorUnitario, Quantidade, ValorTotal) values (@ID_Venda,@ID_Produto,@ValorUnitario,@Quantidade,@ValorTotal)";
            command.Parameters.Add("@ID_Venda", SqlDbType.Int);
            command.Parameters.Add("@ID_Produto", SqlDbType.Int);
            command.Parameters.Add("@ValorUnitario", SqlDbType.Money);
            command.Parameters.Add("@Quantidade", SqlDbType.Int);
            command.Parameters.Add("@ValorTotal", SqlDbType.Money);
            command.Parameters[0].Value = ID_Venda;
            command.Parameters[1].Value = ID_Produto;
            command.Parameters[2].Value = valorUnitario;
            command.Parameters[3].Value = quantidade;
            command.Parameters[4].Value = valorTotal;
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

        internal int GravaVenda(Vendas v)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Vendas (ID_Cliente,ValorTotal) values (@ID_Cliente,@ValorTotal)";
            command.Parameters.Add("@ID_Cliente", SqlDbType.Int);
            command.Parameters.Add("@ValorTotal", SqlDbType.Money);
            command.Parameters[0].Value = v.ID_Cliente;
            command.Parameters[1].Value = v.ValorTotal;
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

            int ID_Venda = 0;
            abrirConexao();
            string sqlTexto = "select max(ID) as ID_Venda from Vendas";
            SqlCommand comando = new SqlCommand(sqlTexto, cn);

            SqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                ID_Venda = int.Parse(leitor["ID_Venda"].ToString());
            }

            return ID_Venda;



        }

        internal SqlDataReader CarregaProduto()
        {
            try
            {
                abrirConexao();
                string sqlTexto = "select ID, Nome, Preco, Estoque from Produtos";
                SqlCommand comando = new SqlCommand(sqlTexto, cn);

                SqlDataReader leitor = comando.ExecuteReader();
                return leitor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal SqlDataReader BuscaProduto(int idProduto)
        {
            try
            {
                abrirConexao();
                string sqlTexto = "select ID,Nome,Preco, Estoque from Produtos where ID="+idProduto.ToString();
                SqlCommand comando = new SqlCommand(sqlTexto, cn);

                SqlDataReader leitor = comando.ExecuteReader();
                return leitor;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        internal void AtualizaProduto(Produtos p, int idProduto)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update produtos set CodEAN = @codEAN, Nome = @Nome, Preco= @Preco, Estoque = @Estoque, CaminhoImagem =@CaminhoImagem where ID = @ID";
            command.Parameters.Add("@CodEAN", SqlDbType.BigInt);
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@Preco", SqlDbType.Money);
            command.Parameters.Add("@Estoque", SqlDbType.Int);
            command.Parameters.Add("@CaminhoImagem", SqlDbType.VarChar);
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters[0].Value = p.CodEAN;
            command.Parameters[1].Value = p.NomeProduto;
            command.Parameters[2].Value = p.Preco;
            command.Parameters[3].Value = p.Estoque;
            command.Parameters[4].Value = p.CaminhoImagem;
            command.Parameters[5].Value = idProduto;
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

        internal void GravaProduto(Produtos p)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Produtos (CodEAN, Nome,Preco,Estoque,CaminhoImagem) values (@CodEAN,@Nome,@Preco,@Estoque,@CaminhoImagem)";
            command.Parameters.Add("@CodEAN", SqlDbType.BigInt);
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@Preco", SqlDbType.Money);
            command.Parameters.Add("@Estoque", SqlDbType.Int);
            command.Parameters.Add("@CaminhoImagem", SqlDbType.VarChar);
            command.Parameters[0].Value = p.CodEAN;
            command.Parameters[1].Value = p.NomeProduto;
            command.Parameters[2].Value = p.Preco;
            command.Parameters[3].Value = p.Estoque;
            command.Parameters[4].Value = p.CaminhoImagem;            
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

        internal void gravaCliente(Cliente c)
        {
            abrirConexao(); //Método que abre a conexão com o banco de dados
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Clientes (CPF,Nome,Endereco,Bairro,Cidade,CEP,UF,Telefone,Email) values (@CPF,@Nome,@Endereco,@Bairro,@Cidade,@CEP,@UF,@Telefone,@Email)";  //Script de insert
            command.Parameters.Add("@CPF", SqlDbType.VarChar);
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@Endereco", SqlDbType.VarChar);
            command.Parameters.Add("@Bairro", SqlDbType.VarChar);
            command.Parameters.Add("@Cidade", SqlDbType.VarChar);
            command.Parameters.Add("@CEP", SqlDbType.VarChar);
            command.Parameters.Add("@UF", SqlDbType.Char);
            command.Parameters.Add("@Telefone", SqlDbType.VarChar);
            command.Parameters.Add("@Email", SqlDbType.VarChar);
            command.Parameters[0].Value = c.CPF;
            command.Parameters[1].Value = c.Nome;
            command.Parameters[2].Value = c.Endereco;
            command.Parameters[3].Value = c.Bairro;
            command.Parameters[4].Value = c.Cidade;
            command.Parameters[5].Value = c.CEP;
            command.Parameters[6].Value = c.UF;
            command.Parameters[7].Value = c.Telefone;
            command.Parameters[8].Value = c.Email;
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

        internal void DeletaRegistro(int idCliente)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from Clientes where ID = @ID";
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters[0].Value = idCliente;
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

        internal void AtualizaPessoaBanco(Cliente c, int idCliente)
        {
            abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update Clientes set CPF = @CPF, Nome = @Nome, Endereco = @Endereco, Bairro = @Bairro," +
                " Cidade = @Cidade, CEP = @CEP, UF = @UF, Telefone = @Telefone, Email = @Email where ID = @ID";
            command.Parameters.Add("@CPF", SqlDbType.VarChar);
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@Endereco", SqlDbType.VarChar);
            command.Parameters.Add("@Bairro", SqlDbType.VarChar);
            command.Parameters.Add("@Cidade", SqlDbType.VarChar);
            command.Parameters.Add("@CEP", SqlDbType.VarChar);
            command.Parameters.Add("@UF", SqlDbType.VarChar);
            command.Parameters.Add("@Telefone", SqlDbType.VarChar);
            command.Parameters.Add("@Email", SqlDbType.VarChar);
            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters[0].Value = c.CPF;
            command.Parameters[1].Value = c.Nome;
            command.Parameters[2].Value = c.Endereco;
            command.Parameters[3].Value = c.Bairro;
            command.Parameters[4].Value = c.Cidade;
            command.Parameters[5].Value = c.CEP;
            command.Parameters[6].Value = c.UF;
            command.Parameters[7].Value = c.Telefone;
            command.Parameters[8].Value = c.Email;
            command.Parameters[9].Value = idCliente;
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

        internal SqlDataReader CarregaBanco()
        {
            try
            {
                abrirConexao();
                string sqlTexto = "select ID, CPF, Nome, Endereco, Bairro, Cidade, UF,CEP, Telefone, Email from Clientes";
                SqlCommand comando = new SqlCommand(sqlTexto, cn);

                SqlDataReader leitor = comando.ExecuteReader();
                return leitor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataSet CarregaComboClientes()
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand("select ID,Nome from Clientes", cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Clientes");//adaptar preenche o datatable com os dados do command

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
        public DataSet CarregaComboProdutos()
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand("select ID,Nome from Produtos", cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Produtos");//adaptar preenche o datatable com os dados do command

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
    }
}
