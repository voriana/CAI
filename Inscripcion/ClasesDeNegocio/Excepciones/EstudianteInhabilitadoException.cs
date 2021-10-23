using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;

namespace ClasesDeNegocio.Excepciones
{
    public class EstudianteInhabilitadoException: Exception
    {
        public EstudianteInhabilitadoException(Estudiante estudiante):base ($"El alumno no puede inscribirse a la nueva materia"){}
    }
}
