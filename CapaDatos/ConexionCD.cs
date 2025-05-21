using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar los namespaces
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionCD
    {
        public static SqlConnection getConectarSqlServer()
        {
            //Instancia del generador de cadenas
            SqlConnectionStringBuilder objGeneradorCadena = new SqlConnectionStringBuilder();
            //Parametros de conexion
            objGeneradorCadena.DataSource = "localhost"; //Servidor de BD
            objGeneradorCadena.InitialCatalog = "BD402"; //BD
            objGeneradorCadena.UserID = "sa";
            objGeneradorCadena.Password = "1234";

            //Recoger la cadena de conexion
            string cadena = objGeneradorCadena.ConnectionString;
            //Data Source = localhost; Initial Catalog = BD402; User ID = sa; Password = 1234

            //Crear una conexion
            SqlConnection objConexion = new SqlConnection(cadena);

            //Retornar el obj de conexion
            return objConexion;
        }
    }
}
