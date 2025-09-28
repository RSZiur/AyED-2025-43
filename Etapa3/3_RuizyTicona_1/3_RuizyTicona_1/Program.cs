using System;

class Program
{
    // función que recibe 2 enteros y devuelve la suma
    static int Suma(int valor1, int valor2)
    {
        int resultado = valor1 + valor2;
        return resultado;
    }

    static void Main()
    {
        Console.Write("Ingrese valor 1: ");
        int v1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese valor 2: ");
        int v2 = int.Parse(Console.ReadLine());

        int r = Suma(v1, v2);

        Console.WriteLine("El resultado es: " + r);
    }
}