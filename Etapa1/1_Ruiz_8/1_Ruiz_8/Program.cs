using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Que edad tiene?");
            int edad = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <= edad ; i++) 
            {
                Console.WriteLine("Los años que cumplio son "+i);
            }
            Console.ReadKey();
        }
    }
}
