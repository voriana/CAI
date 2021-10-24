using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesFacultad.Negocio.Abstractas;

namespace ClasesFacultad.Negocio
{
    public class Docente: Empleado
    {
        public Docente(int legajo, string nombre, string apellido, DateTime nac, DateTime fechaIngreso) : base(legajo, nombre, apellido, nac, fechaIngreso)
        {
        }

        public override string GetNombreCompleto()
        {
            return $"DOCENTE {base.GetNombreCompleto()}";
        }
    }
}
