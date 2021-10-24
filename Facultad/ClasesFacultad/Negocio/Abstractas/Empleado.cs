using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFacultad.Negocio.Abstractas
{
    public class Empleado: Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;
        private DateTime nac;

        public Empleado(int legajo, string nombre, string apellido, DateTime nac, DateTime fechaIngreso):base (nombre,apellido,nac)
        {
            this._legajo = legajo;
            this._fechaIngreso = fechaIngreso;
            this._salarios=new List<Salario>();
            _salarios.Add(new Salario());




        }

        public Empleado()
        {
        }

        public DateTime FechaIngreso { get { return _fechaIngreso; } }
        public int Legajo { get { return _legajo; }set { _legajo = value; } }
        public List<Salario> Salarios { get { return _salarios; } }
        public Salario UltimoSalario()
        {
            return _salarios.Last();
        }
        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }

            if (this._legajo == ((Empleado)o).Legajo)
            {
                return true;
            }

            return false;
        }

        
        public override string GetCredencial()
        {
            return string.Format($"{Legajo} - {GetNombreCompleto()} ");  
        }
    }
}
