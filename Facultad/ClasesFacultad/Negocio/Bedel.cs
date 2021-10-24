using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesFacultad.Negocio.Abstractas;

namespace ClasesFacultad.Negocio
{
    public class Bedel : Empleado
    {
        private string _apodo;
        


        public Bedel(int legajo, string nombre, string apellido, DateTime nac, DateTime ingreso, string apodo):base (legajo, nombre, apellido, nac, ingreso)
        {
            
            this._apodo = apodo;
        }

        public string Apodo { get { return _apodo; } set { _apodo = value; } }
        public override string GetNombreCompleto()
        {
            return $"BEDEL { base.GetNombreCompleto()} + -Apodo {Apodo}";
        }

    }
}
