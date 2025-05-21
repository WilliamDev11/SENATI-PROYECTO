using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PrincipalCP : Form
    {
        public PrincipalCP()
        {
            InitializeComponent();

            //Convertir este form en un MDI: Interfaz de Multiples Documentos
            this.IsMdiContainer = true;
            //Ubicar en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
            //Maximizar el formulario
            ////this.WindowState = FormWindowState.Maximized;
        }


        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            //Instanciar
            ProductoCP productoCP = new ProductoCP();
            //Convertir el Formulario en hijo
            productoCP.MdiParent = this;
            //Centrar
            productoCP.StartPosition = FormStartPosition.CenterScreen;
            //Maximizar
            productoCP.WindowState = FormWindowState.Maximized;
            //Mostrar el objeto
            productoCP.Show();
            */

            //PASO 3: Utilizar el encapsulado de la propiedad

            ProductoCP.Instancia.MdiParent = this;

            ProductoCP.Instancia.StartPosition = FormStartPosition.CenterScreen;

            ProductoCP.Instancia.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void aAAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteCP.Instancia.MdiParent = this;

            ClienteCP.Instancia.StartPosition = FormStartPosition.CenterScreen;

            ClienteCP.Instancia.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaDetalleCP.Instancia.MdiParent = this;

            VentaDetalleCP.Instancia.StartPosition = FormStartPosition.CenterScreen;

            VentaDetalleCP.Instancia.Show();
        }
    }
}
