using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números enteros que desea ingresar: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }

            
            int sumatoria = 0;

            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }

                
                sumatoria += numero;
            }

            
            if (sumatoria >= 100)
            {
                Console.WriteLine($"La sumatoria es mayor o igual a 100: {sumatoria}");
            }
            else
            {
                Console.WriteLine($"La sumatoria es menor a 100: {sumatoria}");
            }
        }
    }
}
