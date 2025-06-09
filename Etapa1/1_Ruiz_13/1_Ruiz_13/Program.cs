using System;

public class 1_Ruiz_13
{
    public static void Main(string[] args)
    {
        string res;
        do
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Calcular si usted es mayor o menor");
            Console.WriteLine("3. Calcular si el año es bisiesto");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            res = Console.ReadLine();

            switch (res)
            {
                case "1":
                    Console.WriteLine("¡Hola!");
                    break;
                case "2":
                    Console.Write("Ingrese su edad: ");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    if (edad >= 18)
                    {
                        Console.WriteLine("Usted es mayor de edad");
                    }
                    else
                    {
                        Console.WriteLine("Usted es menor de edad");
                    }
                    break;
                case "3":
                    Console.Write("Ingrese el año: ");
                    int año = Convert.ToInt32(Console.ReadLine());
                    int resto = año % 4;
                    if (resto == 0)
                    {
                        Console.WriteLine("El año es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El año no es bisiesto");
                    }
                    break;
                case "4":
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción del 1 al 4.");
                    break;
            }
        } while (res != "4");
    }
}