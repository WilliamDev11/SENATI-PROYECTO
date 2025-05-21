using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class VentaCN
    {

        public void GuardarVentaConDetalles(VentaCE ventaCE, List<DetalleCE> listaDetallesCE)
        {
            SqlConnection cnx = ConexionCD.getConectarSqlServer();
            cnx.Open();
            SqlTransaction tran = cnx.BeginTransaction();

            try
            {
                VentaCD ventaCD = new VentaCD();
                int nuevoIdVenta = ventaCD.setInsertar(ventaCE, cnx, tran);

                DetalleCD detalleCD = new DetalleCD();
                foreach (DetalleCE detalleCE in listaDetallesCE)
                {
                    detalleCE.IdVenta = nuevoIdVenta;
                    detalleCD.setInsertar(detalleCE, cnx, tran);
                }

                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();
                throw;
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}