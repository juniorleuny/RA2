using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class Estudiante
    {
        
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
    }

    class Program
    {
        static void Main()
        {
            
            Estudiante[] estudiantes = new Estudiante[5];

            
            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Estudiante(); 

                Console.WriteLine($"\nIntroduce los datos del estudiante {i + 1}:");

                Console.Write("Matrícula: ");
                estudiantes[i].Matricula = Console.ReadLine();

                Console.Write("Nombre: ");
                estudiantes[i].Nombre = Console.ReadLine();

                Console.Write("Edad: ");
                estudiantes[i].Edad = int.Parse(Console.ReadLine());

                Console.Write("Carrera: ");
                estudiantes[i].Carrera = Console.ReadLine();
            }

            
            Console.WriteLine("\nDatos de los estudiantes:");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"\nEstudiante {i + 1}:");
                Console.WriteLine($"Matrícula: {estudiantes[i].Matricula}");
                Console.WriteLine($"Nombre: {estudiantes[i].Nombre}");
                Console.WriteLine($"Edad: {estudiantes[i].Edad}");
                Console.WriteLine($"Carrera: {estudiantes[i].Carrera}");
            }
        }
    }
}
