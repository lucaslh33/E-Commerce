using System.Data;
using System.Data.SqlClient;
using System;
using System.Text;

namespace Ecommerce
{
    internal class Conexao
    {
        public static string connectionString =
            "Server=localhost;Database=Ecommerce;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection ObterConexao()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
