using System;

namespace _2_Ruiz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de participantes: ");
            int numParticipantes = int.Parse(Console.ReadLine());

            int[] puntajes = new int[numParticipantes];
            for (int i = 0; i < numParticipantes; i++)
            {
                    Console.Write("Ingrese el puntaje del participante "+(i + 1)+" : ");
              puntajes[i] = int.Parse(Console.ReadLine());
            }
            int aux = 0;
            for (int i = 0; i < numParticipantes ; i++)
            {
                for (int j = i ; j < numParticipantes; j++)
                {
                    if (puntajes[i] < puntajes[j])
                    {
                        aux = puntajes[i];
                        puntajes[i] = puntajes[j];
                        puntajes[j] = aux;
                    }
                }
            }


            Console.WriteLine("\nLista de puntajes ordenados:");
            for (int i = 0; i < numParticipantes; i++)
            {
                Console.WriteLine(puntajes[i]);
            }
            Console.ReadKey();
        }
    }
}
    