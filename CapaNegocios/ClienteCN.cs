using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class ClienteCN
    {
        //Metodos
        public ClienteCE getBuscarPorId(int idBuscar)
        {
            //Instanciar una clase de la Capa Datos
            ClienteCD clienteCD = new ClienteCD();
            //Ejecutar el metodo de la Capa Datos
            ClienteCE clienteCE = clienteCD.getBuscarPorId(idBuscar);
            //Retornar el resultado
            return clienteCE;
        }
        public List<ClienteCE> getBuscarPorNombre(string nombreBuscar)
        {
            //Instanciar una clase de la Capa Datos
            ClienteCD clienteCD = new ClienteCD();
            //Ejecutar el metodo de la Capa Datos
            List<ClienteCE> listaClientesCE = clienteCD.getBuscarPorNombre(nombreBuscar);
            //Retornar el resultado
            return listaClientesCE;
        }
        public int setInsertar(ClienteCE clienteCE)
        {
            //Instanciar una clase de la Capa Datos
            ClienteCD clienteCD = new ClienteCD();
            //Ejecutar el metodo de la Capa Datos
            int nuevoId = clienteCD.setInsertar(clienteCE);
            //Retornar el resultado
            return nuevoId;
        }
        public void setActualizar(ClienteCE clienteCE)
        {
            //Instanciar una clase de la Capa Datos
            ClienteCD clienteCD = new ClienteCD();
            //Ejecutar el metodo de la Capa Datos
            clienteCD.setActualizar(clienteCE);
        }
        public void setEliminar(int idEliminar)
        {
            //Instanciar una clase de la Capa Datos
            ClienteCD clienteCD = new ClienteCD();
            //Ejecutar el metodo de la Capa Datos
            clienteCD.setEliminar(idEliminar);

        }

    }
}
