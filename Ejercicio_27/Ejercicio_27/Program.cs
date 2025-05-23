using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para mostrar su tabla de multiplicar: ");
            int numero;

            
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.");
            }

            
            Console.WriteLine($"\nTabla de multiplicar del {numero}:");
            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}
