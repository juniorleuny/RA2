using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }
        }
    }
}
