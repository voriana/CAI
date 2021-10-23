using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases.Negocio.Abstractas;

namespace BibliotecaDeClases.Negocio
{
    public class VentaItem
    {
        //atributos
        private Indumentaria _prenda;
        private int _cantidad;

        //propiedades
        public Indumentaria Prenda
        {
            get
            {
                return _prenda;
            }
        }
        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
        }
      
    }
}
