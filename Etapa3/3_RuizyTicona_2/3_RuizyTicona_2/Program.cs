using System;

class Program
{
    // Funciones para cada operación
    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static int Restar(int a, int b)
    {
        return a - b;
    }

    static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    static double Dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("No se puede dividir entre 0.");
            return 0;
        }
        return (double)a / b;
    }

    // Función Calculadora con switch
    static void Calculadora()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- CALCULADORA ---");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= 4)
            {
                Console.Write("Ingrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + Sumar(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Resultado: " + Restar(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Resultado: " + Multiplicar(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Resultado: " + Dividir(num1, num2));
                        break;
                }
            }
            else if (opcion != 5)
            {
                Console.WriteLine("Opción inválida, intenta nuevamente.");
            }

        } while (opcion != 5);

        Console.WriteLine("¡Gracias por usar la calculadora!");
    }

    static void Main(string[] args)
    {
        Calculadora();
    }
}