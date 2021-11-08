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
                int id = Validaciones.ValidarInt(_txbIdCliente.Text);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
