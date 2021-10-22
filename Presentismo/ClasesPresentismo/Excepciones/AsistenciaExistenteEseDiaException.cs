using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPresentismo.Excepciones
{
    public class AsistenciaExistenteEseDiaException:Exception
    {
        public AsistenciaExistenteEseDiaException():base("Ya existe asistencia para esa fecha") { }
    }
}
