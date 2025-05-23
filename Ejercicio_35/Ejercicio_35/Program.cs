using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    internal class DispositivoElectronico
    {
        public string Tipo { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }

        
        public void Encender()
        {
            Console.WriteLine($"El {Tipo} de marca {Marca} está encendido.");
        }

        
        public void Apagar()
        {
            Console.WriteLine($"El {Tipo} de marca {Marca} está apagado.");
        }
    }

    class Program
    {
        static void Main()
        {
            
            DispositivoElectronico dispositivo = new DispositivoElectronico();

            
            Console.Write("Ingrese el tipo del dispositivo: ");
            dispositivo.Tipo = Console.ReadLine();

            Console.Write("Ingrese el color del dispositivo: ");
            dispositivo.Color = Console.ReadLine();

            Console.Write("Ingrese la marca del dispositivo: ");
            dispositivo.Marca = Console.ReadLine();

            
            Console.WriteLine($"\nEl dispositivo es un {dispositivo.Color} {dispositivo.Tipo} de la marca {dispositivo.Marca}.");

            
            dispositivo.Encender();
            dispositivo.Apagar();
        }
    }
}
