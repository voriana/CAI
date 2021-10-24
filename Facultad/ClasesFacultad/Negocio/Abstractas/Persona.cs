using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFacultad.Negocio.Abstractas
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected DateTime _fechaNacimiento;

        public Persona()
        {
        }
        public Persona(string nombre, string apellido, DateTime date)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNacimiento = date;
        }


        public DateTime FecNac{get { return _fechaNacimiento; }}
        public string Nombre { get { return _nombre; }  set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public abstract string GetCredencial();


        public virtual string GetNombreCompleto()
        {
            return string.Format($"{_nombre.ToUpper()} {_apellido.ToUpper()} ");
        }

        public override string ToString()
        {
            return string.Format("Nombre completo: {0}- fecha naciminiento: {1}", GetNombreCompleto(), FecNac);
        }
    }
}
