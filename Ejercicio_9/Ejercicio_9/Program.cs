using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que introduzca el precio del artículo
            Console.WriteLine("Introduce el precio del artículo (en pesos):");
            double precio = Convert.ToDouble(Console.ReadLine());

            // Inicializar el porcentaje de descuento
            double porcentajeDescuento = 0;

            // Determinar el porcentaje de descuento según la escala
            if (precio >= 1000 && precio <= 5000)
            {
                porcentajeDescuento = 0.03; // 3%
            }
            else if (precio > 5000 && precio <= 10000)
            {
                porcentajeDescuento = 0.05; // 5%
            }
            else if (precio > 10000 && precio <= 15000)
            {
                porcentajeDescuento = 0.08; // 8%
            }
            else if (precio > 15000 && precio <= 20000)
            {
                porcentajeDescuento = 0.10; // 10%
            }

            // Calcular el descuento
            double descuento = precio * porcentajeDescuento;

            // Mostrar los resultados
            Console.WriteLine($"Precio del artículo: {precio:F2} pesos");
            Console.WriteLine($"Descuento aplicado: {descuento:F2} pesos");
        }
    }
}
