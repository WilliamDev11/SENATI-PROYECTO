using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class VentaCD
    {
        public int setInsertar(VentaCE ventaCE, SqlConnection cnx, SqlTransaction tran)
        {
            SqlCommand cmd = cnx.CreateCommand(); // Usamos la conexión recibida
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO Venta (fecventa, idCliente) VALUES (@fecventa, @idCliente);";
            cmd.Parameters.AddWithValue("@fecventa", ventaCE.Fecventa);
            cmd.Parameters.AddWithValue("@idCliente", ventaCE.IdCliente);

            cmd.ExecuteNonQuery();

            // Obtener el nuevo ID
            cmd.CommandText = "SELECT MAX(id) AS nuevoId FROM Venta;";
            SqlDataReader dr = cmd.ExecuteReader();

            int nuevoId = 0;
            if (dr.Read())
            {
                nuevoId = Convert.ToInt32(dr["nuevoId"]);
            }
            dr.Close(); // cerrar el reader

            return nuevoId;
        }

        
    }
}
