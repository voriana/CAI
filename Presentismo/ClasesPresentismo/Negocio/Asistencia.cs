using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPresentismo.Negocio.Abstractas;

namespace ClasesPresentismo.Negocio
{
    public class Asistencia
    {
        private string _fechaReferencia;
        private DateTime _fechaReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;

        

        public string FechaReferencia{ get { return _fechaReferencia; } set { _fechaReferencia = value; } }
        public DateTime FechaReal { get { return _fechaReal; } set { _fechaReal = value; } }
        public Preceptor Preceptor{ get { return _preceptor; } set { _preceptor = value; } }
        public bool Presente{get{ return _estaPresente; }set{  _estaPresente = value;} }
        public Alumno Alumno { get { return _alumno; } set { _alumno = value; } }

        public override string ToString()
        {
            return string.Format($"FECHAREFERENCIA { _alumno.ToString()}  está presente {_estaPresente} -Preceptor {Preceptor} registrado el {FechaReal}");
        }
    }
}
