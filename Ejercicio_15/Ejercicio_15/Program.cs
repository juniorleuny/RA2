using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número entero:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número entero:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número entero:");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            
            int mayor = numero1; 

            if (numero2 > mayor)
            {
                mayor = numero2; 
            }

            if (numero3 > mayor)
            {
                mayor = numero3; 
            }

            
            Console.WriteLine($"El número mayor es: {mayor}");
        }
    }
}
