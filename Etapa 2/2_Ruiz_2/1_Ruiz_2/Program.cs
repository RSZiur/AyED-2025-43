using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de TPs: ");
            int cantidadTPs = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de exámenes: ");
            int cantidadExamenes = int.Parse(Console.ReadLine());

            double[] notasTPs = new double[cantidadTPs];
            double[] notasExamenes = new double[cantidadExamenes];

            
            Console.WriteLine("\nIngrese las notas de los TPs:");
            for (int i = 0; i < cantidadTPs; i++)
            {
                Console.Write($"Nota del TP {i + 1}: ");
                notasTPs[i] = double.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("\nIngrese las notas de los exámenes:");
            for (int i = 0; i < cantidadExamenes; i++)
            {
                Console.Write($"Nota del examen {i + 1}: ");
                notasExamenes[i] = double.Parse(Console.ReadLine());
            }

            
            double sumaExamenes = 0;
            foreach (double nota in notasExamenes)
            {
                sumaExamenes += nota;
            }
            double promedioExamenes = cantidadExamenes > 0 ? sumaExamenes / cantidadExamenes : 0;

          
            int tpsAprobados = 0;
            foreach (double nota in notasTPs)
            {
                if (nota >= 6) tpsAprobados++;
            }
            double porcentajeAprobados = cantidadTPs > 0 ? (tpsAprobados * 100.0) / cantidadTPs : 0;

            
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Promedio de exámenes: "+promedioExamenes);
            Console.WriteLine($"Porcentaje de TPs aprobados: "+porcentajeAprobados + "% ");

            if (promedioExamenes >= 6 && porcentajeAprobados >= 75)
            {
                Console.WriteLine("¡Phineas y Ferb pueden aprobar la materia!");
            }
            else
            {
                Console.WriteLine("Phineas y Ferb NO pueden aprobar la materia.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
    

