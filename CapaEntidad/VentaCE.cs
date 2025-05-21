using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VentaCE
    {
        //Propiedades
        private int id;
        private DateTime fecventa;
        private int idCliente;

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
        public DateTime Fecventa
        {
            get
            {
                return this.fecventa;
            }
            set
            {
                this.fecventa = value;
            }
        }
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                this.idCliente = value;
            }
        }

        //Constructores
        public VentaCE()
        {
            this.id = 0;
            this.fecventa = DateTime.Now;
            this.idCliente = 0;
        }
        public VentaCE(int id, DateTime fecventa,
            int idCliente)
        {
            this.id = id;
            this.fecventa = fecventa;
            this.idCliente = idCliente;
        }
    }
}
