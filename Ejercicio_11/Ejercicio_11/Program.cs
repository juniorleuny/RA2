using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
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

            
            char literal;
            if (promedio >= 90)
            {
                literal = 'A';
            }
            else if (promedio >= 80)
            {
                literal = 'B';
            }
            else if (promedio >= 70)
            {
                literal = 'C';
            }
            else if (promedio >= 60)
            {
                literal = 'D';
            }
            else
            {
                literal = 'F';
            }

            
            Console.WriteLine($"Promedio de las calificaciones: {promedio:F2}");
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine($"Literal: {literal}");
        }
    }
}
