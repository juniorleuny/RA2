using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] produccionSemanal = new double[5];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            double totalProduccion = 0;

           
            for (int i = 0; i < dias.Length; i++)
            {
                Console.Write($"Ingrese la producción del {dias[i]}: ");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double produccion))
                    {
                        produccionSemanal[i] = produccion;
                        totalProduccion += produccion;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un número válido.");
                    }
                }
            }

            
            double promedioProduccion = totalProduccion / dias.Length;

            
            double incentivo = (promedioProduccion >= 20000) ? 3000 : 0;

            
            Console.WriteLine($"\nTotal de producción de la semana: {totalProduccion:F2} unidades");
            Console.WriteLine($"Promedio de producción: {promedioProduccion:F2} unidades");
            Console.WriteLine($"Incentivo correspondiente: {(incentivo > 0 ? incentivo.ToString("F2") : "N/A")}");
        }
    }
}
