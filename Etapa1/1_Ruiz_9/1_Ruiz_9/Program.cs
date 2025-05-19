using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero entero");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = N ; i >= 0; i--)
            {
                Console.WriteLine("la cuenta regresiva es " +i);
            }
            Console.ReadKey();
        }
    }
}
