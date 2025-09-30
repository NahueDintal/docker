using Microsoft.Data.SqlClient;
using System.Data;

namespace SistemaFact.Clases
{
    public static class cDb
    {
        public static DataTable Select(string sql)
        {
            using var con = new SqlConnection(cConexion.GetConexion());
            using var comando = new SqlCommand(sql, con);
            using var da = new SqlDataAdapter(comando);
            var ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public static int Grabar(string sql)
        {
            using var con = new SqlConnection(cConexion.GetConexion());
            using var comando = new SqlCommand(sql, con);
            con.Open();
            return comando.ExecuteNonQuery();
        }

        // Nuevo método con parámetros para evitar SQL injection
        public static int GrabarConParametros(string sql, params SqlParameter[] parameters)
        {
            using var con = new SqlConnection(cConexion.GetConexion());
            using var comando = new SqlCommand(sql, con);
            comando.Parameters.AddRange(parameters);
            con.Open();
            return comando.ExecuteNonQuery();
        }
    }
}
