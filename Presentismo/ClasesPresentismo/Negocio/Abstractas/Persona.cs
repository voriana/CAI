using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPresentismo.Negocio.Abstractas
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public string Nombre
        {
            get { return _nombre; }
        }
        public string Apellido
        {
            get { return _apellido; }
        }
        public override string ToString()
        {
            return Display();
        }

        internal abstract string Display();
    }
}
