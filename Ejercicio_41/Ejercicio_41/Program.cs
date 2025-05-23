using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio:C}");
            Console.WriteLine($"Cantidad: {Cantidad}");
        }
    }

    class Papel : Producto
    {
        public string Tipo { get; set; } 

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Tipo de Papel: {Tipo}");
        }
    }

    class Utensilio : Producto
    {
        public string Material { get; set; } 

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Material: {Material}");
        }
    }

    class Program
    {
        static void Main()
        {
            
            Producto[] productos = new Producto[5];

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"\nIntroduce los datos del producto {i + 1}:");
                Console.WriteLine("¿Es un papel o un utensilio? (p/u):");
                string tipoProducto = Console.ReadLine().ToLower();

                if (tipoProducto == "p")
                {
                   
                    Papel papel = new Papel();

                    Console.Write("Nombre: ");
                    papel.Nombre = Console.ReadLine();

                    Console.Write("Precio: ");
                    papel.Precio = double.Parse(Console.ReadLine());

                    Console.Write("Cantidad: ");
                    papel.Cantidad = int.Parse(Console.ReadLine());

                    Console.Write("Tipo de Papel: ");
                    papel.Tipo = Console.ReadLine();

                    productos[i] = papel; 
                }
                else if (tipoProducto == "u")
                {
                   
                    Utensilio utensilio = new Utensilio();

                    Console.Write("Nombre: ");
                    utensilio.Nombre = Console.ReadLine();

                    Console.Write("Precio: ");
                    utensilio.Precio = double.Parse(Console.ReadLine());

                    Console.Write("Cantidad: ");
                    utensilio.Cantidad = int.Parse(Console.ReadLine());

                    Console.Write("Material: ");
                    utensilio.Material = Console.ReadLine();

                    productos[i] = utensilio; 
                }
                else
                {
                    Console.WriteLine("Tipo de producto no válido. Intente de nuevo.");
                    i--; 
                }
            }

            
            Console.WriteLine("\n--- Detalles de los Productos ---");
            foreach (var producto in productos)
            {
                producto.MostrarDetalles();
                Console.WriteLine();
            }
        }
    }
}
