using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases.Negocio.Abstractas;
using BibliotecaDeClases.Excepciones;

namespace BibliotecaDeClases.Negocio
{
    public class TiendaRopa
    {
        private List<Indumentaria> _inventario;
        private List<Venta> _ventas;
        private int _utlimoCodigo;

        //metodos
        private int GetUltimoCodigo()
        {
            return (_utlimoCodigo + 1);
        }

        //Agregar indumentaria
        public void Agregar (Indumentaria indumentaria)
        {
            foreach (Indumentaria ind in _inventario)
            {
                if (ind.Codigo == indumentaria.Codigo)
                {
                    throw new Exception("Ya existe un producto con ese codigo");
                }

            }
            _inventario.Add(indumentaria);
        }

        //Modificar indumentaria
        public void Modificar(Indumentaria indumentaria)
        {
            
        }
       

        //Agregar indumentaria
        public void Quitar(Indumentaria indumentaria)
        {
            foreach (Indumentaria ind in _inventario)
            {
                if (ind.Codigo != indumentaria.Codigo)
                {
                    throw new Exception("No existe un producto con ese codigo");
                }

            }
            _inventario.Remove(indumentaria);
        }
        //Ingresar orden
        public void IngresarOrden(Venta venta)
        {
            
            foreach (Venta v in _ventas)
            {
                if (v.Codigo== venta.Codigo)
                {
                    throw new Exception("Esta orden ya esta registrada");
                }
            }

            //debo restar stock
            foreach (VentaItem item in venta.Item)
            {
               foreach(Indumentaria indu in _inventario)
               {
                    if(item.Prenda.Codigo== indu.Codigo)
                    {
                        indu.Stock -= item.Cantidad;
                    }else if (indu.Stock < item.Cantidad)
                    {
                        throw new SinStockException(indu);
                    }
               }

            }
        }

        // Listar 
        public  List<Indumentaria> Listar()
        {
            return _inventario;
        }

        //ListarOrdenes
        public List<Venta> ListarOrden()
        {
            return _ventas;
;
        }

        //devolver orden
        public void DevolverOrden(Venta venta)
        {
            if (_ventas.Any())
            {
                foreach (Venta ve in _ventas)
                {
                    if (ve.Codigo == venta.Codigo)
                    {
                        venta.GetTotalPedido();//cpmo devuelvo esto si void
                    }
                    else
                    {
                        throw new Exception("No existe la orden especificada. por favor verifique los datos ingresados");
                    }
                }
            }
            else
            {
                throw new Exception("No hay ordenes en la lista");
            }
        }
    }
}
