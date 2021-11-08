using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente:Persona
    {
        private int _id;
        private long _cuit;
        private string _email;
        private DateTime _fechaNacimiento;
        private bool _activo;
        private string _direccion;
        private string _telefono;
        //constructor
        public Cliente(int id, long cuit, string email, DateTime fechaNac,bool activo,string nombre, string apellido, TipoDocumento tipoDocu, string direccion, string telefono):base(nombre,apellido, tipoDocu)
        {
            this._id = id;
            this._cuit = cuit;
            this._email = email;
            this._fechaNacimiento = fechaNac;
            this._activo = activo;
            this._direccion = direccion;
            this._telefono = telefono;
        }


        public int Id { get => _id; set => _id = value; }
        public long Cuit { get => _cuit; set => _cuit = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public  bool Activo { get => _activo; set => _activo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        //propiedad para mostrar datos del cliente
        public string Mostrar { get => $"Nombre: {Nombre}- Apellido:{Apellido}- ID: {Id}- Cuit:{Cuit}"; }
        
    }
}
