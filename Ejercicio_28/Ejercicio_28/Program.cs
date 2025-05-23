using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumatoria = 0;
            int numero;

            Console.WriteLine("Ingrese números para sumar. Ingrese 0 para finalizar.");

            
            do
            {
                Console.Write("Ingrese un número: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }

                
                if (numero != 0)
                {
                    sumatoria += numero;
                }

            } while (numero != 0); 

            
            Console.WriteLine($"\nLa sumatoria de los números ingresados es: {sumatoria}");

        }
    }
}
