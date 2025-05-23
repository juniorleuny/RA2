using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[4];
            double suma = 0;

            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Introduce la nota {i + 1}:");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                suma += notas[i]; 
            }

            
            double promedio = suma / 4;

           
            string resultado = promedio >= 70 ? "Aprobó" : "Reprobó";

            
            Console.WriteLine($"Promedio de las calificaciones: {promedio:F2}");
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
