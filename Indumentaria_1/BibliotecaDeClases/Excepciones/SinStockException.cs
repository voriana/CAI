using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases.Negocio.Abstractas;

namespace BibliotecaDeClases.Excepciones
{
    public class SinStockException:Exception
    {
        public SinStockException(Indumentaria indumentaria) : base($"No hay esto para la prenda con codigo {indumentaria.Codigo}.No se puede realizar la venta")
        {

        }
    }
}
