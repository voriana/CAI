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
        private ClienteMapperHTTP _clienteMapperHttp;

        public ClienteServicio()
        {
            _clienteMapper = new ClienteMapper();
            _clienteMapperHttp = new ClienteMapperHTTP();
        }
        public List<Cliente> GetClientes()
        {
            return _clienteMapperHttp.TraerClientes("Cliente");
        }

      

        public void AddCliente(Cliente cliente)
        {
            _clienteMapper.PersistirCliente(cliente);
        }
    }
}
