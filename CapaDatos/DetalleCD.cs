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
    public class DetalleCD
    {
        public void setInsertar(DetalleCE detalleCE, SqlConnection cnx, SqlTransaction tran)
        {
            SqlCommand cmd = cnx.CreateCommand();
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO Detalle (idVenta, idProducto, cantidad) VALUES (@idVenta, @idProducto, @cantidad);";
            cmd.Parameters.AddWithValue("@idVenta", detalleCE.IdVenta);
            cmd.Parameters.AddWithValue("@idProducto", detalleCE.IdProducto);
            cmd.Parameters.AddWithValue("@cantidad", detalleCE.Cantidad);

            cmd.ExecuteNonQuery();
        }

    }
}
