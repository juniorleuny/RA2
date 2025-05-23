using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la cantidad del artículo:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el precio del artículo (en pesos):");
            double precio = Convert.ToDouble(Console.ReadLine());

            
            double importeTotal = cantidad * precio;

            
            Console.WriteLine($"El importe total es: {importeTotal:F2} pesos");
        }
    }
}
