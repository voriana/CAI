using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteCapaPresentacion
{
    public partial class FrmMaster : Form
    {
        private FrmListarClientes _frmListarClientes;
        public FrmMaster()
        {
            _frmListarClientes = new FrmListarClientes(this);
            InitializeComponent();
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmListarClientes.Show();
        }
    }
}
