using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPresentismo.Negocio.Abstractas;

namespace ClasesPresentismo.Negocio
{
    public class AlumnoRegular:Alumno
    {
        private string _email;

        public AlumnoRegular(int registro, string nombre, string apellido,string email):base (registro, nombre, apellido)
        {
            this._email = email;
        }
    }
}
