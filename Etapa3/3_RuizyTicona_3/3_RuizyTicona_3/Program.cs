class Program
{
    const int MAX_ENCARGOS = 25;
    static string[,] encargos = new string[MAX_ENCARGOS, 5];
    static int cont = 0;

    static void Nuevoencargo()
    {
        if (cont == MAX_ENCARGOS)
        {
            Console.WriteLine("No se puede registrar un nuevo encargo, no hay espacio");
            return;
        }

        string entrada;
        bool datosValidos = false;
        double distancia = 0;


        do
        {
            Console.WriteLine("Ingrese la distancia del recorrido (km): ");
            entrada = Console.ReadLine();
            distancia = Convert.ToDouble(entrada);

            if (distancia > 0)
            {
                datosValidos = true;
            }
            else
            {
                Console.WriteLine("La distancia no puede ser negativa. Es ilegal circular en reversa.");
            }
        } while (!datosValidos);

        encargos[cont, 1] = entrada;

        datosValidos = false;
        do
        {
            Console.WriteLine("Ingrese sede (1=BSAS, 2=BB, 3=MDQ): ");
            entrada = Console.ReadLine();
            if (entrada == "1" || entrada == "2" || entrada == "3")
            {
                datosValidos = true;
            }
            else
            {
                Console.WriteLine("Sede inválida.");
            }
        } while (!datosValidos);

        encargos[cont, 2] = entrada;

        Console.WriteLine("Ingrese la ganancia esperada (en pesos): ");
        encargos[cont, 3] = Console.ReadLine();


        encargos[cont, 0] = "";
        encargos[cont, 4] = "0";
        cont++;

        Console.WriteLine("Encargo creado.");
        Console.ReadKey();
    }

    static void MostrarEncargos()
    {
        if (cont == 0)
        {
            Console.WriteLine("No hay encargos registrados.");
        }
        else
        {
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine("Encargo #" + (i + 1));
                string camion = encargos[i, 0];
                if (camion == "")
                {
                    camion = "(no asignado)";
                }
                Console.WriteLine("  Camión: " + camion);
                Console.WriteLine("  Distancia: " + encargos[i, 1] + "km");

                string sede = "Desconocida";
                if (encargos[i, 2] == "1") { sede = "BSAS"; }
                if (encargos[i, 2] == "2") { sede = "BB"; }
                if (encargos[i, 2] == "3") { sede = "MDQ"; }

                Console.WriteLine("  Sede: " + sede);
                Console.WriteLine("  Ganancia: " + encargos[i, 3]);

                if (encargos[i, 4] == "1")
                {
                    Console.WriteLine("  Asignado: Sí");
                }
                else
                {
                    Console.WriteLine("  Asignado: No");
                }
            }
        }
        Console.ReadKey();
    }

    static void AsignarCamion()
    {
        int disponibles = 0;
        for (int i = 0; i < cont; i++)
        {
            if (encargos[i, 4] == "0")
            {
                disponibles++;
                Console.WriteLine((i + 1) + ". Distancia: " + encargos[i, 1] + "km - Ganancia: " + encargos[i, 3]);
            }
        }

        if (disponibles == 0)
        {
            Console.WriteLine("No hay encargos sin asignar.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Ingrese el número del encargo al que desea asignar un camión: ");
        int seleccion = Convert.ToInt32(Console.ReadLine()) - 1;

        if (seleccion < 0 || seleccion >= cont)
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        if (encargos[seleccion, 4] == "1")
        {
            Console.WriteLine("Ese encargo ya tiene un camión asignado.");
        }
        else
        {
            Console.WriteLine("Ingrese código del camión: ");
            string codigo = Console.ReadLine().ToUpper();
            encargos[seleccion, 0] = codigo;
            encargos[seleccion, 4] = "1";
            Console.WriteLine("Camión asignado correctamente.");
        }

        Console.ReadKey();
    }

    static void MostrarAsignados()
    {
        int encontrados = 0;
        for (int i = 0; i < cont; i++)
        {
            if (encargos[i, 4] == "1")
            {
                encontrados = 1;
                Console.WriteLine("Encargo #" + (i + 1) + " - Camión: " + encargos[i, 0] + " - Distancia: " + encargos[i, 1] + "km");
            }
        }

        if (encontrados == 0)
        {
            Console.WriteLine("No hay encargos asignados.");
        }
        Console.ReadKey();
    }

    static void PromedioGananciaPorSede()
    {
        double total1 = 0;
        double total2 = 0;
        double total3 = 0;
        int cant1 = 0;
        int cant2 = 0;
        int cant3 = 0;

        for (int i = 0; i < cont; i++)
        {
            double ganancia = Convert.ToDouble(encargos[i, 3]);
            if (encargos[i, 2] == "1")
            {
                total1 = total1 + ganancia;
                cant1++;
            }
            if (encargos[i, 2] == "2")
            {
                total2 = total2 + ganancia;
                cant2++;
            }
            if (encargos[i, 2] == "3")
            {
                total3 = total3 + ganancia;
                cant3++;
            }
        }

        if (cant1 == 0)
        {
            Console.WriteLine("BSAS: No hay datos");
        }
        else
        {
            Console.WriteLine("BSAS: " + (total1 / cant1));
        }

        if (cant2 == 0)
        {
            Console.WriteLine("BB: No hay datos");
        }
        else
        {
            Console.WriteLine("BB: " + (total2 / cant2));
        }

        if (cant3 == 0)
        {
            Console.WriteLine("MDQ: No hay datos");
        }
        else
        {
            Console.WriteLine("MDQ: " + (total3 / cant3));
        }

        Console.ReadKey();
    }

    static void MostrarMayorDistancia()
    {
        if (cont == 0)
        {
            Console.WriteLine("No hay encargos.");
            Console.ReadKey();
            return;
        }

        double mayor = Convert.ToDouble(encargos[0, 1]);
        for (int i = 1; i < cont; i++)
        {
            double dist = Convert.ToDouble(encargos[i, 1]);
            if (dist > mayor)
            {
                mayor = dist;
            }
        }

        Console.WriteLine("Mayor distancia: " + mayor + "km");

        for (int i = 0; i < cont; i++)
        {
            if (Convert.ToDouble(encargos[i, 1]) == mayor)
            {
                Console.WriteLine("Encargo #" + (i + 1) + " - Distancia: " + encargos[i, 1] + "km");
            }
        }

        Console.ReadKey();
    }

    static void FiltrarPorCamion()
    {
        Console.WriteLine("Ingrese código del camión a buscar: ");
        string codigo = Console.ReadLine().ToUpper();
        int encontrados = 0;

        for (int i = 0; i < cont; i++)
        {
            if (encargos[i, 0] == codigo)
            {
                encontrados = 1;
                Console.WriteLine("Encargo #" + (i + 1) + " - Distancia: " + encargos[i, 1] + "km - Ganancia: " + encargos[i, 3]);
            }
        }

        if (encontrados == 0)
        {
            Console.WriteLine("No se encontraron encargos con ese camión.");
        }

        Console.ReadKey();
    }

    static void Main()
    {
        bool salir = false;

        do
        {
            Console.Clear();
            Console.WriteLine("--------- MENÚ ---------");
            Console.WriteLine("1. Crear nuevo encargo");
            Console.WriteLine("2. Mostrar todos los encargos");
            Console.WriteLine("3. Asignar camión a encargo");
            Console.WriteLine("4. Mostrar encargos asignados");
            Console.WriteLine("5. Promedio de ganancia por sede");
            Console.WriteLine("6. Mostrar encargo con mayor distancia");
            Console.WriteLine("7. Filtrar por código de camión");
            Console.WriteLine("8. Salir");
            Console.Write("Opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Nuevoencargo();
                    break;
                case 2:
                    MostrarEncargos();
                    break;
                case 3:
                    AsignarCamion();
                    break;
                case 4:
                    MostrarAsignados();
                    break;
                case 5:
                    PromedioGananciaPorSede();
                    break;
                case 6:
                    MostrarMayorDistancia();
                    break;
                case 7:
                    FiltrarPorCamion();
                    break;
                case 8:
                    salir = true;
                    break;
            }

        } while (!salir);
    }
}
}