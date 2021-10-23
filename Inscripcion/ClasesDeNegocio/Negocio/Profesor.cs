using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;


namespace ClasesDeNegocio.Negocio
{
    public class Profesor :Persona
    {
        private int _legajo;

        public Profesor(int v1, string v2, string v3):base (v2,v3)
        {
            this._legajo = v1;
        }

        public int Legajo
        {
            get
            {
                return _legajo;
            }
        }
        internal override string Mostrar()
        {
            return string.Format($"APELLIDO {Apellido} LEGAJO {Legajo}");
        }
    }
}