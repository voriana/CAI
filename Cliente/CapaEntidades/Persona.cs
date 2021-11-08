using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected TipoDocumento _tipoDocumento;
        public string Nombre { get=>_nombre; /*set=>_nombre =value; */}
        public string Apellido { get => _apellido; /*set => _apellido = value;*/ }
        public TipoDocumento TipoDoc { get=> _tipoDocumento; set=> _tipoDocumento=value; }// necesita setter para desc

        //constructor
        public Persona (string nombre , string apellido,TipoDocumento tipoDocumento)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._tipoDocumento = tipoDocumento;
        }
    }
}
