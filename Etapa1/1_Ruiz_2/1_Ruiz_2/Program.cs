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
            Console.WriteLine("Ingrese su numero");
            double N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el divisor");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("ERROR");

            }

            else
            {
                double division = N / divisor;
                Console.WriteLine("su division es " + N + "/" + divisor + "=" + division);
            }
            Console.ReadKey();
        }
    }
}
