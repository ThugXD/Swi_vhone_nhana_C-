using ConexaoBD.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD.Controller
{
    class Conexao
    {
        public static SqlConnection conexao;

        public static SqlConnection getConexao()
        {
            try
            {
                conexao = new SqlConnection();
                conexao.ConnectionString = @"Server=THUGXD\SQLSERVERTHUGXD; database=ValterDados; Trusted_Connection=True";
                conexao.Open();
                Console.WriteLine("Conexao feita com sucesso");
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);

            }
            return conexao;
        }

        public bool inserirDados(DadosValter dadosValter)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.Parameters.AddWithValue("@nome", dadosValter.Nome);
            cmd.Parameters.AddWithValue("@idade", dadosValter.Idade);
            cmd.Parameters.AddWithValue("@bi", dadosValter.Bi);
            cmd.Parameters.AddWithValue("@bairro", dadosValter.Bairro);
            cmd.CommandText = "INSERT INTO DadosValter (Nome, Idade, Bi, Bairro) VALUES(@nome, @idade, @bi, @bairro)";

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool ActualizarDados(DadosValter dadosValter)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.Parameters.AddWithValue("@nome", dadosValter.Nome);
            cmd.Parameters.AddWithValue("@idade", dadosValter.Idade);
            cmd.Parameters.AddWithValue("@bi", dadosValter.Bi);
            cmd.Parameters.AddWithValue("@bairro", dadosValter.Bairro);
            cmd.CommandText = "UPDATE DadosValter set Nome=@nome, Idade=@idade, Bi=@bi, Bairro=@bairro";

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(DadosValter dadosVAlter)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.Parameters.AddWithValue("@nome", dadosVAlter.Nome);
            cmd.CommandText = "DELETE FROM DadosValter where Nome=@nome";

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<DadosValter> listaValter()
        {
            List<DadosValter> dadosThug = new List<DadosValter>();
            SqlDataAdapter dt = new SqlDataAdapter("SELECT * FROM DadosValter", conexao);
            DataTable lista = new DataTable();
            dt.Fill(lista);
            foreach(DataRow linha in lista.Rows)
            {
                dadosThug.Add(
                    new DadosValter(linha["Nome"].ToString(), 
                    int.Parse(linha["Idade"].ToString()), 
                    int.Parse(linha["Bi"].ToString()), 
                    linha["Bairro"].ToString()));
            }

            return dadosThug;
        }
    }
}
