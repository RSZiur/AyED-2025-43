class Program
{
    const int MAX_PERSONAJES = 20;
    static string[,] personajes = new string[MAX_PERSONAJES, 5];
    static int cont = 0;

    static void CrearPersonaje()
    {
        if (cont == MAX_PERSONAJES)
        {
            Console.WriteLine("No se puede agregar más personajes.");
            return;
        }

        Console.WriteLine("Ingrese el nombre del personaje:");
        string nombre = Console.ReadLine();

        for (int i = 0; i < cont; i++)
        {
            if (personajes[i, 0] == nombre)
            {
                Console.WriteLine("Ya existe un personaje con ese nombre.");
                return;
            }
        }

        Console.WriteLine("Ingrese la saga/facción del personaje:");
        string saga = Console.ReadLine();

        Console.WriteLine("Ingrese la fuerza (entero):");
        string fuerza = Console.ReadLine();

        Console.WriteLine("Ingrese la defensa (entero):");
        string defensa = Console.ReadLine();

        string esHeroe = "";
        bool valido = false;
        do
        {
            Console.WriteLine("¿Es héroe? (1 = Sí, 0 = No):");
            esHeroe = Console.ReadLine();
            if (esHeroe == "1" || esHeroe == "0")
            {
                valido = true;
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        } while (!valido);

        personajes[cont, 0] = nombre;
        personajes[cont, 1] = saga;
        personajes[cont, 2] = fuerza;
        personajes[cont, 3] = defensa;
        personajes[cont, 4] = esHeroe;
        cont++;

        Console.WriteLine("Personaje creado.");
        Console.ReadKey();
    }

    static void ConsultarPersonaje()
    {
        Console.WriteLine("Ingrese el nombre del personaje a consultar:");
        string buscado = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < cont; i++)
        {
            if (personajes[i, 0] == buscado)
            {
                Console.WriteLine("Nombre: " + personajes[i, 0]);
                Console.WriteLine("Saga/Facción: " + personajes[i, 1]);
                Console.WriteLine("Fuerza: " + personajes[i, 2]);
                Console.WriteLine("Defensa: " + personajes[i, 3]);
                if (personajes[i, 4] == "1")
                {
                    Console.WriteLine("Es Héroe: Sí");
                }
                else
                {
                    Console.WriteLine("Es Héroe: No");
                }
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Personaje no encontrado.");
        }
        Console.ReadKey();
    }

    static void ModificarPersonaje()
    {
        Console.WriteLine("Ingrese el nombre del personaje a modificar:");
        string buscado = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < cont; i++)
        {
            if (personajes[i, 0] == buscado)
            {
                Console.WriteLine("Ingrese nueva fuerza:");
                personajes[i, 2] = Console.ReadLine();
                Console.WriteLine("Ingrese nueva defensa:");
                personajes[i, 3] = Console.ReadLine();
                Console.WriteLine("Atributos actualizados.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Personaje no encontrado.");
        }
        Console.ReadKey();
    }

    static void EliminarPersonaje()
    {
        Console.WriteLine("Ingrese el nombre del personaje a eliminar:");
        string buscado = Console.ReadLine();
        bool eliminado = false;

        for (int i = 0; i < cont; i++)
        {
            if (personajes[i, 0] == buscado)
            {
                for (int j = i; j < cont - 1; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        personajes[j, k] = personajes[j + 1, k];
                    }
                }
                cont--;
                Console.WriteLine("Personaje eliminado.");
                eliminado = true;
                break;
            }
        }

        if (!eliminado)
        {
            Console.WriteLine("Personaje no encontrado.");
        }
        Console.ReadKey();
    }

    static void MostrarPersonajes()
    {
        if (cont == 0)
        {
            Console.WriteLine("No hay personajes registrados.");
        }
        else
        {

            for (int i = 0; i < cont - 1; i++)
            {
                for (int j = i + 1; j < cont; j++)
                {
                    if (personajes[i, 0].CompareTo(personajes[j, 0]) > 0)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            string temp = personajes[i, k];
                            personajes[i, k] = personajes[j, k];
                            personajes[j, k] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine("Nombre: " + personajes[i, 0]);
                Console.WriteLine("Saga/Facción: " + personajes[i, 1]);
                Console.WriteLine("Fuerza: " + personajes[i, 2]);
                Console.WriteLine("Defensa: " + personajes[i, 3]);
                if (personajes[i, 4] == "1")
                {
                    Console.WriteLine("Es Héroe: Sí");
                }
                else
                {
                    Console.WriteLine("Es Héroe: No");
                }
                Console.WriteLine("--------------------------");
            }
        }
        Console.ReadKey();
    }

    static void Main()
    {
        bool salir = false;
        do
        {
            Console.Clear();
            Console.WriteLine("------ Borderlands MVM ------");
            Console.WriteLine("1. Crear nuevo personaje");
            Console.WriteLine("2. Consultar personaje por nombre");
            Console.WriteLine("3. Modificar personaje");
            Console.WriteLine("4. Eliminar personaje");
            Console.WriteLine("5. Mostrar todos los personajes");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearPersonaje();
                    break;
                case 2:
                    ConsultarPersonaje();
                    break;
                case 3:
                    ModificarPersonaje();
                    break;
                case 4:
                    EliminarPersonaje();
                    break;
                case 5:
                    MostrarPersonajes();
                    break;
                case 6:
                    salir = true;
                    break;
            }

        } while (!salir);
    }
}
}