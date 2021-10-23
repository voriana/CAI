using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases.Negocio.Abstractas;

namespace BibliotecaDeClases.Negocio
{
    public class Pantalon:Indumentaria
    {
        //atributos
        private bool _tieneBolsillos;
        private string _material;

        //constructor
        public Pantalon()
        {

        }

        public Pantalon (int codigo, string talle, double precio): base (codigo,talle, precio)
        {

        }

        //metodos
        public override string GetDetalle()
        {
            return string.Format($"Este pantalon tiene el codigo {Codigo}- los talles disponibles son {Talle}-" +
               $"tiene un precio de {Precio}");
        }
    }
}
