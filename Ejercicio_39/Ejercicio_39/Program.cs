using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
    class Operacion
    {
        public virtual double Calcular(double a, double b)
        {
            return 0; 
        }
    }

    class Suma : Operacion
    {
        public override double Calcular(double a, double b)
        {
            return a + b;
        }
    }

    class Resta : Operacion
    {
        public override double Calcular(double a, double b)
        {
            return a - b;
        }
    }

    class Multiplicacion : Operacion
    {
        public override double Calcular(double a, double b)
        {
            return a * b;
        }
    }

    class Division : Operacion
    {
        public override double Calcular(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main()
        {
            double num1, num2;
            Console.WriteLine("Introduce el primer número:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            num2 = double.Parse(Console.ReadLine());

            
            Operacion suma = new Suma();
            Operacion resta = new Resta();
            Operacion multiplicacion = new Multiplicacion();
            Operacion division = new Division();

            
            Console.WriteLine($"Suma: {suma.Calcular(num1, num2)}");
            Console.WriteLine($"Resta: {resta.Calcular(num1, num2)}");
            Console.WriteLine($"Multiplicación: {multiplicacion.Calcular(num1, num2)}");

            try
            {
                Console.WriteLine($"División: {division.Calcular(num1, num2)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
