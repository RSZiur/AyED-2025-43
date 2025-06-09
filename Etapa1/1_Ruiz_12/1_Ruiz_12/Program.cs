using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desea terminar el programa? ");
            string r = Convert.ToString(Console.ReadLine());
            string si = "SI";
            while (r != si)
            
            {

                
                Console.WriteLine("Desea terminar el programa? ");
                r = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
            }
        }
    }
}

