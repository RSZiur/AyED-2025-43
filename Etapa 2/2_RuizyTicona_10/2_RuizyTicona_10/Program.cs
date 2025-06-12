using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_RuizyTicona_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1, c1;
            f1 = 5;
            c1 = 5;
            int[,] matriz1 = new int[f1, c1];
            int[,] matriz2 = new int[f1, c1];
            int[,] matrizsum = new int[f1, c1];
            Random rand = new Random();
            for (int i = 0; i < f1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    matriz1[i, j] = rand.Next(1, 45);
                    matriz2[i, j] = rand.Next(1, 45);
                    matrizsum[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write(matrizsum[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
