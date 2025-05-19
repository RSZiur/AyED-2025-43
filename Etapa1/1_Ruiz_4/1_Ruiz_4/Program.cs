using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese sus ingresos mensuales");
            int ingresosm = Convert.ToInt32(Console.ReadLine());
            if (edad >= 19 && ingresosm <= 100000)
            {
                Console.WriteLine("Puede cobrar la beca");
            }
            else if (edad < 19 && ingresosm == 0)
            {
                Console.WriteLine("Puede cobrar la beca");
            }
            else if (edad == 19 && ingresosm <= 50000)
            {
                Console.WriteLine("Puede cobrar la beca");
            }
            else
            {
                Console.WriteLine("No puede cobrar la beca");
            }
            Console.ReadKey();
        }
    }
}
