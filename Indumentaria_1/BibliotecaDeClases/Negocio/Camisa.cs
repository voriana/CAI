using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases.Negocio.Abstractas;

namespace BibliotecaDeClases.Negocio
{
    public class Camisa: Indumentaria
    {
        private bool _tieneEstampado;
        private string _tieneManga;

        //Constructor
        public Camisa()
        {

        }

        public Camisa(int codigo, string talle, double precio): base (codigo, talle, precio)
        {

        }

        public override string GetDetalle()
        {
            return string.Format($"Esta camisa tiene el codigo {Codigo}- los talles disponibles son {Talle}-" +
                $"tiene un precio de {Precio}");
        }
    }
}
