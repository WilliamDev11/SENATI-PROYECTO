using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar los namespaces
using System.Data.SqlClient;
using System.Data;

using CapaEntidad;

namespace CapaDatos
{
    public class ClienteCD
    {
        //Metodos: CRUD
        public ClienteCE getBuscarPorId(int idBuscar)
        {
            SqlConnection cnx = ConexionCD.getConectarSqlServer();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Cliente where id=@idBuscar";
            //Pasar valores a los parametros sql
            cmd.Parameters.AddWithValue("@idBuscar", idBuscar);

            //Ejecutar el comando SQL

            SqlDataReader dr = cmd.ExecuteReader(); //SELECT
            bool existeFila = dr.Read();

            ClienteCE clienteCE = new ClienteCE();

            //Determinar si hay fila
            if (existeFila)
            {
                //Leer los valores de la fila
                clienteCE.Id = Convert.ToInt32(dr["id"]);
                clienteCE.Nombre = Convert.ToString(dr["nombre"]);
                clienteCE.Numruc = Convert.ToString(dr["numruc"]);
                clienteCE.Direccion = Convert.ToString(dr["direccion"]);
                clienteCE.Telefono = Convert.ToString(dr["telefono"]);
            }
            else
            {
                //Asignar valores predeterminados
                clienteCE.Id = 0;
                clienteCE.Nombre = "";
                clienteCE.Numruc = "";
                clienteCE.Direccion = "";
                clienteCE.Telefono = "";
            }

            cnx.Close();
            return clienteCE;

        }
        public List<ClienteCE> getBuscarPorNombre(string nombreBuscar)
        {
            SqlConnection cnx = ConexionCD.getConectarSqlServer();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //Preparar la consulta SQL del comando
            cmd.CommandText = "select * from cliente where nombre LIKE '%'+@nombreBuscar+'%';";
            //Pasar valores a los parametros sql
            cmd.Parameters.AddWithValue("@nombreBuscar", nombreBuscar);
            SqlDataReader dr = cmd.ExecuteReader(); //SELECT

            List<ClienteCE> listaClienteCE = new List<ClienteCE>();

            //Mover el puntero 
            while (dr.Read())
            {
                ClienteCE clienteCE = new ClienteCE();

                //Leer los valores de la fila
                clienteCE.Id = Convert.ToInt32(dr["id"]);
                clienteCE.Nombre = Convert.ToString(dr["nombre"]);
                clienteCE.Numruc = Convert.ToString(dr["numruc"]);
                clienteCE.Direccion = Convert.ToString(dr["direccion"]);
                clienteCE.Telefono = Convert.ToString(dr["telefono"]);

                //Almacenar el clienteCE en una lista
                listaClienteCE.Add(clienteCE);
            }

            cnx.Close();
            return listaClienteCE;
        }
        public int setInsertar(ClienteCE clienteCE)
        {
            //Establecer la conexion
            SqlConnection cnx = ConexionCD.getConectarSqlServer();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //Preparar la consulta SQL del comando
            cmd.CommandText = "insert into cliente (nombre, numruc, " +
                "direccion, telefono) values (@nombre, @numruc, @direccion, " +
                "@telefono);";
            //Pasar valores a los parametros sql
            cmd.Parameters.AddWithValue("@nombre", clienteCE.Nombre);
            cmd.Parameters.AddWithValue("@numruc", clienteCE.Numruc);
            cmd.Parameters.AddWithValue("@direccion", clienteCE.Direccion);
            cmd.Parameters.AddWithValue("@telefono", clienteCE.Telefono);

            //Ejecutar el comando SQL
            cmd.ExecuteNonQuery(); //INSERT - UPDATE - DELETE
            cmd.CommandText = "select max(id) as nuevoId from cliente;";

            SqlDataReader dr = cmd.ExecuteReader(); //SELECT
            bool existeFila = dr.Read();
            int nuevoId;
            //Determinar si hay fila
            if (existeFila)
            {
                nuevoId = Convert.ToInt32(dr["nuevoId"]);
            }
            else
            {
                nuevoId = 0;
            }

            cnx.Close();
            return nuevoId;
        }
        public void setActualizar(ClienteCE clienteCE)
        {
            //Establecer la conexion
            SqlConnection cnx = ConexionCD.getConectarSqlServer();
            //Abrir la conexion
            cnx.Open();
            //Crear un comando para la instruccion SQL
            SqlCommand cmd = cnx.CreateCommand();
            //Tipar el comando
            cmd.CommandType = CommandType.Text;
            //Preparar la consulta SQL del comando
            cmd.CommandText = "update cliente set nombre=@nombre, " +
                "numruc=@numruc, direccion=@direccion, telefono=@telefono " +
                "where id=@id;";
            //Pasar valores a los parametros sql
            cmd.Parameters.AddWithValue("@id", clienteCE.Id);
            cmd.Parameters.AddWithValue("@nombre", clienteCE.Nombre);
            cmd.Parameters.AddWithValue("@numruc", clienteCE.Numruc);
            cmd.Parameters.AddWithValue("@direccion", clienteCE.Direccion);
            cmd.Parameters.AddWithValue("@telefono", clienteCE.Telefono);

            cmd.ExecuteNonQuery(); //INSERT - UPDATE - DELETE
            cnx.Close();
        }
        public void setEliminar(int idEliminar)
        {
            //Establecer la conexion
            SqlConnection cnx = ConexionCD.getConectarSqlServer();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //Preparar la consulta SQL del comando
            cmd.CommandText = "delete from cliente where id=@idEliminar;";
            cmd.Parameters.AddWithValue("@idEliminar", idEliminar);

            cmd.ExecuteNonQuery(); //INSERT - UPDATE - DELETE
            cnx.Close();
        }

    }
}
