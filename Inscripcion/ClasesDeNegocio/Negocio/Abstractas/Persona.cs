using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;

namespace ClasesDeNegocio.Negocio.Abstractas
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _email;

        public Persona(string v2, string v3)
        {
            this._nombre = v2;
            this._apellido = v3;
        }

        public Persona(string v2, string v3, string v4)
        {
            this._nombre = v2;
            this._apellido = v3;
            this._email = v4;
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }
        public override string ToString()
        {
            return Mostrar();
        }

        internal abstract string Mostrar();
        
    }
}