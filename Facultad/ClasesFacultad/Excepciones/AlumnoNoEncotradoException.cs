using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesFacultad.Negocio;

namespace ClasesFacultad.Excepciones
{
    class AlumnoNoEncotradoException:Exception
    {
        public AlumnoNoEncotradoException(Alumno a) : base($"No se ha encontrado el alumno con codigo {a.Codigo} ") { }
    }
}
