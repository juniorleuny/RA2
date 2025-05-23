using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    internal class Program
    {
        static void MostrarCalificaciones(string[] nombres, int[] calificaciones)
        {
            Console.WriteLine("\nLista de Estudiantes y sus Calificaciones:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{nombres[i]}: {calificaciones[i]}");
            }
        }

        static void Main()
        {
            
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes;
            while (!int.TryParse(Console.ReadLine(), out cantidadEstudiantes) || cantidadEstudiantes <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }

            
            string[] nombres = new string[cantidadEstudiantes];
            int[] calificaciones = new int[cantidadEstudiantes];

            
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
                nombres[i] = Console.ReadLine();

                Console.Write($"Ingrese la calificación de {nombres[i]}: ");
                while (!int.TryParse(Console.ReadLine(), out calificaciones[i]))
                {
                    Console.WriteLine("Por favor, ingrese una calificación válida (número entero).");
                }
            }

            
            MostrarCalificaciones(nombres, calificaciones);
        }
    }
}
