using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ruiz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rad;
            Random rand = new Random();

            Console.WriteLine("Ingrese el tamaño del vector");
            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = rand.Next(1, 101);
            }

            do
            {
                Console.WriteLine("-----MENU------");
                Console.WriteLine("1. Imprimir");
                Console.WriteLine("2. Ingresar un numero");
                Console.WriteLine("3. Ordenar el vector");
                Console.WriteLine("4. Salir");

               rad= int.Parse(Console.ReadLine());

                switch (rad)
                {
                    case 1:
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el número a buscar:");
                        int num = int.Parse(Console.ReadLine());
                        bool Ax=false;
                        for (int i = 0; i < n; i++)
                        {
                            if (vector[i] == num)
                            {
                                Console.WriteLine("El número se encuentra en la posición: " + i);
                                Ax=true;
                            }
                        }
                        if (!Ax)
                        {
                            Console.WriteLine("El número no se encuentra en el vector.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("¿De qué manera querés ordenar? (ASC o DESC):");
                        string Ru=Console.ReadLine().ToUpper();

                        if (Ru=="ASC")
                        {
                            for (int i = 0; i < n - 1; i++)
                            {
                                for (int j = 0; j < n - i - 1; j++)
                                {
                                    if (vector[j] > vector[j + 1])
                                    {
                                        int temp = vector[j];
                                        vector[j] = vector[j + 1];
                                        vector[j + 1] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("Vector ordenado ascendentemente:");
                        }
                        else if (Ru== "DESC")
                        {
                            for (int i = 0; i < n - 1; i++)
                            {
                                for (int j = 0; j < n - i - 1; j++)
                                {
                                    if (vector[j] < vector[j + 1])
                                    {
                                        int temp = vector[j];
                                        vector[j] = vector[j + 1];
                                        vector[j + 1] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("Vector ordenado descendentemente:");
                        }
                        else
                        {
                            Console.WriteLine("Opción de orden no válida.");
                            break;
                        }

                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(vector[i] + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Adios :)");
                        break;

                    default:
                        Console.WriteLine("Opcion no valido");
                        break;
                }

            } while (rad!= 4);

            Console.ReadKey();
        }
    }
}
