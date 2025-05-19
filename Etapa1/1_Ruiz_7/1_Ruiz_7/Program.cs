using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(palabra);
            }


            Console.ReadKey();
        }
    }
}
