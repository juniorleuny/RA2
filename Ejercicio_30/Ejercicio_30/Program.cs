using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    internal class Program
    {
       
        
            static int Sumar(int a, int b)
            {
                return a + b;
            }

           
            static int Multiplicar(int a, int b)
            {
                return a * b;
            }

            
            static void ParOImpar(int numero)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El número {numero} es par.");
                }
                else
                {
                    Console.WriteLine($"El número {numero} es impar.");
                }
            }

           
            static double ConvertirADolares(double dolares)
            {
                const double tasaCambio = 55.0; 
                return dolares * tasaCambio;
            }

            static void Main()
            {
                
                Console.Write("Ingrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

             
                int suma = Sumar(num1, num2);
                int producto = Multiplicar(num1, num2);

                Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
                Console.WriteLine($"La multiplicación de {num1} y {num2} es: {producto}");

                
                Console.Write("Ingrese un número para verificar si es par o impar: ");
                int numeroVerificar = int.Parse(Console.ReadLine());
                ParOImpar(numeroVerificar);

                
                Console.Write("Ingrese la cantidad en dólares para convertir a pesos dominicanos: ");
                double dolares = double.Parse(Console.ReadLine());
                double pesos = ConvertirADolares(dolares);

                Console.WriteLine($"{dolares} dólares son equivalentes a {pesos} pesos dominicanos.");
            }
    }
}
