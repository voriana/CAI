using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaReglasNegocio;

namespace ClienteCapaPresentacion
{
    public partial class FrmListarClientes : Form
    {
        private ClienteServicio _clienteServicio;
        private FrmAgregarCliente _FrmAgregarCliente;
        
        public FrmListarClientes(FrmMaster frmPrincipal)
        {
            InitializeComponent();
            this.Owner = frmPrincipal;
            _clienteServicio = new ClienteServicio();
            _FrmAgregarCliente = new FrmAgregarCliente(this);
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmListarClientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }

        private void CargarListaClientes()
        {
            _lstClientes.DataSource = null;
            _lstClientes.DataSource = _clienteServicio.GetClientes();
            _lstClientes.DisplayMember = "Mostrar";
        }

        private void _btnAgregarCliente_Click(object sender, EventArgs e)
        {
            _FrmAgregarCliente.Show();
            this.Hide();
        }

        private void _btnRefrescarLista_Click(object sender, EventArgs e)
        {
          
        }
    }
}
