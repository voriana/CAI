using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;
namespace ClasesDeNegocio.Negocio
{
    public class Inscripcion
    {

        private DateTime _fechaInscripcion;
        private Profesor _profesor;
        private Estudiante _estudiante;
        private Materia _materia;

        public Inscripcion(DateTime fecha, Estudiante estudiante1, Profesor profesor, Materia materia1)
        {
            this._fechaInscripcion = fecha;
            this._estudiante = estudiante1;
            this._profesor = profesor;
            this._materia = materia1;
        }

        public DateTime Fecha
        {
            get
            { return _fechaInscripcion;}
        }

        public Profesor Profesor
        {
            get
            {return _profesor;}
        }

        public Estudiante Estudiante
        {
            get { return _estudiante; }
        }

        public Materia Materia
        {
            get { return _materia; }
        }


        public override string ToString()
        {
            return $"FECHAINSCRIPCION {Fecha.ToString("yyyy-MM-dd")}-{Estudiante.ToString()}- inscripto a {Materia.ToString()}";
        }
    }
}