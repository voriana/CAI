using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;

namespace ClasesDeNegocio.Negocio.Abstractas
{
    public abstract class Estudiante :Persona

    {
        private int _registro;

        public int Registro
        {
            get { return _registro; }
        }


        public  Estudiante(int v1, string v2, string v3, string v4):base (v2,v3,v4)
        {
            this._registro = v1;
        }

        internal override string Mostrar()
        {
            return string.Format($"Registro {Registro} -Nombre {Nombre} -Email ({Email})");
        }
    }
}