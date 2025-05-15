using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ruiz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Dimensiones de una Esfera");

            Console.Write("Ingrese el radio de la esfera: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double superficie = 4 * Math.PI * Math.Pow(radio, 2);
            double volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3);

            Console.WriteLine("La superficie de la esfera es:" + superficie);
            Console.WriteLine("El volumen de la esfera es: " + volumen);
            Console.ReadKey();
        }
    }
}
