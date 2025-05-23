using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
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

            
            int mayor, central, menor;

            
            if (numero1 >= numero2 && numero1 >= numero3)
            {
                mayor = numero1;
                if (numero2 >= numero3)
                {
                    central = numero2;
                    menor = numero3;
                }
                else
                {
                    central = numero3;
                    menor = numero2;
                }
            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
                if (numero1 >= numero3)
                {
                    central = numero1;
                    menor = numero3;
                }
                else
                {
                    central = numero3;
                    menor = numero1;
                }
            }
            else
            {
                mayor = numero3;
                if (numero1 >= numero2)
                {
                    central = numero1;
                    menor = numero2;
                }
                else
                {
                    central = numero2;
                    menor = numero1;
                }
            }

            
            Console.WriteLine($"Número mayor: {mayor}");
            Console.WriteLine($"Número central: {central}");
            Console.WriteLine($"Número menor: {menor}");
        }
    }
}
