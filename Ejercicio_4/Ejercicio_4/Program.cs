using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double suma = 0;

           
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Introduce el número {i}:");
                double numero = Convert.ToDouble(Console.ReadLine());
                suma += numero; 
            }

            
            double promedio = suma / 5;

            
            Console.WriteLine($"La suma total es: {suma}");
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}
