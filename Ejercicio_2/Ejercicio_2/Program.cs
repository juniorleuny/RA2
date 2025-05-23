using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el pago por hora (en pesos):");
            double pagoPorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce las horas trabajadas:");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            
            double sueldoBruto = pagoPorHora * horasTrabajadas;

            
            double descuentoAFP = sueldoBruto * 0.0287; // 2.87%
            double descuentoSFS = sueldoBruto * 0.0304; // 3.04%
            double totalDescuentos = descuentoAFP + descuentoSFS;

            
            double sueldoNeto = sueldoBruto - totalDescuentos;

            // Mostrar los resultados
            Console.WriteLine($"Sueldo Bruto: {sueldoBruto:F2} pesos");
            Console.WriteLine($"Descuento AFP (2.87%): {descuentoAFP:F2} pesos");
            Console.WriteLine($"Descuento SFS (3.04%): {descuentoSFS:F2} pesos");
            Console.WriteLine($"Total Descuentos: {totalDescuentos:F2} pesos");
            Console.WriteLine($"Sueldo Neto: {sueldoNeto:F2} pesos");
        }
    
    }
}
