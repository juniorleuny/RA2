using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    class BoletoTransporte
    {
        public string Destino { get; set; }
        public string TipoTransporte { get; set; }
        public double Costo { get; set; }
        public double Tiempo { get; set; } // en minutos
        public double Distancia { get; set; } // en kilómetros

        public void CalcularCosto()
        {
            // Cálculo del costo basado en el tipo de transporte
            switch (TipoTransporte.ToLower())
            {
                case "taxi":
                    Costo = Distancia * 1.5; // Costo por kilómetro
                    break;
                case "metro":
                    Costo = 2.0; // Costo fijo
                    break;
                case "teleférico":
                    Costo = 3.0; // Costo fijo
                    break;
                case "bus urbano":
                    Costo = 1.0; // Costo fijo
                    break;
                case "bus interurbano":
                    Costo = Distancia * 0.5; // Costo por kilómetro
                    break;
                default:
                    Console.WriteLine("Tipo de transporte no válido.");
                    break;
            }
        }

        public void CalcularTiempo()
        {
            
            switch (TipoTransporte.ToLower())
            {
                case "taxi":
                    Tiempo = Distancia * 2; // 2 minutos por kilómetro
                    break;
                case "metro":
                    Tiempo = 30; // Tiempo fijo
                    break;
                case "teleférico":
                    Tiempo = 15; // Tiempo fijo
                    break;
                case "bus urbano":
                    Tiempo = Distancia * 1.5; // 1.5 minutos por kilómetro
                    break;
                case "bus interurbano":
                    Tiempo = Distancia * 1.2; // 1.2 minutos por kilómetro
                    break;
                default:
                    Console.WriteLine("Tipo de transporte no válido.");
                    break;
            }
        }

        public void MostrarBoleto()
        {
            Console.WriteLine("\n--- Boleto de Transporte ---");
            Console.WriteLine($"Destino: {Destino}");
            Console.WriteLine($"Tipo de Transporte: {TipoTransporte}");
            Console.WriteLine($"Costo: {Costo:C}");
            Console.WriteLine($"Tiempo estimado: {Tiempo} minutos");
            Console.WriteLine($"Distancia: {Distancia} km");
        }
    }

    class Program
    {
        static void Main()
        {
            BoletoTransporte boleto = new BoletoTransporte();

           
            Console.WriteLine("Introduce el destino:");
            boleto.Destino = Console.ReadLine();

            Console.WriteLine("Introduce el tipo de transporte (Taxi, Metro, Teleférico, Bus Urbano, Bus Interurbano):");
            boleto.TipoTransporte = Console.ReadLine();

            if (boleto.TipoTransporte.ToLower() == "taxi" || boleto.TipoTransporte.ToLower() == "bus interurbano")
            {
                Console.WriteLine("Introduce la distancia (en km):");
                boleto.Distancia = double.Parse(Console.ReadLine());
            }

            
            boleto.CalcularCosto();
            boleto.CalcularTiempo();

            
            boleto.MostrarBoleto();
        }
    }
}
