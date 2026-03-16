//Bloque de variables globales
int opcion = -1;

//----------------------------

do
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Elija una opcion (1-5): ");
    Console.WriteLine();
    Console.WriteLine("1. Evaluar nuevo contenido");
    Console.WriteLine();
    Console.WriteLine("2. Mostrar reglas del sistema");
    Console.WriteLine();
    Console.WriteLine("3. Mostrar estadísticas de la sesión");
    Console.WriteLine();
    Console.WriteLine("4. Reiniciar estdísticas de la sesión");
    Console.WriteLine();
    Console.WriteLine("5. Salir");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Opción elegida: ");
    opcion=int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Presione ENTER para continuar ");
    Console.ReadLine();
    Console.Clear();

    switch (opcion)
    {
        case 1:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---Evaluar nuevo contenido---");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar ");
            Console.ReadLine();
            Console.Clear();
            break;

        case 2:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---Mostrar reglas del sistema---");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar ");
            Console.ReadLine();
            Console.Clear();
            break;

        case 3:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---Mostrar estdísticas de la sesión---");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar ");
            Console.ReadLine();
            Console.Clear();
            break;

        case 4:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---Estadísticas reiniciadas---");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar ");
            Console.ReadLine();
            Console.Clear();
            break;

        case 5:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---Saliendo del sistema---");
            Console.WriteLine();
            break;

        default:
            Console.WriteLine("Opción inválida. Por favor elija una opción (1-5)");
            Console.WriteLine();
            break;
    }
}while (opcion != 5);