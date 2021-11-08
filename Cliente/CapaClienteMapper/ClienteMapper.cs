using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class ClienteMapper
    {

        private List<Cliente> _clientes;
        public ClienteMapper()
        {
            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente(1, 12141412, "varela@gmail.com", new DateTime(), true, "Oriana", "Varela", new TipoDocumento(1, "Cuit"),"yerbal 2315","1548795"));
            _clientes.Add(new Cliente(2, 15789561, "rios@gmail.com", new DateTime(), true, "Cristian", "Perez", new TipoDocumento(1, "Cuit"), "yerbal 2315", "15454545"));
            _clientes.Add(new Cliente(3, 12141412, "qqq@gmail.com", new DateTime(), true, "Hector", "Martinez", new TipoDocumento(1, "Cuit"), "yerbal 2315", "114789653"));
        }

        public void PersistirCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public List<Cliente> TraerClientes()
        {
            return _clientes;
        }
    }
}
