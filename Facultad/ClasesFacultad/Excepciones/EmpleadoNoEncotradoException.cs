using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesFacultad.Negocio.Abstractas;

namespace ClasesFacultad.Excepciones
{
    public class EmpleadoNoEncotradoException:Exception
    {
        public EmpleadoNoEncotradoException(Empleado emple) : base("Empleado con legajo nro: {emple.Legajo} no se ha encontrado") { }
    }
}
