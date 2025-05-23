using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la altura del triángulo: ");
            int altura;


            while (!int.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }


            for (int i = 1; i <= altura; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }
        }
    }
}
