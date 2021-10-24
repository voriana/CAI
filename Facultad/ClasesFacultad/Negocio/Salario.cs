using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFacultad.Negocio
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        

        public double GetSalarioNeto()
        {
            return (_bruto - _descuentos);
        }
        public double Salarios { get { return GetSalarioNeto(); } }
        public double Bruto { get { return _bruto; } }
        public double Descuentos { get { return _descuentos; } }
        public DateTime Fecha { get { return _fecha; } }
    }
}
