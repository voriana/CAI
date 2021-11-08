using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class TipoDocumento
    {
        private int _codigo;
        private string _descripcion;

        //necesita constructor vacio para deserializar
        public TipoDocumento() { }

        public TipoDocumento(int codigo, string descripcion)
        {
            _codigo = codigo;
            _descripcion = descripcion;

        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}