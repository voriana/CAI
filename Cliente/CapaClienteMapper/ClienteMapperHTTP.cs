using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using Newtonsoft.Json;

namespace CapaAccesoDatos
{
    public class ClienteMapperHTTP
    {
        private List<Cliente> _clientes;
        public ClienteMapperHTTP()
        {
            _clientes = new List<Cliente>();
        }

        public List<Cliente>  TraerClientes(string ruta)
        {
            string responseCliente= WebHelper.Get(ruta);
            _clientes = JsonConvert.DeserializeObject <List<Cliente>>(responseCliente);


            return _clientes;

        }
        
    }
}
