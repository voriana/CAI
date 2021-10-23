using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Negocio.Abstractas
{
    public abstract class Indumentaria
    {
        private int _codigo;
        private int _stock;
        private string _talle;
        private double _precio;
        //constructo vacio
        public Indumentaria()
        {

        }

        public Indumentaria(int codigo, string talle, double precio,int stock=3)
        {
            this._codigo = codigo;
            this._talle = talle;
            this._precio = precio;
            this._stock = stock;
            
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }
        public string Talle
        {
            get
            {
                return _talle;
            }
        }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }
        public double Precio
        {    
            get
            {
                return _precio;
            }
        }
        //Metodos 
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            } 
            if (this._codigo == ((Indumentaria)obj)._codigo)
            {
                return true;
            }
            return false;

        }

        public override string ToString()
        {
            return String.Format("");
        }

        public abstract string GetDetalle();
    }
}
