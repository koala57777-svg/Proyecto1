//Bloque de variables globales
int opcion = -1;

int TipoContenido = 0;
int Duracion = 0;
int Clasificacion = 0;
int HoraProgramada = 0;
int NivelProduccion = 0;
//----------------------------

void Validacion()
{
    //Tipo de contenido
    Console.WriteLine("Seleccione el tipo de contenido: ");
    Console.WriteLine();
    Console.WriteLine("1. Película");
    Console.WriteLine("2. Serie");
    Console.WriteLine("3. Documental");
    Console.WriteLine("4. Evento en vivo");
    Console.WriteLine();
    Console.Write("Selección: ");
    TipoContenido=int.Parse(Console.ReadLine());

    while (TipoContenido<1 || TipoContenido>4)
    {
        Console.WriteLine();
        Console.WriteLine("Opción inválida");
        Console.WriteLine();
        Console.Write("Seleccione el tipo de contenido: ");
        TipoContenido=int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Presione ENTER para continuar ");
    Console.ReadLine();
    Console.Clear();


    //Duración
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Ingrese la duración (minutos): ");
    Duracion=int.Parse(Console.ReadLine());
    while (Duracion <=0)
    {
        Console.WriteLine();
        Console.WriteLine("Duración inválida");
        Console.WriteLine();
        Console.Write("Ingrese la duración (minutos): ");
        Duracion = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Presione ENTER para continuar ");
    Console.ReadLine();
    Console.Clear();


    //Tipo de clasificación
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Seleccione el tipo de clasificación: ");
    Console.WriteLine();
    Console.WriteLine("1. Todo público");
    Console.WriteLine("2. +13");
    Console.WriteLine("3. +18");
    Console.WriteLine();
    Console.Write("Selección: ");
    Clasificacion = int.Parse(Console.ReadLine());

    while (Clasificacion < 1 || Clasificacion > 3)
    {
        Console.WriteLine();
        Console.WriteLine("Opción inválida");
        Console.WriteLine();
        Console.Write("Seleccione el tipo de clasificación: ");
        Clasificacion = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Presione ENTER para continuar ");
    Console.ReadLine();
    Console.Clear();


    //Hora programada
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Ingrese la hora programada (0-23): ");
    HoraProgramada=int.Parse(Console.ReadLine());
    while (HoraProgramada<0 || HoraProgramada>23)
    {
        Console.WriteLine();
        Console.WriteLine("Hora programada inválida");
        Console.WriteLine();
        Console.Write("Ingrese la hora programada (0-23): ");
        HoraProgramada = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Presione ENTER para continuar ");
    Console.ReadLine();
    Console.Clear();


    //Nivel de proudcción
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Seleccione el nivel de producción: ");
    Console.WriteLine();
    Console.WriteLine("1. Bajo");
    Console.WriteLine("2. Medio");
    Console.WriteLine("3. Alto");
    Console.WriteLine();
    Console.Write("Selección: ");
    NivelProduccion = int.Parse(Console.ReadLine());

    while (NivelProduccion < 1 || NivelProduccion > 3)
    {
        Console.WriteLine();
        Console.WriteLine("Opción inválida");
        Console.WriteLine();
        Console.Write("Seleccione el nivel de producción: ");
        NivelProduccion = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Presione ENTER para continuar ");
    Console.ReadLine();
    Console.Clear();
}






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
            Validacion();

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