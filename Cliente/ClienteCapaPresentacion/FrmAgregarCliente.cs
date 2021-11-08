using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaReglasNegocio;

namespace ClienteCapaPresentacion
{
    public partial class FrmAgregarCliente : Form
    {
        private ClienteServicio _clienteServicio;
        public FrmAgregarCliente(FrmListarClientes frmListarClientes)
        {
            InitializeComponent();
            this.Owner = frmListarClientes;
            _clienteServicio = new ClienteServicio();
        }

        //Agregar cliente
        public void AgregarCliente(Cliente cliente)
        {
            _clienteServicio.AddCliente(cliente);
        }

        private void _btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _clienteServicio.AddCliente(ValidarDatosIngresados());

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        private Cliente ValidarDatosIngresados()
        {
            int id = Validaciones.ValidarInt(_txbIdCliente.Text);
            long cuit = Validaciones.ValidarLong(_txbCuitCliente.Text);
            string email = Validaciones.ValidarString(_txbEmail.Text);
            DateTime fechaNac = Validaciones.PedirFecha(_txtFechaNac.Text);
            bool activo = _rbClienteActivo.Checked;
            string nombre = Validaciones.ValidarString(_txbNombreCliente.Text);
            string apellido = Validaciones.ValidarString(_txbApellidoCliente.Text);
            string direccion = Validaciones.ValidarString(_txtDireccion.Text);
            string telefono = Validaciones.ValidarString(_txbTelefono.Text);

            
            Cliente cliente = new Cliente(id, cuit, email, fechaNac, activo, nombre, apellido, new TipoDocumento(1, "Cuit"), direccion, telefono);
            return cliente;
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }

}
