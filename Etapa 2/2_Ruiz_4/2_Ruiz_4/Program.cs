using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ruiz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de productos: ");
            int Productos = int.Parse(Console.ReadLine());

            int[] precio = new int[Productos];
            for (int i = 0; i < Productos; i++)
            {
                Console.Write("Ingrese el precio del producto " + (i + 1) + " : ");
                precio[i] = int.Parse(Console.ReadLine());
            }
            int aux = 0;
            for (int i = 0; i < Productos; i++)
            {
                for (int j = i; j < Productos; j++)
                {
                    if (precio[i] < precio[j])
                    {
                        aux = precio[i];
                        precio[i] = precio[j];
                        precio[j] = aux;
                    }
                }
            }


            Console.WriteLine("\nLista de productos:");
            int mayor = precio[0];
            int menor = precio[precio.Length - 1];
            Console.WriteLine("El producto mas caro es :" + mayor);
            Console.WriteLine("El producto mas economico es :" + menor);
            for (int i = 0; i < Productos; i++)
            {
                Console.WriteLine(precio[i]);
            }
           
            Console.ReadKey();
        }
    }
}
    
