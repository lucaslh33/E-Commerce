using System.Data;
using Microsoft.Data.SqlClient;

namespace Ecommerce
{
    class Conexao
    {
        private string stringConexao = @"Server=localhost;Database=ecommerce;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection(stringConexao);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
    
}
