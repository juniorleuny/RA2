using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números que desea ingresar: ");
            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }

            
            int[] numeros = new int[cantidad];

           
            int sumatoria = 0;
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }
                sumatoria += numeros[i]; 
            }

            
            if (sumatoria >= 100)
            {
                Console.WriteLine($"La sumatoria de los números ingresados es: {sumatoria}");
            }
            else
            {
                Console.WriteLine($"La sumatoria de los números ingresados es menor que 100: {sumatoria}");
            }

        }
    }
}
