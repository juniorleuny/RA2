using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contrasenaCorrecta = "Password1"; 
            int maxIntentos = 3;

            
            for (int intento = 1; intento <= maxIntentos; intento++)
            {
                Console.Write("Ingrese la contraseña: ");
                string contrasenaIngresada = Console.ReadLine();

                
                if (contrasenaIngresada == contrasenaCorrecta)
                {
                    Console.WriteLine("Contraseña correcta. Acceso concedido.");
                    return; 
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
                }

                
                if (intento < maxIntentos)
                {
                    Console.WriteLine($"Le quedan {maxIntentos - intento} intentos.");
                }
            }

            
            Console.WriteLine("Ha agotado el número de intentos. El programa se cerrará.");
        }
    }
}
