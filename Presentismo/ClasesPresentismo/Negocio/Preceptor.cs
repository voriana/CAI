using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPresentismo.Negocio.Abstractas;

namespace ClasesPresentismo.Negocio
{
    public class Preceptor: Persona
    {
        private int _legajo;

        public Preceptor (int legajo, string nombre , string apellido): base(nombre, apellido)
        {
            this._legajo = legajo;
        }
        internal override string Display()
        {
            return string.Format($"APELLIDO {Apellido}- LEGAJO {_legajo}");
        }
    }
}
