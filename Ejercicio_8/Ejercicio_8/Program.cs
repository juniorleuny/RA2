using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la edad de la persona:");
            int edad = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Introduce el sexo de la persona (hembra/varón):");
            string sexo = Console.ReadLine().ToLower();


            if (edad < 18)
            {
                Console.WriteLine("No puede entrar a la discoteca, es menor de edad.");
            }
            else
            {
                if (sexo == "hembra")
                {
                    Console.WriteLine("Puede entrar a la discoteca gratis.");
                }
                else if (sexo == "varón")
                {
                    Console.WriteLine("Puede entrar a la discoteca, pero debe pagar.");
                }
                else
                {
                    Console.WriteLine("Sexo no válido. Por favor, introduce 'hembra' o 'varón'.");
                }
            }

        }
    }
}
