using System;


namespace _2_RuizyTicona_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int Ax = 4;
            int[] vec = new int[Ax];
        
            int[,] Matriz = new int[Ax, Ax];
            for (int i = 0; i < Ax; i++)
            {
                for (int j = 0; j < Ax; j++)
                {
                    int num = rand.Next(1, 25);
                    Matriz[i, j] = num;
                }
            }

            Console.WriteLine("Matriz:");
            for (int i = 0; i < Ax; i++)
            {
                for (int j = 0; j < Ax; j++)
                {
                    Console.Write(Matriz[i, j] + "\t"); 
                }
                Console.WriteLine(); 
            }

            Console.WriteLine("la diagonal es:");
            for (int i = 0; i < Ax ; i++)
            {
                vec[i] = Matriz[i, i];
                Console.WriteLine(vec[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
