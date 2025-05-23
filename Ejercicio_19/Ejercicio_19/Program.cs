using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el sueldo del empleado: ");
            double sueldo;
            while (!double.TryParse(Console.ReadLine(), out sueldo) || sueldo < 0)
            {
                Console.WriteLine("Por favor, ingrese un número válido para el sueldo.");
            }

            
            Console.Write("Ingrese el número de hijos del empleado: ");
            int numeroHijos;
            while (!int.TryParse(Console.ReadLine(), out numeroHijos) || numeroHijos < 0)
            {
                Console.WriteLine("Por favor, ingrese un número válido para el número de hijos.");
            }

            
            double incentivo = 0;
            if (numeroHijos > 0)
            {
                incentivo = numeroHijos * 500;
            }

            Console.WriteLine($"\nSueldo del empleado: {sueldo:F2} pesos");
            Console.WriteLine($"Número de hijos: {numeroHijos}");
            Console.WriteLine($"Incentivo correspondiente: {(numeroHijos > 0 ? incentivo.ToString("F2") : "N/A")}");
        }
    }
}
