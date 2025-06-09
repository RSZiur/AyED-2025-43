using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Ruiz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            Random rand = new Random();

            while (sigueVivo && dia <= 7)
            {
                Console.WriteLine($"\nDía {dia} 🌴 ¿Qué querés hacer?");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego");

                Console.Write("Elija una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        hambre += 20;
                        energia -= 15;
                        if (rand.Next(1, 101) <= 30)
                        {
                            salud -= 15;
                            Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                        }
                        dia++;
                        break;

                    case "2":
                        energia += 30;
                        hambre -= 10;
                        dia++;
                        break;

                    case "3":
                        energia -= 20;
                        hambre -= 15;
                        if (rand.Next(1, 101) <= 50)
                        {
                            salud += 10;
                            Console.WriteLine("¡Encontraste una planta curativa! Salud +10.");
                        }
                        dia++;
                        break;

                    case "4":
                        Console.WriteLine($"\nEstado del personaje:");
                        Console.WriteLine($"Salud: {salud}");
                        Console.WriteLine($"Hambre: {hambre}");
                        Console.WriteLine($"Energía: {energia}");
                        Console.WriteLine($"Día: {dia}");
                        continue;

                    case "5":
                        Console.WriteLine("Saliste del juego.");
                        sigueVivo = false;
                        continue;

                    default:
                        Console.WriteLine("Opción inválida.");
                        continue;
                }

                // Verificación de condiciones de muerte
                if (salud <= 0 || hambre <= 0 || energia <= 0)
                {
                    Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over ☠");
                    sigueVivo = false;
                }
            }

            if (sigueVivo)
            {
                Console.WriteLine("\n¡Felicitaciones! Sobreviviste una semana en la isla.");
            }
        }
    }
}