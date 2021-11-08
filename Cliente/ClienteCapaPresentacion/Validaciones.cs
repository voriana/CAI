using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteCapaPresentacion
{
    class Validaciones
    {
		// validaciones
		// una clase statica no necesita instanciar , que sirva de libreria final para 
		public static string ValidarString( string entrada)
		{
			if (string.IsNullOrEmpty(entrada))
			{
				throw new Exception($"Dato Invalido. No puede ingresar una cadena vacia");

            } 
			return entrada;
		}

        public static long ValidarLong(string text)
        {
			long salida;


			if (!long.TryParse(text, out salida))
			{
				throw new Exception($"Error, Debe ingresar un valor numerico");

			}
			if (salida < 0)
			{
				throw new Exception($"Dato Invalido. Debe ingresar un numero positivo");
			}
			return salida;
		}

        /// <summary>
        /// convertir string a fecha
        /// </summary>
        /// <param name="Para poder validar 
        /// este metodo desde donde lo llamo tengo que hacer el try-catch"></param>
        /// <returns></rey mostrar el mensaje de la excepcionturns>

        public static DateTime PedirFecha(string msj)
		{

			DateTime fecha = new DateTime();
			
			try
			{
				fecha = Convert.ToDateTime(msj); //System.FormatException

			}
			catch (Exception)
			{
				throw new Exception("ERROR.Formato no valido.");
			}

			return fecha;
		}



		// validar entero positivo
		public static int ValidarInt(string entrada)
		{
			int salida;
			
			
				
				if (!int.TryParse(entrada, out salida))
				{
					throw new Exception($"Error, Debe ingresar un valor numerico");

				}
				if (salida < 0)
				{
					throw new Exception($"Dato Invalido. Debe ingresar un numero positivo");
				}
			return salida;	


		}


		// validar double positivo
		public static double ValidarDouble(string mensaje)
		{
			double salida;
			bool flag = false;
			string entrada;
			do
			{
				Console.WriteLine($"Ingrese {mensaje}");
				entrada = Console.ReadLine();
				if (!double.TryParse(entrada, out salida))
				{
					Console.WriteLine($"Error, Debe ingresar un valor numerico");

				}
				else if (salida < 0)
				{
					Console.WriteLine($"Dato Invalido. Debe ingresar un numero positivo");
				}
				else
				{
					flag = true;
				}

			} while (flag == false);
			return salida;
		}


		// Devolver boolean // en el mensaje le tengo que mandar la pregunta
		public static bool RetornaBooleano(string mensaje)
		{
			//double salida;
			bool flag = false;
			string entrada;
			do
			{
				Console.WriteLine($"{mensaje}");
				entrada = Console.ReadLine().ToUpper();
				if (entrada != "S" && entrada != "N")
				{
					Console.WriteLine($"Error,Los valores permitidos son  [S/N]");
				}
				else
				{ // el usuario ingreso 'S' o 'N'
					if (entrada.Equals("S"))
					{
						flag = true;
					}
					break;
				}
			} while (true);
			return flag;
		}
		// validar minimo
		public static int ValidarMinimo(string msj, int minimo)
		{
			bool flag = false;
			string entrada = "";
			int numero = 0;

			do
			{
				Console.WriteLine($"Ingrese {msj}");
				entrada = Console.ReadLine();
				numero = Convert.ToInt32(entrada);
				if (numero < minimo)
				{
					Console.WriteLine($"Error, El valor minimo permitido es {minimo} ");
				}
				else
				{
					flag = true;
				}

			} while (flag == false);
			return numero;
		}


		///////////Menu
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
	}
}
