using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPresentismo.Negocio.Abstractas;

namespace ClasesPresentismo.Negocio
{
    public class AlumnoOyente: Alumno
    {
        public AlumnoOyente(int registro, string nombre, string apellido):base (registro, nombre, apellido) { }
    }
}
