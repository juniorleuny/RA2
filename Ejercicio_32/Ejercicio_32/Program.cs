using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] inventario = {
            { 10, 5, 8 },  // Televisores
            { 15, 20, 10 }, // Laptops
            { 5, 12, 7 }   // Teléfonos
        };

            
            int tiposDispositivos = inventario.GetLength(0);
            int almacenes = inventario.GetLength(1);

            
            for (int j = 0; j < almacenes; j++)
            {
                int total = 0;
                int maxCantidad = 0;
                int minCantidad = int.MaxValue;
                int tipoMax = -1;
                int tipoMin = -1;

                for (int i = 0; i < tiposDispositivos; i++)
                {
                    total += inventario[i, j];

                    
                    if (inventario[i, j] > maxCantidad)
                    {
                        maxCantidad = inventario[i, j];
                        tipoMax = i;
                    }

                    
                    if (inventario[i, j] < minCantidad)
                    {
                        minCantidad = inventario[i, j];
                        tipoMin = i;
                    }
                }

                
                Console.WriteLine($"Almacén {j + 1}:");
                Console.WriteLine($"Cantidad total de dispositivos: {total}");
                Console.WriteLine($"Dispositivo con mayor cantidad: {ObtenerNombreDispositivo(tipoMax)} ({maxCantidad})");
                Console.WriteLine($"Dispositivo con menor cantidad: {ObtenerNombreDispositivo(tipoMin)} ({minCantidad})");
                Console.WriteLine();
            }
        }

        
        static string ObtenerNombreDispositivo(int tipo)
        {
            switch (tipo)
            {
                case 0: return "Televisor";
                case 1: return "Laptop";
                case 2: return "Teléfono";
                default: return "Desconocido";
            }
        }
    }
    }

