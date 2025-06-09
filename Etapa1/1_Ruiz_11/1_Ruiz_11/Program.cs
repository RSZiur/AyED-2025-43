using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " par");
                }
                else
                {
                    Console.WriteLine(i+ " impar");
                }
            }
            Console.ReadKey();
        }
    }
}
