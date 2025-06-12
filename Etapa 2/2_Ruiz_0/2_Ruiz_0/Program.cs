using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ruiz_0
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingrese la cantidad de invitados: ");
            int cantidadInvitados = int.Parse(Console.ReadLine());

            int totalComida = 0;

            for (int i = 1; i <= cantidadInvitados; i++)
            {
                Console.Write($"Ingrese la cantidad de comida que consume el invitado #{i} (1-100): ");
                int comida = int.Parse(Console.ReadLine());

                while (comida < 1 || comida > 100)
                {
                    Console.Write("Cantidad inválida. Ingrese un valor entre 1 y 100: ");
                    comida = int.Parse(Console.ReadLine());
                }

                totalComida += comida;
            }

            double promedio = (double)totalComida / cantidadInvitados;
            Console.WriteLine($"\nPromedio de comida por invitado: {promedio}");

            Console.ReadKey();
        }
    }
}