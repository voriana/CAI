using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Negocio
{
    public class Venta
    {    
        //atributos
        private List<VentaItem> _items;
        private Cliente _cliente;
        private int _estado;
        private int _codigo;

        //constructor
        public Venta()
        {

        }
       
        //propiedades 
        public List<VentaItem> Item
        {
            get
            {
                return _items;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }
        }
        public int Estado
        {
            get
            {
                return _estado;
            }
        }
        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }

        public double GetTotalPedido()
        {
            double total=0;
            foreach (VentaItem item in _items)
            {
                total += item.Cantidad * item.Prenda.Precio;
            }
            return total;
        }
    }
}
