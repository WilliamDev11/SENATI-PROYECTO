using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class VentaDetalleCP : Form
    {
        //Propiedades
        //PASO 1: Declarar una propiedad de control para las instancias
        private static VentaDetalleCP instancia = null;

        //PASO 2: Encapsular la propiedad "instancia" de solo lectura (get)
        public static VentaDetalleCP Instancia
        {
            get
            {
                //Si la instancia es NULL (nunca se ha instanciado)
                //o Si la instancia se ha Eliminado (IsDisposed)
                if (instancia == null || instancia.IsDisposed)
                {
                    //Crear la instancia
                    instancia = new VentaDetalleCP();
                }

                return instancia;
            }

        }
        public VentaDetalleCP()
        {
            InitializeComponent();
        }

        private void BuscarClientebtn_Click(object sender, EventArgs e)
        {
            int idBuscar = Convert.ToInt32(IdClientetxt.Text);
            ClienteCN clienteCN = new ClienteCN();
            ClienteCE clienteCE = clienteCN.getBuscarPorId(idBuscar);

            ClienteNombretxt.Text = clienteCE.Nombre;
        }

        private void BuscarProductobtn_Click(object sender, EventArgs e)
        {
            int idBuscar = Convert.ToInt32(IdProductotxt.Text);
            ProductoCN productoCN = new ProductoCN();
            ProductoCE productoCE = productoCN.getBuscarPorId(idBuscar);

            // Mostrar descripción y precio del producto
            ProductoDescripciontxt.Text = productoCE.Descripcion;
            Preciotxt.Text = productoCE.Precio.ToString("0.00"); 
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            // Obtener datos
            int idProducto = Convert.ToInt32(IdProductotxt.Text);
            string descripcion = ProductoDescripciontxt.Text;
            decimal precio = Convert.ToDecimal(Preciotxt.Text);
            int cantidad = Convert.ToInt32(Cantidadtxt.Text);
            decimal totalProducto = precio * cantidad;

            if (dgvDetalleVentas.Columns.Count == 0)
            {
                dgvDetalleVentas.Columns.Add("IdProducto", "ID Producto");
                dgvDetalleVentas.Columns.Add("Descripcion", "Descripción");
                dgvDetalleVentas.Columns.Add("Precio", "Precio");
                dgvDetalleVentas.Columns.Add("Cantidad", "Cantidad");
                dgvDetalleVentas.Columns.Add("Total", "Total");
            }

            // Agregar la fila al dgv
            dgvDetalleVentas.Rows.Add(idProducto, descripcion, precio.ToString("0.00"), cantidad, totalProducto.ToString("0.00"));

            // Limpiar campos para nuevo producto
            IdProductotxt.Text = "";
            ProductoDescripciontxt.Text = "";
            Preciotxt.Text = "0.0";
            Cantidadtxt.Text = "";

            // Recalcular total general
            decimal totalGeneral = 0;
            foreach (DataGridViewRow fila in dgvDetalleVentas.Rows)
            {
                if (fila.Cells["Total"].Value != null)
                {
                    totalGeneral += Convert.ToDecimal(fila.Cells["Total"].Value);
                }
            }

            Totaltxt.Text = totalGeneral.ToString("0.00");
        }

        private void VentaDetalleCP_Load(object sender, EventArgs e)
        {
            Fechatxt.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            // Preparar datos para la venta
            VentaCE ventaCE = new VentaCE();
            ventaCE.IdCliente = Convert.ToInt32(IdClientetxt.Text);
            ventaCE.Fecventa = Convert.ToDateTime(Fechatxt.Text);

            // Preparar lista de detalles
            List<DetalleCE> listaDetallesCE = new List<DetalleCE>();

            foreach (DataGridViewRow fila in dgvDetalleVentas.Rows)
            {
                if (fila.IsNewRow) continue;
                if (fila.Cells["IdProducto"].Value != null)
                {
                    DetalleCE detalle = new DetalleCE();
                    detalle.IdProducto = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                    detalle.Cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    listaDetallesCE.Add(detalle);
                }
            }

            // Enviar a la capa de negocio para guardar
            VentaCN ventaCN = new VentaCN();
            ventaCN.GuardarVentaConDetalles(ventaCE, listaDetallesCE);

            MessageBox.Show("Venta registrada con éxito ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar todo

            // Limpiar cliente
            IdClientetxt.Text = "";
            ClienteNombretxt.Text = "";

            // Limpiar producto
            IdProductotxt.Text = "";
            ProductoDescripciontxt.Text = "";
            Preciotxt.Text = "0.0";
            Cantidadtxt.Text = "1";

            // Limpiar totales y tabla
            Totaltxt.Text = "0.0";
            dgvDetalleVentas.Rows.Clear(); // limpia las filas
        }

        private void dgvDetalleVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
