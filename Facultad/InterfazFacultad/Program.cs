using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesFacultad.Negocio;
using ClasesFacultad.Utilitarios;
using ClasesFacultad.Excepciones;
using ClasesFacultad.Negocio.Abstractas;
using ClasesFacultad.Enum;

namespace InterfazFacultad
{
    class Program
    {
        static bool _activa;
        static Facultad _facultad;

        static Program()
        {
            
            _facultad = new Facultad();
            _activa = true;
        }
        static void Main(string[] args)
        {
            
            while (_activa)
            {
                Menu();
                string eleccion = Validaciones.ValidarString("Opcion del sistema");
                switch (eleccion)
                {
                    case "1":
                        AgregarAlumno(_facultad);
                        break;
                    case "2":
                        EliminarAlumno(_facultad);
                        break;
                    case "3":
                        AgregarEmpleado(_facultad);
                        break;
                    case "4":
                        EliminarEmpleado(_facultad);
                        break;
                    case "5":
                        ModificarEmpleado(_facultad);
                        break;
                    case "6":
                        ListarAlumno(_facultad);
                        break;
                    case "7":
                        ListarEmpleado(_facultad);
                        break;
                    case "8":
                        ListarEmpleadoPorLegajo(_facultad);
                        break;
                    case "X":
                        _activa = false;
                        break;

                }

            }
        }

        private static void ListarEmpleadoPorLegajo(Facultad facultad)
        {
            try
            {
                int legajo = Validaciones.ValidarInt(" legajo del empleado a buscar");
                if (facultad.Empleados().Any())
                {
                    Empleado EmpleadoEncontrado = facultad.EmpleadosPorLegajo(legajo);
                    Console.WriteLine($"Empleado encontrado\n {EmpleadoEncontrado.GetCredencial()}");
                }
                else
                {
                    Console.WriteLine("No se han agregado empleados a la lista");
                }
            }
            catch (EmpleadoNoEncotradoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ListarEmpleado(Facultad facultad)
        {
            try
            {
                if (facultad.Empleados().Any())
                {
                    foreach (var item in facultad.Empleados())
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("No se han agregado empleados a la lista");
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }

        private static void ListarAlumno(Facultad facultad)
        {
            if (facultad.Alumnos().Any())
            {
                foreach (var item in facultad.Alumnos())
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private static void ModificarEmpleado(Facultad facultad)
        {
            throw new NotImplementedException();
        }

        private static void EliminarEmpleado(Facultad facultad)
        {
            //listo los empleados
            try
            {
                if (facultad.Empleados().Any())
                {
                    foreach (Empleado e in facultad.Empleados() )
                    {
                        Console.WriteLine(e.GetCredencial()); // getCredencial me muestra el legajo
                    }
                    int legajo = Validaciones.ValidarInt("legajo del empleado para eliminar");
                    facultad.EliminarEmpleado(legajo);
                    Console.WriteLine($"Se ha elimnado {facultad.EmpleadosPorLegajo(legajo).ToString()} satifactoriamente");
                }
                else
                {
                    Console.WriteLine("No hay alumnos para eliminar");
                }
                

            }catch(EmpleadoNoEncotradoException e){
                Console.WriteLine(e.Message);
            }
        }

        private static void EliminarAlumno(Facultad facultad)
        {
            //listo los alumnos
            if (facultad.Alumnos().Any())
            {
                foreach (Alumno item in facultad.Alumnos())
                {
                    Console.WriteLine(item.ToString());
                }
                int codigo = Validaciones.ValidarInt("Ingrese codigo del alumno a eliminar ");
                facultad.EliminarAlumno(codigo);
                Console.WriteLine($"se ha eliminado satifactoriamante el alumno codigo {codigo}");
            }
            else
            {
                Console.WriteLine("No hay alumnos para eliminar");
            }
        }

        private static void AgregarEmpleado(Facultad facultad)
        {
            int legajo = Validaciones.ValidarInt("legajo del empleado para agregar");
            string nombre = Validaciones.ValidarString("nombre del empleado para agregar").ToUpper();
            string apellido = Validaciones.ValidarString("apellido del empleado para agregar").ToUpper();
            DateTime FechaNac = Validaciones.PedirFecha("Nacimiento");
            DateTime fechaIngreso = Validaciones.PedirFecha(" de ingreso");
            string apodo="";
            
            string tipoEmpleado = "";
            TipoEmpleado tipo = TipoEmpleado.DIRECTIVO;
            while (tipoEmpleado.ToUpper() != tipo.ToString());
            
            if(tipoEmpleado.ToUpper()== "DOCENTE")
            {
                tipo = TipoEmpleado.DOCENTE;
            }
            if (tipoEmpleado.ToUpper() == "DIRECTIVO")
            {
                tipo = TipoEmpleado.DIRECTIVO;
            }
            if (tipoEmpleado.ToUpper() == "BEDEL")
            {
                tipo = TipoEmpleado.BEDEL;
                apodo = Validaciones.ValidarString("apodo del bedel");

            }

            try
            {
                _facultad.AgregarEmpleado(legajo, nombre, apellido, FechaNac, fechaIngreso, apodo, tipo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AgregarAlumno(Facultad facultad)
        {
            int codigoAlum = Validaciones.ValidarInt("codigo del alumno para agregar");
            string NombreAlum = Validaciones.ValidarString("nombre del alumno para agregar").ToUpper();
            string ApellidoAlum = Validaciones.ValidarString("apellido del alumno para agregar").ToUpper();
            DateTime FechaNac = Validaciones.PedirFecha("Nacimiento");
            try
            {
                _facultad.AgregarAlumo(codigoAlum, NombreAlum, ApellidoAlum, FechaNac);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void Menu()
        {
            Console.WriteLine("Bienvenidos".ToUpper());
            Console.WriteLine("1) Alta Alumno".ToUpper());
            Console.WriteLine("2) Baja Alumno".ToUpper());
            Console.WriteLine("3) Alta Empleado".ToUpper());
            Console.WriteLine("4) Baja Empleado".ToUpper());
            Console.WriteLine("5) modificacion Empleado".ToUpper());
            Console.WriteLine("6) Listar Alumno".ToUpper());
            Console.WriteLine("7) Listar Empleado".ToUpper());
            Console.WriteLine("8) Listar Empleado por nombre".ToUpper());
            Console.WriteLine("X) Para salir".ToUpper());
        }
    }
}
