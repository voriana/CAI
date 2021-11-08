using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;

namespace CapaReglasNegocio
{
    public class ClienteServicio
    {
        private ClienteMapper _clienteMapper;

        public ClienteServicio()
        {
            _clienteMapper = new ClienteMapper();
        }
        public List<Cliente> GetClientes()
        {
            return _clienteMapper.TraerClientes();
        }

      

        public void AddCliente(Cliente cliente)
        {
            _clienteMapper.PersistirCliente(cliente);
        }
    }
}
