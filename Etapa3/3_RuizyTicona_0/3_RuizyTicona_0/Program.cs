// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // función que recibe un nombre y devuelve un saludo
    static string Saludar(string nombre)
    {
        string mensaje = "Hola " + nombre;
        return mensaje;
    }

    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // uso la función
        string saludo = Saludar(nombre);

        Console.WriteLine(saludo);
    }
}