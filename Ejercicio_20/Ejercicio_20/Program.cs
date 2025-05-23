using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la materia: ");
            string materia = Console.ReadLine();


            double[] notas = new double[4];
            double promedio = 0;
            double notaCompletiva = 0;
            double notaExtraordinaria = 0;


            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ingrese la nota {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 100)
                {
                    Console.WriteLine("Por favor, ingrese una nota válida (0-100).");
                }
            }


            promedio = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;


            if (promedio >= 70)
            {
                Console.WriteLine($"\n{nombre} ha aprobado la materia {materia} con un promedio de {promedio:F2}.");
            }
            else
            {

                double notaCompletivaPromedio = promedio * 0.5;

                Console.Write("Ingrese la nota del examen completivo: ");
                double notaCompletivo;
                while (!double.TryParse(Console.ReadLine(), out notaCompletivo) || notaCompletivo < 0 || notaCompletivo > 100)
                {
                    Console.WriteLine("Por favor, ingrese una nota válida (0-100) para el examen completivo.");
                }

                double notaCompletivoExamen = notaCompletivo * 0.5;
                notaCompletiva = notaCompletivaPromedio + notaCompletivoExamen;

                if (notaCompletiva >= 70)
                {
                    Console.WriteLine($"\n{nombre} ha aprobado la parte completiva con una nota de {notaCompletiva:F2}.");
                }
                else
                {

                    double notaExtraordinariaPromedio = promedio * 0.3;

                    Console.Write("Ingrese la nota del examen extraordinario: ");
                    double notaExtraordinario;
                    while (!double.TryParse(Console.ReadLine(), out notaExtraordinario) || notaExtraordinario < 0 || notaExtraordinario > 100)
                    {
                        Console.WriteLine("Por favor, ingrese una nota válida (0-100) para el examen extraordinario.");
                    }

                    double notaExtraordinarioExamen = notaExtraordinario * 0.7;
                    notaExtraordinaria = notaExtraordinariaPromedio + notaExtraordinarioExamen;

                    if (notaExtraordinaria >= 70)
                    {
                        Console.WriteLine($"\n{nombre} ha aprobado la parte extraordinaria con una nota de {notaExtraordinaria:F2}.");
                    }
                    else
                    {
                        Console.WriteLine($"\n{nombre} ha reprobado la materia {materia} con un promedio de {promedio:F2}.");
                    }
                }
            }
        }
    }
}
