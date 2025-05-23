using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduce el sueldo del empleado (en pesos):");
            double sueldoAnterior = Convert.ToDouble(Console.ReadLine());

            
            double aumento = sueldoAnterior * 0.15;
            double nuevoSueldo = sueldoAnterior + aumento;

            
            Console.WriteLine($"Sueldo Anterior: {sueldoAnterior:F2} pesos");
            Console.WriteLine($"Aumento (15%): {aumento:F2} pesos");
            Console.WriteLine($"Nuevo Sueldo: {nuevoSueldo:F2} pesos");
        }
    }
}
