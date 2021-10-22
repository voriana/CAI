using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPresentismo.Negocio;
using ClasesPresentismo.Negocio.Abstractas;
using ClasesPresentismo.Utilitarios;
using ClasesPresentismo.Excepciones;

namespace ConsolaPresentismo
{
    class Program
    {
        private static Presentismo _presentismo;
        private static bool _activa;
        static Program()
        {
            _presentismo = new Presentismo();
            _activa = true;
        }
        static void Main(string[] args)
        {
            Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();
            while (_activa)
            {
                DesplegarOpcionesMenu();
                string opcionMenu = Validaciones.ValidarString("opcion que desea realizar:").ToUpper(); // pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        TomarAsistencia(preceptorActivo);
                        break;
                    case "2":
                        MostrarAsistencia();
                        break;
                    case "X":
                        _activa = false;
                        // SALIR
                        break;
                    default:
                        break;
                }
            }
        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        static void TomarAsistencia(Preceptor p)
        {
            // Ingreso fecha
            string fecha = Validaciones.ValidarString("fecha de asistencia a tomar en formato [YYYY-MM-DD]");

            _presentismo.Fechas.Add(fecha);
            // Listar los alumnos
            Console.WriteLine("************Se listan los alumno************");
            foreach(Alumno alumno in _presentismo.GetAlumnos())
            {
                Console.WriteLine(alumno.ToString());
            }
            List<Asistencia> asistencia = new List<Asistencia>();

            // para cada alumno solo preguntar si está presente
            foreach (Alumno alumno in _presentismo.GetAlumnos())
            {
                if (alumno is AlumnoRegular)
                {
                    Asistencia asistencia1 = new Asistencia();
                    asistencia1.FechaReferencia = fecha;
                    asistencia1.FechaReal = DateTime.Now;
                    asistencia1.Alumno = alumno;
                    asistencia1.Presente = Validaciones.RetornaBooleano($"El alumno {alumno.ToString()} esta presente? [S/N]");
                    asistencia1.Preceptor = _presentismo.GetPreceptorActivo();

                    asistencia.Add(asistencia1);
                }
                if(alumno is AlumnoOyente)
                {
                    Console.WriteLine($"El alumno {alumno.ToString()} es oyente");
                }
            }
            try
            {
                _presentismo.AgregarAsistencia(asistencia, fecha);
            }
            catch (AsistenciaExistenteEseDiaException e)
            {
                Console.WriteLine(e.Message);
            }

            
            // Error: mostrar el error y que luego muestre el menu nuevamente
        }
        static void MostrarAsistencia()
        {
            // ingreso fecha
            string fecha = Validaciones.ValidarString("fecha de asistencia a tomar en formato [YYYY-MM-DD]");
            // muestro el toString de cada asistencia
            if (_presentismo.GetAsistencia(fecha).Any())
            {
                foreach(Asistencia a in _presentismo.GetAsistencia(fecha))
                {
                    Console.WriteLine(a.ToString());
                }
            }
        }
    }
}
