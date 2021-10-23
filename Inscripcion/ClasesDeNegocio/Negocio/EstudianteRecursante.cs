using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDeNegocio.Negocio.Abstractas;


namespace ClasesDeNegocio.Negocio
{
    public class EstudianteRecursante: Estudiante
    {
        private int _cantidadCursosTomados;

        public EstudianteRecursante(int v1, string v2, string v3, string v4, int v5): base (v1,v2,v3,v4)
        {
            this._cantidadCursosTomados = v5;
        }

        public int Cursos
        {
            get
            {
                return _cantidadCursosTomados;
            }
        }
    }
}
