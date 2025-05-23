using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }

            

            Console.WriteLine($"La suma de los primeros 100 números naturales es: {suma}");
        }
    }
}
