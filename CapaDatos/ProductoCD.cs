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
    public class ProductoCD
    {
        //Metodos CRUD
        public ProductoCE getBuscarPorId(int idBuscar)
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
            cmd.CommandText = "select * from producto where id=@idBuscar";
            //Pasar valores a los parametros sql
            cmd.Parameters.AddWithValue("@idBuscar", idBuscar);

            //Ejecutar el comando SQL

            //cmd.ExecuteNonQuery(); //INSERT - UPDATE - DELETE
            SqlDataReader dr = cmd.ExecuteReader(); //SELECT

            //Mover el puntero de registros a la siguente fila
            bool existeFila = dr.Read();

            //Instanciar un ProductoCE para almacenar los resultados
            ProductoCE productoCE = new ProductoCE();

            //Determinar si hay fila
            if (existeFila)
            {
                //Leer los valores de la fila
                productoCE.Id = Convert.ToInt32(dr["id"]);
                productoCE.Descripcion = Convert.ToString(dr["descripcion"]);
                productoCE.Categoria = Convert.ToString(dr["categoria"]);
                productoCE.Precio = Convert.ToDouble(dr["precio"]);
            }
            else
            {
                //Asignar valores predeterminados
                productoCE.Id = 0;
                productoCE.Descripcion = "";
                productoCE.Categoria = "";
                productoCE.Precio = 0;
            }

            //Cerrar la conexion
            cnx.Close();

            //Retornar el productoCE
            return productoCE;

        }
        public List<ProductoCE> getBuscarPorDescripcion(string descripcionBuscar)
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
            cmd.CommandText = "select * from producto where descripcion LIKE '%'+@descripcionBuscar+'%';";
            //Pasar valores a los parametros sql
            cmd.Parameters.AddWithValue("@descripcionBuscar", descripcionBuscar);

            //Ejecutar el comando SQL
            //cmd.ExecuteNonQuery(); //INSERT - UPDATE - DELETE
            SqlDataReader dr = cmd.ExecuteReader(); //SELECT

            //Declarar la lista de productos
            List<ProductoCE> listaProductos = new List<ProductoCE>();

            //Mover el puntero de registros a la siguente fila hasta que no exista filas
            while (dr.Read())
            {
                //Instanciar un ProductoCE para almacenar los resultados
                ProductoCE productoCE = new ProductoCE();

                //Leer los valores de la fila
                productoCE.Id = Convert.ToInt32(dr["id"]);
                productoCE.Descripcion = Convert.ToString(dr["descripcion"]);
                productoCE.Categoria = Convert.ToString(dr["categoria"]);
                productoCE.Precio = Convert.ToDouble(dr["precio"]);

                //Almacenar el productoCE en una lista
                listaProductos.Add(productoCE);
            }

            //Cerrar la conexion
            cnx.Close();

            //Retornar la lista de productos
            return listaProductos;
        }
        public int setInsertar(ProductoCE productoCE)
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
            cmd.CommandText = "insert into producto (descripcion, categoria, precio) values (@descripcion, @categoria, @precio);";
            //Pasar valores a los parametros sql
            cmd.Parameters.AddWithValue("@descripcion", productoCE.Descripcion);
            cmd.Parameters.AddWithValue("@categoria", productoCE.Categoria);
            cmd.Parameters.AddWithValue("@precio", productoCE.Precio);

            //Ejecutar el comando SQL

            cmd.ExecuteNonQuery(); //INSERT - UPDATE - DELETE
            //SqlDataReader dr = cmd.ExecuteReader(); //SELECT

            //--- OBTENER EL NUEVO ID ---
            //Preparar la consulta SQL del comando
            cmd.CommandText = "select max(id) as nuevoId from producto;";

            //Ejecutar el comando SQL

            //cmd.ExecuteNonQuery(); //INSERT - UPDATE - DELETE
            SqlDataReader dr = cmd.ExecuteReader(); //SELECT

            //Mover el puntero de registros a la siguente fila
            bool existeFila = dr.Read();

            //Declarar variable para el nuevo ID
            int nuevoId;

            //Determinar si hay fila
            if (existeFila)
            {
                //Leer los valores de la fila
                nuevoId = Convert.ToInt32(dr["nuevoId"]);
            }
            else
            {
                //Asignar valores predeterminados
                nuevoId = 0;
            }

            //Cerrar la conexion
            cnx.Close();

            //Retornar el productoCE
            return nuevoId;
        }
        public void setActualizar(ProductoCE productoCE)
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
            cmd.CommandText = "update producto set descripcion=@descripcion, categoria=@categoria, precio=@precio where id=@id;";
            //Pasar valores a los parametros sql
            cmd.Parameters.AddWithValue("@id", productoCE.Id);
            cmd.Parameters.AddWithValue("@descripcion", productoCE.Descripcion);
            cmd.Parameters.AddWithValue("@categoria", productoCE.Categoria);
            cmd.Parameters.AddWithValue("@precio", productoCE.Precio);

            //Ejecutar el comando SQL
            cmd.ExecuteNonQuery(); //INSERT - UPDATE - DELETE
            //SqlDataReader dr = cmd.ExecuteReader(); //SELECT

            //Cerrar la conexion
            cnx.Close();
        }
        public void setEliminar(int idEliminar)
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
            cmd.CommandText = "delete from producto where id=@idEliminar;";
            //Pasar valores a los parametros sql
            cmd.Parameters.AddWithValue("@idEliminar", idEliminar);

            //Ejecutar el comando SQL
            cmd.ExecuteNonQuery(); //INSERT - UPDATE - DELETE
            //SqlDataReader dr = cmd.ExecuteReader(); //SELECT

            //Cerrar la conexion
            cnx.Close();
        }
    }
}
