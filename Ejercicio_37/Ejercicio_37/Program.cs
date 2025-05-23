using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Articulo
    {
       
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }

    class Program
    {
        static void Main()
        {
            
            Articulo articulo1 = new Articulo();
            Articulo articulo2 = new Articulo();

            
            Console.WriteLine("Introduce el nombre del primer artículo:");
            articulo1.Nombre = Console.ReadLine();

            Console.WriteLine("Introduce el precio del primer artículo:");
            articulo1.Precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la categoría del primer artículo:");
            articulo1.Categoria = Console.ReadLine();

            
            Console.WriteLine("Introduce el nombre del segundo artículo:");
            articulo2.Nombre = Console.ReadLine();

            Console.WriteLine("Introduce el precio del segundo artículo:");
            articulo2.Precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la categoría del segundo artículo:");
            articulo2.Categoria = Console.ReadLine();

            
            Console.WriteLine("\nDatos del primer artículo:");
            Console.WriteLine($"Nombre: {articulo1.Nombre}");
            Console.WriteLine($"Precio: {articulo1.Precio:C}"); 
            Console.WriteLine($"Categoría: {articulo1.Categoria}");

            Console.WriteLine("\nDatos del segundo artículo:");
            Console.WriteLine($"Nombre: {articulo2.Nombre}");
            Console.WriteLine($"Precio: {articulo2.Precio:C}"); 
            Console.WriteLine($"Categoría: {articulo2.Categoria}");
        }
    }
}
