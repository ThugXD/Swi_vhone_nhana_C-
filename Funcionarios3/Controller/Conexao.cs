using Funcionarios3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario2
{
    class Conexao
    {
        public static SqlConnection conexao;

        //Construtor da classe Conexao

        public static SqlConnection getConexao()
        {
            conexao = new SqlConnection();
            conexao.ConnectionString = @"Server=SERVER\NAME;database=SharpConnection;Trusted_Connection=True";
            conexao.Open();
            return conexao;
        }

        //Inserir Dados na Base de Dados
        public bool insert(Funcionario funcionario)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConexao(); // Obter a conexão aberta
                    cmd.Parameters.AddWithValue("@codigo", funcionario.Codigo);
                    cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@diasTrabalho", funcionario.DiasTrabalho);
                    cmd.Parameters.AddWithValue("@salario", funcionario.Salario);
                    cmd.CommandText = "INSERT INTO funcionario (codigo, nome, diasTrabalho, salario) VALUES (@codigo, @nome, @diasTrabalho, @salario)";

                    int linhasAfectadas = cmd.ExecuteNonQuery();
                    return linhasAfectadas > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Falha ao inserir dados (SQL): " + sqlEx.Message);
                foreach (SqlError error in sqlEx.Errors)
                {
                    Console.WriteLine("Erro de SQL: " + error.Message);
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao inserir dados: " + ex.Message);
                return false;
            }
        }

        //Listar na tabela
        public List<Funcionario> ListaFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            SqlDataAdapter dt = new SqlDataAdapter("SELECT * FROM funcionario", conexao);
            DataTable lista = new DataTable();
            dt.Fill(lista);
            foreach (DataRow linha in lista.Rows)
            {
                //PErcorer o foreack para listar os dados inserir na tabela
                funcionarios.Add(
                    new Funcionario(int.Parse(linha["codigo"].ToString()),
                    linha["nome"].ToString(),
                    int.Parse(linha["diasTrabalho"].ToString()),
                    double.Parse(linha["salario"].ToString())));
            }

            return funcionarios;
        }

        public bool update(Funcionario funcionario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.Parameters.AddWithValue("@codigo", funcionario.Codigo);
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@diasTrabalho", funcionario.DiasTrabalho);
                cmd.Parameters.AddWithValue("@salario", funcionario.Salario);
                cmd.CommandText = "UPDATE funcionario SET nome = @nome, diasTrabalho = @diasTrabalho, salario = @salario WHERE codigo = @codigo";

                int linhasAfectadas = cmd.ExecuteNonQuery();
                return linhasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao atualizar dados " + ex.Message);
                return false;
            }
        }

        //Deletar 
        public bool delete(int codigo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = getConexao(); // Obter a conexão aberta
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.CommandText = "DELETE FROM funcionario WHERE codigo = @codigo";

                    int linhasAfectadas = cmd.ExecuteNonQuery();
                    return linhasAfectadas > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Falha ao deletar dados (SQL): " + sqlEx.Message);
                foreach (SqlError error in sqlEx.Errors)
                {
                    Console.WriteLine("Erro de SQL: " + error.Message);
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao deletar dados: " + ex.Message);
                return false;
            }
        }


    }
}
