using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesFacultad.Enum;
using ClasesFacultad.Excepciones;
using ClasesFacultad.Negocio.Abstractas;

namespace ClasesFacultad.Negocio
{
    public class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;
        //propertys
        public int CantidadSedes { get { return _cantidadSedes; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        //creo constructor vacio
        public Facultad()
        {
            _alumnos = new List<Alumno>();
            _empleados = new List<Empleado>();

            _alumnos.Add(new Alumno(1234, "Oriana", "Varela",Convert.ToDateTime("1986-06-06")));
            _alumnos.Add(new Alumno(1235, "cristian", "rios", Convert.ToDateTime("1986-06-12")));
            _empleados.Add(new Bedel(3456, "luis", "Lecheiner", Convert.ToDateTime("1982-09-06"), Convert.ToDateTime("2020-01-06"), "bugs"));
            _empleados.Add(new Docente(3457, "Carlos", "Ruiz", Convert.ToDateTime("1900-02-25"), Convert.ToDateTime("2010-04-01")));
            _empleados.Add(new Directivo(3458, "Luz Elena", "Guisado", Convert.ToDateTime("1950-11-15"), Convert.ToDateTime("2000-10-12")));

        }
        public Facultad(string nombre)
        {
            _alumnos = new List<Alumno>();
            _empleados = new List<Empleado>();
            _nombre = nombre;

        }
        //metodos 
        private void AgregarAlumno(Alumno alumno)
        {
            if(alumno is null)
            {
                throw new ArgumentNullException("EL OBJETO ES NULL-MENSAJE ");
            }
            if (_alumnos.Any())
            {
                foreach(Alumno a in _alumnos)
                {
                    //si el alumno ya existe lanzo exception 
                    if (a.Equals(alumno.Codigo))
                    {
                        throw new Exception($"Ya existe un alumno con  codigo: {alumno.Codigo}");
                    }
                }
                _alumnos.Add(alumno);
            }
        }

        public void AgregarAlumo(int codigo, string nombre, string apellido, DateTime Nac)
        {
            Alumno alumno = new Alumno();
            if (codigo.ToString().Length < 4)
            {
                throw new Exception($"El codigo debe ser minimo de cuatro digitos");
            }
             int FechaActual = Convert.ToInt32(DateTime.Now.ToString("yyyy-MM-dd"));
             int FechaNac = Convert.ToInt32(Nac.ToString("yyyy-MM-dd"));
             if (FechaNac> FechaActual)
             {
                throw new Exception("La fecha de nacimiento no puede ser mayor a la actual");
             }
            alumno.Codigo = codigo;
            alumno.Nombre = nombre;
            alumno.Apellido = apellido;

            
            AgregarAlumno(alumno);
        }
        private void AgregarEmpleado(Empleado empleado)
        {
            if (empleado is null)
            {
                throw new ArgumentNullException("EL OBJETO ES NULL-MENSAJE ");
            }
            if (_empleados.Any())
            {
                foreach (Empleado a in _empleados)
                {
                    //si el empleao ya existe lanzo exception 
                    if (a.Equals(empleado.Legajo))
                    {
                        throw new Exception($"Ya existe un empleado con  Legajo: {empleado.Legajo}");
                    }
                }
                _empleados.Add(empleado);
            }
        }
        public void EliminarAlumno(int codigo)
        {
            Alumno alumnoEliminar = new Alumno();
            alumnoEliminar= _alumnos.Find(x => x.Codigo.Equals(codigo));
            if(alumnoEliminar is null)
            {
                throw new AlumnoNoEncotradoException(alumnoEliminar);
            }
            _alumnos.Remove(alumnoEliminar);
        }
        public void EliminarEmpleado(int legajo)
        {
            Empleado EmpleadoEliminar = new Empleado();
            EmpleadoEliminar = _empleados.Find(x => x.Legajo.Equals(legajo));
            if (EmpleadoEliminar == null)
            {
                throw new EmpleadoNoEncotradoException(EmpleadoEliminar);
            }
            this._empleados.Remove(EmpleadoEliminar);
        }
        public List<Alumno> Alumnos()
        {
            return _alumnos;
        }
        public List<Empleado> Empleados()
        {
            return _empleados;
        }
        public Empleado EmpleadosPorLegajo(int legajo)
        {
            Empleado empleado = _empleados.Find(x => x.Equals(legajo));
            if(empleado == null)
            {
                throw new EmpleadoNoEncotradoException(empleado);
            }
            return empleado;
        }

        public Empleado EmpleadosPorNombre(string  nombre)
        {
            Empleado empleado = _empleados.Find(x => x.GetNombreCompleto().Equals(nombre));
            if (empleado == null)
            {
                throw new EmpleadoNoEncotradoException(empleado);
            }
            return empleado;
        }

        public void AgregarEmpleado(int legajo, string nombre, string apellido, DateTime Nac, DateTime ingreso, string apodo , TipoEmpleado tipo)
        {
            Empleado empleado=null;
            if (legajo.ToString().Length < 4)
            {
                throw new Exception($"El codigo debe ser minimo de cuatro digitos");
            }
            int FechaActual = Convert.ToInt32(DateTime.Now.ToString("yyyy-MM-dd"));
            int FechaNac = Convert.ToInt32(Nac.ToString("yyyy-MM-dd"));
            int FechaIngreso = Convert.ToInt32(ingreso.ToString("yyyy-MM-dd"));
            if (FechaNac > FechaActual)
            {
                throw new Exception("La fecha de nacimiento no puede ser mayor a la actual");
            }
            if (FechaIngreso > FechaActual)
            {
                throw new Exception("La fecha de ingreso no puede ser mayor a la actual");
            }
            if (tipo== TipoEmpleado.BEDEL)
            {
                empleado = new Bedel(legajo, nombre, apellido,Nac,ingreso, apodo) ;
            }
            if (tipo == TipoEmpleado.DOCENTE)
            {
                empleado = new Docente(legajo, nombre, apellido, Nac, ingreso);
            }
            if (tipo == TipoEmpleado.DIRECTIVO)
            {
                empleado = new Directivo(legajo, nombre, apellido, Nac, ingreso);
            }

            AgregarEmpleado(empleado);


        }
    }
}
