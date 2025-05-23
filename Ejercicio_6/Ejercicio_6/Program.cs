using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
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

           
            double itbis = importeTotal * 0.18;

            
            double descuento = importeTotal * 0.10;

            
            double totalGeneral = importeTotal - descuento + itbis;

            
            Console.WriteLine($"Importe Total: {importeTotal:F2} pesos");
            Console.WriteLine($"ITBIS (18%): {itbis:F2} pesos");
            Console.WriteLine($"Descuento (10%): {descuento:F2} pesos");
            Console.WriteLine($"Total General: {totalGeneral:F2} pesos");
        }
    }
}
