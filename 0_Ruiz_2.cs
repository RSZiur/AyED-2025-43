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
            string nombre,edad;
            Console.WriteLine("¿Cual es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Cual es tu edad?");
            edad = Console.ReadLine();
            Console.WriteLine("Hola "+ nombre +" , tu edad es " + edad);
            Console.ReadKey();

        }
    }
}
