using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_RuizyTicona_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] natural = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int[,] rotada = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rotada[j, 2 - i] = natural[i, j];
                }
            }
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(natural[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz rotada 90° en sentido horario:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(rotada[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
