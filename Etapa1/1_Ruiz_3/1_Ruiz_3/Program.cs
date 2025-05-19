using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0)
            {
                Console.WriteLine("El numero es 0");
            }
            else if (num1 % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();
        }
    }
}
