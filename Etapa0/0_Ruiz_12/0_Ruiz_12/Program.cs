using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ruiz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese tres letras: ");
            string Letras = Console.ReadLine();

            string alreves = $"{ Letras[2] }{ Letras[1]}{ Letras[0]}";

            Console.Write("las letras que ingreso alreves serian " + alreves);
            Console.ReadKey();
        }
    }
}
