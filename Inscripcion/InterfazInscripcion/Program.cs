using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio;
using ClasesDeNegocio.Negocio.Abstractas;
using ClasesDeNegocio.Excepciones;
using ClasesDeNegocio.Utilitarios;

namespace InterfazInscripcion
{
    class Program
    {
        private static Instituto _instituto;
        private static bool _activa;

        static Program()
        {
            _instituto = new Instituto("NOMBRE");
            _activa = true;
        }
        static void Main(string[] args)
        {
            //traemos el profesor de turno por legajo (elegir el que quieran)
            Profesor profesor = _instituto.GetProfesor(5);


            while (_activa)
            {
                DesplegarOpcionesMenu();
                string opcionMenu =Validaciones.ValidarString("ingrese la opcion del menu que desea elegiir"); // pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        InscribirEstudiante(profesor);
                        break;
                    case "2":
                        MostrarInscripciones();
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
            Console.WriteLine("1) Inscribir Estudiante");
            Console.WriteLine("2) Mostrar Inscripciones");
            Console.WriteLine("X: Terminar");
        }
        static void InscribirEstudiante(Profesor p)
        {
            Estudiante Estudianteinscribir = null;
            Materia materiaInscripcion = null;

            Console.WriteLine("Lista de estudiantes del instuto");
            // Listar los estudiantes
            if (_instituto.Estudiantes().Any())
            {
                foreach (Estudiante estudiante in _instituto.Estudiantes())
                {
                    Console.WriteLine(estudiante.ToString());
                }
            }
            else
            {
                Console.WriteLine("No hay estudiantes para listar");
            }
            do
            {
                int registro = Validaciones.ValidarInt("Ingrese registro del estudiante a inscribir");

                foreach (Estudiante alum in _instituto.Estudiantes())
                {
                    if (alum.Registro == registro)
                    {
                        Estudianteinscribir = alum;
                    }
                }
                if (Estudianteinscribir is null)
                {
                    Console.WriteLine("Ha ingresado no registro invalido");
                }
            } while (Estudianteinscribir is null);
            do
            {
                // Listar las materias
                if (_instituto.Materias().Any())
                {
                    foreach (Materia mate in _instituto.Materias())
                    {
                        Console.WriteLine(mate.ToString());
                    }
                }
                int codMateria = Validaciones.ValidarInt(" codigo de la materia a la que desea inscribirse");
                foreach (Materia mate in _instituto.Materias())
                {
                    if(mate.Codigo== codMateria)
                    {
                        materiaInscripcion = mate;
                    }
                }
                if(materiaInscripcion is null)
                {
                    Console.WriteLine("Ha ingresado no codigo de materia inexistente");
                }
            } while (materiaInscripcion is null);

            // Intento cargar la Inscripción

             Inscripcion inscripcion =new Inscripcion(DateTime.Today, Estudianteinscribir, p, materiaInscripcion);
            try
            {
                _instituto.CargaInscripcion(inscripcion);
                Console.WriteLine($"Estudiante {inscripcion.Estudiante} inscripto satisfactoriamente");
            }catch(EstudianteInhabilitadoException e)
            {
                Console.WriteLine(e.Message);
                DesplegarOpcionesMenu();
                string opcionMenu = Validaciones.ValidarString("ingrese la opcion del menu que desea elegiir");
            }
            catch (EstudianteInscriptoException e)
            {
                Console.WriteLine(e.Message);
                DesplegarOpcionesMenu();
                string opcionMenu = Validaciones.ValidarString("ingrese la opcion del menu que desea elegiir");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        static void MostrarInscripciones()
        {
            // ingreso fecha
            DateTime fecha = Validaciones.PedirFecha("Ingrese fecha de inscripcion a mostrar");
            try
            {

                if (_instituto.Inscripciones(fecha).Any())
                {
                    foreach(Inscripcion inscripcion in _instituto.Inscripciones(fecha))
                    {
                        // muestro el toString de cada inscripción
                        Console.WriteLine(inscripcion.ToString());
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
}
