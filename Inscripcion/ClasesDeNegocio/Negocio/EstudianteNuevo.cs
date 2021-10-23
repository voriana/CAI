using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;

namespace ClasesDeNegocio.Negocio
{
    public class EstudianteNuevo : Estudiante
    {
        public EstudianteNuevo(int v1, string v2, string v3, string v4): base (v1,v2,v3,v4)
        {
        }
    }
}
