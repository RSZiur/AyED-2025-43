using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_RuizyTicona_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila, colum;
            Console.WriteLine("Decime la cantidad de filas");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decime la cantidad de columnas");
            colum = Convert.ToInt32(Console.ReadLine());
            int[,] Matriz = new int[fila, colum];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    Matriz[i, j] = 0;
                    Console.WriteLine(Matriz[i, j]);
                }
            }
            Console.ReadKey();
        }

    }
}
