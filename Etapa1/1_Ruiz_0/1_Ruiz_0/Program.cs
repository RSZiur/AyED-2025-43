using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
                Console.WriteLine("Usted es mayor de edad");
            else
                Console.WriteLine("Usted es menor de edad");
            Console.ReadKey();

        }
    }
}
