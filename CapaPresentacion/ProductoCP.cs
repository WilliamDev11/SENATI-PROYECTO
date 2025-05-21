using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class ProductoCP : Form
    {
        //Propiedades
        //PASO 1: Declarar una propiedad de control para las instancias
        /*
         * Ambito: privado (se va encapsular)
         * Estatico: se invocara directamente (sin instancia)
         * Tipado: el mismo de la clase
         * Valor inicial = null
         */
        private static ProductoCP instancia = null;

        //PASO 2: Encapsular la propiedad "instancia" de solo lectura (get)
        public static ProductoCP Instancia
        {
            get
            {
                //Si la instancia es NULL (nunca se ha instanciado)
                //o Si la instancia se ha Eliminado (IsDisposed)
                if((instancia == null) || (instancia.IsDisposed == true))
                {
                    //Crear la instancia
                    instancia = new ProductoCP();
                }

                return instancia;
            }

        }
        //Constructor
        public ProductoCP()
        {
            InitializeComponent();
        }

        //Metodos
        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int idBuscar = Convert.ToInt32(txtId.Text);
            ProductoCN productoCN = new ProductoCN();
            ProductoCE productoCE = productoCN.getBuscarPorId(idBuscar);
            txtId.Text = productoCE.Id.ToString();
            txtDescripcion.Text = productoCE.Descripcion;
            txtCategoria.Text = productoCE.Categoria;
            txtPrecio.Text = productoCE.Precio.ToString();
        }

        private void btnBuscarDescripcion_Click(object sender, EventArgs e)
        {
            string descripcionBuscar = txtDescripcionBuscar.Text;
            ProductoCN productoCN = new ProductoCN();
            List<ProductoCE> listaProductosCE = productoCN.getBuscarPorDescripcion(descripcionBuscar);
            dgvProductos.DataSource = listaProductosCE;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "0";
            txtDescripcion.Text = "";
            txtCategoria.Text = "";
            txtPrecio.Text = "0.0";

            txtDescripcionBuscar.Text = "";
            dgvProductos.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Instanciar un productoCE
            ProductoCE productoCE = new ProductoCE();
            //Recogiendo los valores en el productoCE
            productoCE.Id = Convert.ToInt32(txtId.Text);
            productoCE.Descripcion = txtDescripcion.Text;
            productoCE.Categoria = txtCategoria.Text;
            productoCE.Precio = Convert.ToDouble(txtPrecio.Text);
            //Instanciar un productoCN
            ProductoCN productoCN = new ProductoCN();
            //Controlar si es insercion/actualizacion
            if (productoCE.Id == 0)
            {
                //INSERTAR
                //Ejecutar la insercion y recoger el nuevo id
                int nuevoId = productoCN.setInsertar(productoCE);
                //Mostrar el nuevo id
                txtId.Text = nuevoId.ToString();
                //Mensaje
                MessageBox.Show("Se inserto el nuevo registro");
            }
            else
            {
                //ACTUALIZAR
                //Ejecutar la actualizacion
                productoCN.setActualizar(productoCE);
                //Mensaje
                MessageBox.Show("Se actualizo el registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Mostrar un mensaje de advertencia
            DialogResult rpta = MessageBox.Show("Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            //Controlar si se desea continuar con la eliminacion
            if (rpta == DialogResult.Yes)
            {
                //Leer el ID eliminar
                int idEliminar = Convert.ToInt32(txtId.Text);
                //Instanciar un producto CN
                ProductoCN productoCN = new ProductoCN();
                //Ejecutar la eliminacion
                productoCN.setEliminar(idEliminar);
                //Limpiar los controles
                btnNuevo_Click(null, null);
                //Mostrar mensaje
                MessageBox.Show("Eliminado...");
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            //Cantidad de Filas Seleccionadas
            int cantFilasSel = dgvProductos.SelectedRows.Count;

            //Controlar la seleccion solo de filas
            if (cantFilasSel >= 1)
            {
                //Recoger la primera fila selecciona
                DataGridViewRow filasSel = dgvProductos.SelectedRows[0];

                //Acceder a cada celda y mostrar su valor
                txtId.Text = filasSel.Cells["id"].Value.ToString();
                txtDescripcion.Text = filasSel.Cells["descripcion"].Value.ToString();
                txtCategoria.Text = filasSel.Cells["categoria"].Value.ToString();
                txtPrecio.Text = filasSel.Cells["Precio"].Value.ToString();
            }
        }
    }
}
