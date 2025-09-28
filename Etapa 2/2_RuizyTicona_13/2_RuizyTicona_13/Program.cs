// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese la cantidad de estudiantes: ");
int n = int.Parse(Console.ReadLine());

// Matriz Nx3 (Nombre, Edad, Calificación)
string[,] estudiantes = new string[n, 3];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nEstudiante {i + 1}:");

    Console.Write("Nombre: ");
    estudiantes[i, 0] = Console.ReadLine();

    Console.Write("Edad: ");
    estudiantes[i, 1] = Console.ReadLine();

    Console.Write("Calificación: ");
    estudiantes[i, 2] = Console.ReadLine();
}

Console.WriteLine("\n--- Lista de Estudiantes ---");
Console.WriteLine("Nombre\tEdad\tCalificación");

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{estudiantes[i, 0]}\t{estudiantes[i, 1]}\t{estudiantes[i, 2]}");
}

