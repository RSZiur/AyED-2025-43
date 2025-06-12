using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_RuizyTicona_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de candidatos: ");
            int Candidatos = int.Parse(Console.ReadLine());

            int[] Puntaje = new int[Candidatos];
            for (int i = 0; i < Candidatos; i++)
            {
                Console.Write("Ingrese el puntaje del candidato:  " + (i + 1) + " : ");
                Puntaje[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Ingrese un numero entero: ");
            int numero = int.Parse(Console.ReadLine());
            int multiplo = 0;
            for (int i = 0; i < Candidatos; i++)
            {
                if (Puntaje[i] % numero == 0)
                {
                    multiplo++;
                    Console.WriteLine("Multiplos de " + numero + ":");
                    for ( i = 0; i < Candidatos; i++)
                    {
                        if (Puntaje[i] % numero == 0 )
                        {
                            Console.WriteLine(Puntaje[i]);
                            multiplo++;
                        }
                    }
                }
                Console.WriteLine(multiplo);
            }

            for (int i = 0; i < Candidatos; i++)
            {
                for (int j = i + 1; j < Candidatos; j++)
                {
                    if (Puntaje[i] > Puntaje[j])
                    {
                        int aux = Puntaje[i];
                        Puntaje[i] = Puntaje[j];
                        Puntaje[j] = aux;
                    }
                }
            }
           
            Console.WriteLine("Puntajes ordenados: ");
            for (int i = 0; i < Candidatos; i++) 
            {
                Console.WriteLine(Puntaje[i]);
            }
           
            Console.ReadKey();

        }
    }
}
   