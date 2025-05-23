using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números impares del 1 al 30:");

            
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 != 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
