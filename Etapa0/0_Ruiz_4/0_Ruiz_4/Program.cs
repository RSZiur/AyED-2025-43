﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Ruiz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma;
            Console.WriteLine("Escribe el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine("El resultado es: " + suma);
            Console.ReadKey();
        }
    }
}
