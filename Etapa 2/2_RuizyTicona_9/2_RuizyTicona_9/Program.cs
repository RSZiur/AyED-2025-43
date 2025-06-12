using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_RuizyTicona_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int fila = rand.Next(1, 10);
            int columna = rand.Next(1, 10);
            int[,] Matriz = new int[fila, columna];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Matriz[i, j] = rand.Next(1, 101);
                    Console.WriteLine(Matriz[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
