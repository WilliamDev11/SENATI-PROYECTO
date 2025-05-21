using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleCE
    {
        //Propiedades
        private int id;
        private int idVenta;
        private int idProducto;
        private int cantidad;

        //Encapsulamiento
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public int IdVenta
        {
            get
            {
                return this.idVenta;
            }
            set
            {
                this.idVenta = value;
            }
        }
        public int IdProducto
        {
            get
            {
                return this.idProducto;
            }
            set
            {
                this.idProducto = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        //Constructores
        public DetalleCE()
        {
            this.id = 0;
            this.idVenta = 0;
            this.idProducto = 0;
            this.cantidad = 0; 
        }
        public DetalleCE(int id, int idVenta, int idProducto, int cantidad)
        {
            this.id = id;
            this.idVenta = idVenta;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
    }
}
