using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases.Negocio;
using BibliotecaDeClases.Negocio.Abstractas;
using BibliotecaDeClases.Excepciones;
using BibliotecaDeClases.Enum;

namespace Consola
{
    class Program
    {
         static bool _consolaActiva;
         static TiendaRopa _tienda;
        public Program()
        {
            _consolaActiva = true;
            _tienda = new TiendaRopa();
        }
        static void Main(string[] args)
        {
            while (_consolaActiva)
            {
               Menu();
               string entrada = Console.ReadLine();
                switch (entrada)
                {
                    case "1":
                        AgregarIndumentaria(_tienda);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "X":
                        _consolaActiva = false;
                        Console.WriteLine("Saliendo del sistema");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;

                }
            }

        }
        //Menu 
        private static void Menu()
        {
            Console.WriteLine("Por favor Ingrese la opcion que desea realizar");
            Console.WriteLine("1- Agregar indumentaria");
            Console.WriteLine("2- Quitar indumentaria");
            Console.WriteLine("3- Modificar indumentaria");
            Console.WriteLine("4- Ingresar orden");
            Console.WriteLine("5- Listar indumentaria");
            Console.WriteLine("6- Listar Ordenes");
            Console.WriteLine("7- Devolver venta");
            Console.WriteLine("X- Para salir del sistema");
            
        }

        //Agregar indumentaria 
        private static void AgregarIndumentaria(TiendaRopa tienda)
        {
            try
            {
                //solicito los datos que deseo agregar
                Console.WriteLine("Ingrese la prenda que sea agregar");
                string prenda = Console.ReadLine().ToUpper();
                Console.WriteLine($"Ingrese Codigo de  la  {prenda} que desea agregar");
                int codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ingrese Cantidad de {prenda} que desea agregar");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ingrese Talle de {prenda} que desea agregar");
                string talle = Console.ReadLine();
                Console.WriteLine($"Ingrese precio asignado para {prenda} ");
                double precio = Convert.ToDouble(Console.ReadLine());
                
                int stock = 0; //validar el stock
                do
                {
                    Console.WriteLine($"Ingrese stock asignado para la {prenda} ");
                    stock = Convert.ToInt32(Console.ReadLine());
                    if (stock < 3)
                    {
                        Console.WriteLine("El stock minimo es 3");
                        // o lanzar una excepcion
                    }
                } while (stock < 3);

                if (prenda.Equals("CAMISA"))
                {
                    Camisa camisa = new Camisa(codigo, talle, precio);
                    _tienda.Agregar(camisa);//llamo al metodo de la clase tiendaRopa
                }
                else if (prenda.Equals("PANTALON"))
                {
                    Pantalon pantalon = new Pantalon(codigo, talle, precio);
                    _tienda.Agregar(pantalon); //llamo al metodo de la clase tiendaRopa
                }
                else
                {
                    throw new Exception("No a ingresado una prenda valida");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void QuitarIndumentaria(TiendaRopa tienda)
        {
            try
            {
                Console.WriteLine("Ingrese codigo de la prenda que desea elimninar");
                int codigo = Convert.ToInt32(Console.ReadLine());
                if (tienda.Listar().Any())
                {
                   foreach (Indumentaria indu in tienda.Listar())
                   {
                        if(indu.Codigo == codigo)
                        {
                            tienda.Quitar(indu);
                        }
                   }
                }
                else
                {
                    throw new Exception("No existe la prenda que desea eliminar");
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
