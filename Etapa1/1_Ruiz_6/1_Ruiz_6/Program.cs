using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura en grados celsius");
            int Temperatura = Convert.ToInt32(Console.ReadLine());
            if (Temperatura <= 0)
            {
                Console.WriteLine("Se congela");
            }
            else if (Temperatura >= 100)
            {
                Console.WriteLine("Hierve");
            }
            else
            {
                Console.WriteLine("Esta en estado liquido");
            }

            Console.ReadKey();
        }
    }
}
