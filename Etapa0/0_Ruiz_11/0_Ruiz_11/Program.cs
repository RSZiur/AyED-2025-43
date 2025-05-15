using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ruiz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el ancho: ");
            double ancho = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double P = (2 * altura) + (2 * ancho);
            double A = (altura * ancho);
            double D = Math.Sqrt(Math.Pow(ancho, 2)) + Math.Sqrt(Math.Pow(altura, 2));
            Console.Write("su perimetro es de " + P + " , su area es de " + A + " y la diagonal es de " + D);
            Console.ReadKey();
        }
    }
}
