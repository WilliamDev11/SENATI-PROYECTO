using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class ProductoCN
    {
        //Metodos
        public ProductoCE getBuscarPorId(int idBuscar)
        {
            //Instanciar una clase de la Capa Datos
            ProductoCD productoCD = new ProductoCD();
            //Ejecutar el metodo de la Capa Datos
            ProductoCE productoCE =  productoCD.getBuscarPorId(idBuscar);
            //Retornar el resultado
            return productoCE;
        }
        public List<ProductoCE> getBuscarPorDescripcion(string descripcionBuscar)
        {
            //Instanciar una clase de la Capa Datos
            ProductoCD productoCD = new ProductoCD();
            //Ejecutar el metodo de la Capa Datos
            List<ProductoCE> listaProductosCE = productoCD.getBuscarPorDescripcion(descripcionBuscar);
            //Retornar el resultado
            return listaProductosCE;
        }
        public int setInsertar(ProductoCE productoCE)
        {
            //Instanciar una clase de la Capa Datos
            ProductoCD productoCD = new ProductoCD();
            //Ejecutar el metodo de la Capa Datos
            int nuevoId = productoCD.setInsertar(productoCE);
            //Retornar el resultado
            return nuevoId;
        }
        public void setActualizar(ProductoCE productoCE)
        {
            //Instanciar una clase de la Capa Datos
            ProductoCD productoCD = new ProductoCD();
            //Ejecutar el metodo de la Capa Datos
            productoCD.setActualizar(productoCE);
        }
        public void setEliminar(int idEliminar)
        {
            //Instanciar una clase de la Capa Datos
            ProductoCD productoCD = new ProductoCD();
            //Ejecutar el metodo de la Capa Datos
            productoCD.setEliminar(idEliminar);

        }
    }
}
