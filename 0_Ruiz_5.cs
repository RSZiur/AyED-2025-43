using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicacion;
            Console.WriteLine("Escribe el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            multiplicacion = num1 * num2;
            Console.WriteLine("El resultado es: " + multiplicacion);
            Console.ReadKey();

        }
    }
}
