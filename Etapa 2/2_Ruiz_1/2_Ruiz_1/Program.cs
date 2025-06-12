using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ruiz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de vueltas: ");
            int numVueltas = int.Parse(Console.ReadLine());

            double[] tiemposVuelta = new double[numVueltas];
            for (int i = 0; i < numVueltas; i++)
            {
                Console.Write($"Ingrese el tiempo de la vuelta {i + 1} (en segundos): ");
                tiemposVuelta[i] = double.Parse(Console.ReadLine());
            }

            double tiempoTotal = CalcularTiempoTotal(tiemposVuelta);
            double promedioVuelta = CalcularPromedio(tiemposVuelta);
            int mejorVuelta = DeterminarMejorVuelta(tiemposVuelta);

            MostrarResultados(tiempoTotal, promedioVuelta, mejorVuelta, tiemposVuelta);
        }

        static double CalcularTiempoTotal(double[] tiempos)
        {
            double total = 0;
            foreach (double tiempo in tiempos)
            {
                total += tiempo;
            }
            return total;
        }

        static double CalcularPromedio(double[] tiempos)
        {
            return CalcularTiempoTotal(tiempos) / tiempos.Length;
        }

        static int DeterminarMejorVuelta(double[] tiempos)
        {
            int mejorVuelta = 0;
            double tiempoMinimo = tiempos[0];
            for (int i = 1; i < tiempos.Length; i++)
            {
                if (tiempos[i] < tiempoMinimo)
                {
                    tiempoMinimo = tiempos[i];
                    mejorVuelta = i;
                }
            }
            return mejorVuelta;
        }

        static void MostrarResultados(double tiempoTotal, double promedioVuelta, int mejorVuelta, double[] tiemposVuelta)
        {
            Console.WriteLine("\nResultados de la carrera:");
            Console.WriteLine($"Tiempo total: {tiempoTotal} segundos");
            Console.WriteLine($"Promedio por vuelta: {promedioVuelta} segundos");
            Console.WriteLine($"Mejor vuelta: Vuelta {mejorVuelta + 1} con {tiemposVuelta[mejorVuelta]} segundos");
            Console.WriteLine("\ntiempos de cada vuelta:");
            for (int i = 0; i < tiemposVuelta.Length; i++)
            {
                Console.WriteLine($"Vuelta {i + 1}: {tiemposVuelta[i]} segundos");
            }

            Console.ReadKey();
        }
    }
}