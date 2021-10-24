using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesFacultad.Negocio.Abstractas;

namespace ClasesFacultad.Negocio
{
    public class Alumno:Persona
    {
        private int _codigo;

        public Alumno(int codigo, string nombre, string apellido, DateTime nacimiento):base (nombre,apellido,nacimiento)
        {
            _codigo = codigo;
        }

        public Alumno()
        {
        }

        public int Codigo { get { return _codigo; } set { _codigo = value; } }

      

        public override string GetCredencial()
        {
            return string.Format($"CODIGO {_codigo})- APELLIDO {_apellido},- NOMBRE {_nombre}");
            
        }
        public override string ToString()
        {
            return GetCredencial();
        }
        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }

            if (this._codigo == ((Alumno)o).Codigo)
            {
                return true;
            }

            return false;
        }

    }
}
