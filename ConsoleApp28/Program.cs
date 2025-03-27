using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
	namespace videojuego
	{
		internal class Program
		{

			public enum Raza { Humano, Elfo, Enano, Orco }
			public enum Clase { Guerrero, Mago, Arquero, Picaro }

			public class Personaje
			{
				public string Nombre { get; set; }
				public Raza Raza { get; set; }
				public Clase Clase { get; set; }
				public int Fuerza { get; set; }
				public int Inteligencia { get; set; }
				public int Destreza { get; set; }

				public Personaje(string nombre, Raza raza, Clase clase, int fuerza, int inteligencia, int destreza)
				{
					Nombre = nombre;
					Raza = raza;
					Clase = clase;
					Fuerza = fuerza;
					Inteligencia = inteligencia;
					Destreza = destreza;
				}

			}

			public class Programs
			{
				public static void Main(string[] args)
				{
					Console.WriteLine("Creador de personaje ");

					Console.Write("Nombre del personaje: ");
					string nombre = Console.ReadLine();

					Console.WriteLine("Elige la raza:");
					foreach (Raza raza in Enum.GetValues(typeof(Raza)))
					{
						Console.WriteLine($"{(int)raza}. {raza}");
					}
					Raza razaElegida = (Raza)int.Parse(Console.ReadLine());

					Console.WriteLine("Elige la clase:");
					foreach (Clase clase in Enum.GetValues(typeof(Clase)))
					{
						Console.WriteLine($"{(int)clase}. {clase}");
					}
					Clase claseElegida = (Clase)int.Parse(Console.ReadLine());

					Console.WriteLine("Asigna puntos a las estadísticas (total 30 puntos):");
					Console.Write("Fuerza: ");
					int fuerza = int.Parse(Console.ReadLine());
					Console.Write("Inteligencia: ");
					int inteligencia = int.Parse(Console.ReadLine());
					Console.Write("Destreza: ");
					int destreza = int.Parse(Console.ReadLine());

					Personaje nuevoPersonaje = new Personaje(nombre, razaElegida, claseElegida, fuerza, inteligencia, destreza);

					Console.WriteLine("\nPersonaje creado:");
					Console.WriteLine($"Nombre: {nuevoPersonaje.Nombre}");
					Console.WriteLine($"Raza: {nuevoPersonaje.Raza}");
					Console.WriteLine($"Clase: {nuevoPersonaje.Clase}");
					Console.WriteLine($"Fuerza: {nuevoPersonaje.Fuerza}");
					Console.WriteLine($"Inteligencia: {nuevoPersonaje.Inteligencia}");
					Console.WriteLine($"Destreza: {nuevoPersonaje.Destreza}");
				}
			}
		}

	}
}
