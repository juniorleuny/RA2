using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el sueldo del empleado (en pesos):");
            double sueldoBruto = Convert.ToDouble(Console.ReadLine());

            
            double descuentoAFP = sueldoBruto * 0.0287; // 2.87%
            double descuentoSFS = sueldoBruto * 0.0304; // 3.04%
            double totalDescuentos = descuentoAFP + descuentoSFS;

            
            double isr = 0;
            if (sueldoBruto <= 416220)
            {
                isr = 0; 
            }
            else if (sueldoBruto > 867123)
            {
                isr = 79776 + (sueldoBruto - 867123) * 0.25; 
            }

            
            double sueldoNeto = sueldoBruto - totalDescuentos - isr;

            
            Console.WriteLine($"Sueldo Bruto: {sueldoBruto:F2} pesos");
            Console.WriteLine($"Descuento AFP (2.87%): {descuentoAFP:F2} pesos");
            Console.WriteLine($"Descuento SFS (3.04%): {descuentoSFS:F2} pesos");
            Console.WriteLine($"ISR: {(isr > 0 ? isr.ToString("F2") : "N/A")}");
            Console.WriteLine($"Sueldo Neto: {sueldoNeto:F2} pesos");
        }
    }
}
