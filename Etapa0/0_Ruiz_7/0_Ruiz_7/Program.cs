using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ruiz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int division;
            Console.WriteLine("Escribe el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            division = num1 / num2;
            Console.WriteLine("El resultado es: " + division);
            Console.ReadKey();
        }
    }
}
