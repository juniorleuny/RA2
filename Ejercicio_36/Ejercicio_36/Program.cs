using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sonidoPerro;
            string sonidoGato;

            
            Console.WriteLine("Introduce el sonido que hace un perro:");
            sonidoPerro = Console.ReadLine();

            
            Console.WriteLine("Introduce el sonido que hace un gato:");
            sonidoGato = Console.ReadLine();

            
            Console.WriteLine($"El sonido que hace un perro es: {sonidoPerro}");
            Console.WriteLine($"El sonido que hace un gato es: {sonidoGato}");
        }
    }
}
