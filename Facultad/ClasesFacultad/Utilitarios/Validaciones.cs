using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFacultad.Utilitarios
{
	public static class Validaciones
	{
		// validaciones
		// una clase statica no necesita instanciar , que sirva de libreria final para 
		public static string ValidarString(string mensaje)
		{
			//string salida;
			bool flag = false;
			string entrada;
			do
			{
				Console.WriteLine($"Ingrese {mensaje}");
				entrada = Console.ReadLine();
				if (string.IsNullOrEmpty(entrada))
				{
					Console.WriteLine($"Dato Invalido. No puede ingresar una cadena vacia");

				}

				else
				{
					flag = true;
				}

			} while (flag == false);
			return entrada;

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
			string entrada;
			Console.WriteLine($"{msj} con el formato [YYYY-MM-DD]");
			entrada = Console.ReadLine();
			try
			{
				fecha = Convert.ToDateTime(entrada); //System.FormatException

			}
			catch (Exception)
			{
				throw new Exception("ERROR.Formato no valido.");
			}

			return fecha;
		}



		// validar entero positivo
		public static int ValidarInt(string mensaje)
		{
			int salida;
			bool flag = false;
			string entrada;
			do
			{
				Console.WriteLine($"Ingrese {mensaje}");
				entrada = Console.ReadLine();
				if (!int.TryParse(entrada, out salida))
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


	}
}
