using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPresentismo.Excepciones
{
    public class AsistenciaInconsistenteException:Exception
    {
        public AsistenciaInconsistenteException() : base("No coincide la cantidad de alunmos regulares") { }
    }
}
