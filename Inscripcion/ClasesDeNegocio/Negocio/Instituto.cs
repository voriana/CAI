using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;
using ClasesDeNegocio.Excepciones;

namespace ClasesDeNegocio.Negocio
{
    public class Instituto
    {
        private string _nombre;
        private List<Profesor> _profesores;
        private List<Estudiante> _estudiantes;
        private List<Inscripcion> _inscripciones;
        private List<Materia>_materias;

        public Profesor GetProfesor(int legajo)
        {
            Profesor profesor = null;
            foreach (Profesor profe in _profesores)
            {
                if (profe.Legajo == legajo){
                    profesor = profe;

                }
            }
            if(profesor is null)
            {
                throw new Exception("Profesor no encontrado");
            }
            return profesor;
        }


        public List<Materia> Materias()
        {
            return _materias;
        }

        public List<Estudiante> Estudiantes()
        {
            return _estudiantes;
        }

        public void CargaInscripcion (Inscripcion inscripcion)
        {
            //Primero valido si esta inscripto a la materia
            foreach (Inscripcion inscripcion1 in _inscripciones)
            {
                if (inscripcion.Estudiante.Registro == inscripcion1.Estudiante.Registro && inscripcion.Materia == inscripcion1.Materia)
                {
                    throw new EstudianteInscriptoException(inscripcion.Estudiante);
                }
            }
            //Reviso que tipo de estudiante es
            if ( inscripcion.Estudiante is EstudianteRecursante)
            {
                //Si es recursante -valido cantidad de cursos tomados
                if (((EstudianteRecursante)inscripcion.Estudiante).Cursos >= 3)
                {
                    throw new EstudianteInhabilitadoException(inscripcion.Estudiante);
                }else
                {
                    _inscripciones.Add(inscripcion); // si no cumple con eso lo inscribo como recursante
                }
            }else 
            {
                _inscripciones.Add(inscripcion); //si no es recursante no valido nada y lo inscribo
            }
              
                
            
        }

        public List <Inscripcion> Inscripciones(DateTime fecha)
        {
            List<Inscripcion> ListaEncotrada = new List<Inscripcion>();
            foreach (Inscripcion inscripcion in _inscripciones)
            {
                if (inscripcion.Fecha.ToString("yyyy-MM-dd") == fecha.ToString("yyyy-MM-dd"))
                {
                    ListaEncotrada.Add(inscripcion);
                }
            }
            if(ListaEncotrada.Count()==0)
            {
                throw new Exception("No se a encontrado inscripciones para la fecha seleccionada");
            }
            return ListaEncotrada;
        }
        // iniciar Instituto con los siguientes datos
        public Instituto(string nombre)
        {
            _nombre = nombre;
            _estudiantes = new List<Estudiante>();
            _inscripciones = new List<Inscripcion>();
            _profesores = new List<Profesor>();
            _materias = new List<Materia>();


            _estudiantes.Add(new EstudianteRecursante(123, "Carlos", "Juarez", "cjua@gmail.com", 2));
            _estudiantes.Add(new EstudianteRecursante(124, "Carla", "Jaime", "cjai@gmail.com", 3));
            _estudiantes.Add(new EstudianteNuevo(320, "Ramona", "Vals", "vals@gmail.com"));
            _estudiantes.Add(new EstudianteNuevo(321, "Alejandro", "Medina", "medi@gmail.com"));

            _profesores.Add(new Profesor(5, "Jorgelina", "Ramos"));
            _profesores.Add(new Profesor(6, "Juan", "Gutierrez"));

            _materias.Add(new Materia(1, "Matemática Discreta I"));
            _materias.Add(new Materia(3, "Algoritmos I"));
            _materias.Add(new Materia(2, "Electromagnetismo I"));


        }

    }
}
