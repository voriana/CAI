using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;

namespace ClasesDeNegocio.Negocio
{
    public class Materia
    {
        private int _codigo;
        private string _descripcion;

        public Materia(int v1, string v2)
        {
            this._codigo = v1;
            this._descripcion = v2;
            

        }

        public int Codigo
        {
            get { return _codigo; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
        }

        public override string ToString()
        {
            return string.Format($"CODIGO) {Codigo} -DESCRIPCION {Descripcion}");
        }

    }
}