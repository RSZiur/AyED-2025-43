using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ruiz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de objetos: ");
            int objetos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad minima de objetos: ");
            int minimo = int.Parse(Console.ReadLine());

            int[] valor = new int[objetos];
            for (int i = 0; i < objetos; i++)
            {
                Console.Write("Ingrese el valor del objeto " + (i + 1) + " : ");
                valor[i] = int.Parse(Console.ReadLine());
            }
            int aux = 0;
            for (int i = 0; i < objetos; i++)
            {
                for (int j = i; j < objetos; j++)
                {
                    if (valor[i] < valor[j])
                    {
                        aux = valor[i];
                        valor[i] = valor[j];
                        valor[j] = aux;
                    }
                }
            }


            for (int i = 0; i < objetos; i++)
            {
                if (valor[i] > minimo)
                {
                    Console.WriteLine(valor[i]);
                }

            }

            Console.ReadKey();
        }
    }
}
