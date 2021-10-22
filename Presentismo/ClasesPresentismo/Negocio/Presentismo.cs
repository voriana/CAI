using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPresentismo.Negocio.Abstractas;
using ClasesPresentismo.Excepciones;

namespace ClasesPresentismo.Negocio
{
    public class Presentismo
    {
        private List<Preceptor> _preceptores;
        private List<Alumno> _alumnos;
        private List<Asistencia> _asistencias;
        private List<string> _fechas;

        public List<Alumno> GetAlumnos()
        {

            return _alumnos;
        }
        public List<Asistencia> Asistencias
        {
            get { return _asistencias; }
        }
        public List<string> Fechas
        {
            get { return _fechas; }
        }

        // iniciar Presentismo con los siguientes datos
        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();
            _fechas = new List<string>();
            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));
            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));
     
        }
        public bool AsistenciaRegistrada (string fecha)
        {
            bool asistencia = false;
            foreach(Asistencia asis in _asistencias)
            {
                if (asis.FechaReferencia== fecha)
                {
                    asistencia= true;
                    
                }
            }
            return asistencia;
        }

        public int GetCantidadAlumnosRegulares()
        {
            int cantidad = 0;
            foreach (Alumno a in _alumnos)
            {
                if(a is AlumnoRegular)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        public Preceptor GetPreceptorActivo()
        {
            return _preceptores.Last();
        }

        public List<Alumno> GetAlumnos(string nombre)
        {
            List<Alumno> alumnosAsistencia = null;
            foreach( Asistencia asistencia in _asistencias)
            {
                if (asistencia.Alumno.Nombre== nombre)
                {
                    alumnosAsistencia.Add(asistencia.Alumno);
                }
            }
            if(alumnosAsistencia is null)
            {
                throw new Exception("No hay alumnos con ese nombre");
            }
            return alumnosAsistencia;
        }
      
        public void AgregarAsistencia(List<Asistencia> asistencias, string fecha)
        {
            if (asistencias.Count() != GetCantidadAlumnosRegulares())
            {
                throw new AsistenciaInconsistenteException();
            }

            if (AsistenciaRegistrada(fecha))
            {
                throw new AsistenciaExistenteEseDiaException();
            }
            else
            {
                _asistencias.AddRange(asistencias);
                _fechas.Add(fecha);
            }

        }

        public List<Asistencia> GetAsistencia(string fecha)
        {
            List<Asistencia> asistencia = new List<Asistencia>();
            foreach (Asistencia asistencia1 in _asistencias)
            {
                if (asistencia1.FechaReferencia == fecha)
                {
                    asistencia.Add(asistencia1);
                }
            }
           
            return asistencia;
        }
    }
}
