using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPresentismo.Negocio.Abstractas
{
     public abstract class Alumno:Persona
     {
        private int _registro;

        public int Registro
        {
            get { return _registro; }
        }
        public Alumno(int registro, string nombre, string apellido):base(nombre, apellido)
        {
            this._registro = registro;
        }
        

        internal override string Display()
        {
            return string.Format($"NOMBRE {Nombre}(REGISTRO) {Registro}");
        }
    }
}
