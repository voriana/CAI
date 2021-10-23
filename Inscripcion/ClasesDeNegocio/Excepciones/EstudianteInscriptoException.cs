using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;

namespace ClasesDeNegocio.Excepciones
{
    public class EstudianteInscriptoException:Exception
    {
        public EstudianteInscriptoException(Estudiante estudiante) : base($"El estudiante ya se encuentra inscripto") { }
    }
}
