using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
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

            
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorPares = 0;
            int contadorImpares = 0;

            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }

                
                if (numero > 0)
                {
                    contadorPositivos++;
                }
                else if (numero < 0)
                {
                    contadorNegativos++;
                }

                if (numero % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }

            
            Console.WriteLine($"\nCantidad de números positivos: {contadorPositivos}");
            Console.WriteLine($"Cantidad de números negativos: {contadorNegativos}");
            Console.WriteLine($"Cantidad de números pares: {contadorPares}");
            Console.WriteLine($"Cantidad de números impares: {contadorImpares}");
        }
    }
}
