using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
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

            
            int suma = numero1 + numero2 + numero3;
            int resta = numero1 - numero2 - numero3;
            int multiplicacion = numero1 * numero2 * numero3;
            double division;

            
            if (numero2 != 0 && numero3 != 0)
            {
                division = (double)numero1 / numero2 / numero3;
            }
            else
            {
                division = double.NaN; 
            }

            
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");
            if (numero2 != 0 && numero3 != 0)
            {
                Console.WriteLine($"División: {division}");
            }
            else
            {
                Console.WriteLine("División: No se puede dividir por cero.");
            }
        }
    }
}
