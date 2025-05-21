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
    public partial class ClienteCP : Form
    {
        //Propiedades
        //PASO 1: Declarar una propiedad de control para las instancias
        private static ClienteCP instancia = null;
        
        //PASO 2: Encapsular la propiedad "instancia" de solo lectura (get)
        public static ClienteCP Instancia
        {
            get
            {
                //Si la instancia es NULL (nunca se ha instanciado)
                //o Si la instancia se ha Eliminado (IsDisposed)
                if (instancia == null || instancia.IsDisposed)
                {
                    //Crear la instancia
                    instancia = new ClienteCP();
                }

                return instancia;
            }

        }

        //Constructor
        public ClienteCP()
        {
            InitializeComponent();

        }

        //Métodos

        private void ClienteCP_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int idBuscar = Convert.ToInt32(txtId.Text);
            ClienteCN clienteCN = new ClienteCN();
            ClienteCE clienteCE = clienteCN.getBuscarPorId(idBuscar);
            txtId.Text = clienteCE.Id.ToString();
            txtNombre.Text = clienteCE.Nombre;
            txtNumruc.Text = clienteCE.Numruc;
            txtDireccion.Text = clienteCE.Direccion;
            txtTelefono.Text = clienteCE.Telefono;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            txtNumruc.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dgvClientes.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteCE clienteCE = new ClienteCE();
            clienteCE.Id = Convert.ToInt32(txtId.Text);
            clienteCE.Nombre = txtNombre.Text;
            clienteCE.Numruc = txtNumruc.Text;
            clienteCE.Direccion = txtDireccion.Text;
            clienteCE.Telefono = txtTelefono.Text;

            ClienteCN clienteCN = new ClienteCN();

            if (txtId.Text == "0")
            {
                //INSERTAR
                int nuevoId = clienteCN.setInsertar(clienteCE);
                txtId.Text = nuevoId.ToString();
                MessageBox.Show("Se agrego el registro!");
            }
            else
            {
                //ACTUALIZAR
                clienteCN.setActualizar(clienteCE);
                MessageBox.Show("Se actualizo el registro!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEliminar = Convert.ToInt32(txtId.Text);
            if (idEliminar > 0)
            {
                DialogResult rpta = MessageBox.Show("Esta seguro que desea eliminar", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (rpta == DialogResult.Yes)
                {
                    ClienteCN clienteCN = new ClienteCN();
                    clienteCN.setEliminar(idEliminar);
                    btnNuevo_Click(null, null);
                    MessageBox.Show("Se elimino el registro.");
                }
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            string nombreBuscar = txtNombreBuscar.Text;
            ClienteCN clienteCN = new ClienteCN();
            List<ClienteCE> listaClientesCE = clienteCN.getBuscarPorNombre(nombreBuscar);
            dgvClientes.DataSource = listaClientesCE;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cantidadFilasSeleccionadas = dgvClientes.SelectedRows.Count;
            if (cantidadFilasSeleccionadas >= 1)
            {
                DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];
                txtId.Text = filaSeleccionada.Cells["id"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["descripcion"].Value.ToString();
                txtNumruc.Text = filaSeleccionada.Cells["categoria"].Value.ToString();
                txtDireccion.Text = filaSeleccionada.Cells["direccion"].Value.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["telefono"].Value.ToString();

            }
        }
    }
}
