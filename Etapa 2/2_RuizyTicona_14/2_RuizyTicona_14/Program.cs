// See https://aka.ms/new-console-template for more information
using System;


namespace Prueba14
{
    class Program
    {
        static void Main(string[] args)
        {  
            const int MAX_POCHIMONS = 75; 
            string[,] pochidex = new string[MAX_POCHIMONS, 5]; 
            int contadorPochimons = 0; 
            Random rand = new Random(); 
            int opcion = 0; 

            //Inicio

            do
            {

                //Pantalla de Menu
                Console.Clear(); 
                Console.WriteLine("\n--------------------------------------------------");
                Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Pochimones Encontrados: {contadorPochimons}/{MAX_POCHIMONS}\n");
                Console.WriteLine("1. Registrar Pochimon");
                Console.WriteLine("2. Asignar Investigador a Pochimon");
                Console.WriteLine("3. Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostrar Información de Pochimons");
                Console.WriteLine("6. Buscar Pochimons por Tipo");
                Console.WriteLine("7. Mostrar Pochimons por Investigador");
                Console.WriteLine("8. Mostrar Pochimons Picados");
                Console.WriteLine("9. Salir");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("\nIngrese la opción deseada: ");
                opcion = int.Parse(Console.ReadLine());

                Console.Clear(); 

                switch (opcion)
                {
                    case 1:
                        //Registro de pochimons
                        if (contadorPochimons >= MAX_POCHIMONS)
                        {
                            Console.WriteLine("Límite alcanzado.No hay mas espacio en la pochidex!");
                        }
                        else
                        {// Solicitud de nombre, tipo y nivel del Pochimon
                            Console.Write("Ingrese el nombre de su pochimon:");
                            pochidex[contadorPochimons, 0] = Console.ReadLine();

                            Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
                            pochidex[contadorPochimons, 1] = Console.ReadLine().ToUpper();

                            Console.Write("Ingrese el nivel del Pochimon: ");
                            pochidex[contadorPochimons, 2] = Console.ReadLine(); 

                            pochidex[contadorPochimons, 3] = "0"; 
                            pochidex[contadorPochimons, 4] = "0"; 

                            contadorPochimons++;
                        }


                        break;
                    case 2:

                        //Asignar investigador a un pochimon
                        Console.WriteLine("Pochimons no investigados:");
                        

                        for (int i = 0; i < contadorPochimons; i++)
                        {   
                            if (pochidex[i, 3] == "0")
                                
                                Console.WriteLine($"{i}. {pochidex[i, 0]} - {pochidex[i, 1]} - Nivel: {pochidex[i, 2]}");
                        }
                        // Solicitamos al usuario el ID del pochimon (número de fila) al que quiere asignar investigador
                        Console.Write("\nSeleccione ID(numero de fila): ");
                        int id2 = int.Parse(Console.ReadLine());

                        // Pedimos el código del investigador y lo guardamos en la columna 4
                        Console.Write("Ingrese el código del Investigador: ");
                        pochidex[id2, 4] = Console.ReadLine();
                        // Cambiamos el estado del pochimon a 1 (en investigación)
                        pochidex[id2, 3] = "1";



                        break;
                    case 3:
                        //Actualizar el nivel del pochimon
                        Console.WriteLine("Pochimons registrados:");
                       

                        for (int i = 0; i < contadorPochimons; i++)
                        {
                            
                            Console.WriteLine($"{i}. {pochidex[i, 0]}  - Nivel: {pochidex[i, 2]}");
                        }
                        // Solicitamos al usuario el ID del pochimon (número de fila)
                        // al que quiere aumentar el nivel
                        Console.Write("\nIngrese el número de ID(fila) del Pochimon a actualizar: ");
                        int id3 = int.Parse(Console.ReadLine());

                        // Actualizacion de nivel
                        int actual = int.Parse(pochidex[id3, 2]);
                        pochidex[id3, 2] = (actual + rand.Next(1, 4)).ToString();
                        break;


                    case 4:
                        // Marcar como investigado los pochimons que están en estado 1
                        Console.WriteLine("Pochimons en investigación:");
                        Console.WriteLine("| ID | Nombre | Tipo | Nivel | Estado | Investigador |");
                        for (int i = 0; i < contadorPochimons; i++)
                        {
                            if (pochidex[i, 3] == "1") 
                                Console.WriteLine($" |{i} | {pochidex[i, 0]} | {pochidex[i, 1]}  | {pochidex[i, 2]} | {pochidex[i, 3]} | {pochidex[i, 4]} |");
                        }
                        Console.Write("Ingrese el número de ID (fila) del Pochimon a marcar como investigado: ");
                        int id4 = int.Parse(Console.ReadLine());
                        pochidex[id4, 3] = "2";
                        break;

                    case 5:
                        // Mostrar información completa de todos los pochimons registrados
                        Console.WriteLine("| ID | Nombre | Tipo | Nivel | Estado | Investigador |");
                        for (int i = 0; i < contadorPochimons; i++)
                        {
                            Console.WriteLine($"| {i} | {pochidex[i, 0]} | {pochidex[i, 1]} | {pochidex[i, 2]} | {pochidex[i, 3]} | {pochidex[i, 4]} |");
                        }
                        break;

                    case 6:
                        // Buscar por tipo de pochimon
                        Console.Write("Ingrese el tipo de Pochimon a buscar (A/F/P): ");
                        string tipo = Console.ReadLine().ToUpper();
                        for (int i = 0; i < contadorPochimons; i++)
                        {
                            if (pochidex[i, 1] == tipo)
                                Console.WriteLine($"{i}. {pochidex[i, 0]} - Nivel: {pochidex[i, 2]}");
                        }
                        break;

                    case 7:
                        // Mostrar por investigador
                        Console.Write("Ingrese el código del Investigador: ");
                        string inv = Console.ReadLine();
                        for (int i = 0; i < contadorPochimons; i++)
                        {
                            if (pochidex[i, 4] == inv)
                                Console.WriteLine($"{i}. {pochidex[i, 0]} - Tipo: {pochidex[i, 1]} - Nivel: {pochidex[i, 2]}");
                        }
                        break;
                    case 8:
                        // Mostrar pochimons con nivel mayor a 30
                        Console.WriteLine("Pochimons Picados:");
                        for (int i = 0; i < contadorPochimons; i++)
                        {
                            if (int.Parse(pochidex[i, 2]) > 30) 
                                Console.WriteLine($"{i}. {pochidex[i, 0]} - Tipo: {pochidex[i, 1]} - Nivel: {pochidex[i, 2]}");
                            else
                                Console.WriteLine("No se encontraron Pochimons Picados");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Fin del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Elegí una opción del 1 al 4.\n");
                        break;
                }
                Console.WriteLine("\nPresione una tecla para continuar...");
               
                Console.ReadKey();

            } while (opcion != 9);




        }


    }
}