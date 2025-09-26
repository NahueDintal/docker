using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Proyecto_ISAUI
{
    public class Cliente
    {
        public DataTable Buscar(string Apellido)
        {
            string sql = "SELECT CodCliente, Apellido, Nombre, NroDoc FROM Cliente WHERE Apellido = @Apellido";

            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection("tu_cadena_de_conexion"))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }

            return tabla;
        }

    }
}
