using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ruiz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese los centigrados: ");
            double C = Convert.ToDouble(Console.ReadLine());
            double K = C + 273.15;
            double f = ((K - 273.15) * 1.8) + 32;
            Console.Write("Los grados en Kelvin son: " + K + " Los grados en Farenheit son: " + f);
            Console.ReadKey();
        }
    }
}
