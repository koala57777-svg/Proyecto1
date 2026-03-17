//Bloque de variables globales
using System.Globalization;
using System.Xml;

int opcion = -1;

int TipoContenido = 0;
int Duracion = 0;
int Clasificacion = 0;
int HoraProgramada = 0;
int NivelProduccion = 0;

int ContadorTotalEvaluados = 0;
int ContadorPublicados = 0;
int ContadorRechazados = 0;
int ContadorEnRevision = 0;

int TipoImpacto = 0;
// 1 = Impacto Alto
// 2 = Impacto Medio
// 3 = Impacto Bajo

int ContadorImpactoAlto = 0;
int ContadorImpactoMedio = 0;
int ContadorImpactoBajo = 0;

string ResultadoClasificacionImpacto;

bool ResultadoValidacionTecnica= false;
int entrarfuncion = 0;
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




bool ValidacionTecnica(int a)
{
    if (Clasificacion==1 || (Clasificacion==2 && (HoraProgramada>=6 || HoraProgramada<=22)) || (Clasificacion==3 && (HoraProgramada>=22 || HoraProgramada<=5)))
    {
        if ((TipoContenido==1 && (Duracion>=60 && Duracion<=180)) || (TipoContenido == 2 && (Duracion >= 20 && Duracion <= 90)) || (TipoContenido == 3 && (Duracion >= 30 && Duracion <= 120)) || (TipoContenido == 4 && (Duracion >= 30 && Duracion <= 240)))
        {
            if (  (NivelProduccion==1 && (Clasificacion==1 || Clasificacion==2)) || ((NivelProduccion==2 || NivelProduccion==3))  )
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Validación técnica satisfactoria");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Presione ENTER para continuar ");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Decisión final: Rechazar");
                Console.WriteLine();
                Console.WriteLine("Razón: Inclumple alguna regla obligatoria");
                ContadorRechazados++;
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Presione ENTER para continuar ");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Decisión final: Rechazar");
            Console.WriteLine();
            Console.WriteLine("Razón: Inclumple alguna regla obligatoria");
            ContadorRechazados++;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar ");
            Console.ReadLine();
            Console.Clear();
            return false;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Decisión final: Rechazar");
        Console.WriteLine();
        Console.WriteLine("Razón: Inclumple alguna regla obligatoria");
        ContadorRechazados++;
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Presione ENTER para continuar ");
        Console.ReadLine();
        Console.Clear();
        return false;
    }
}


string ImprimirTipoImpacto(int b)
{
    if (b == 1)
    {
        ContadorImpactoAlto++;
        return "Clasificación de impacto: Impacto Alto";
    }
    else if(b == 2)
    {
        ContadorImpactoMedio++;
        return "Clasificación de impacto: Impacto Medio";
    }
    else if (b == 3)
    {
        ContadorImpactoBajo++;
        return "Clasificación de impacto: Impacto Bajo";
    }
    else
    {
        return "No entra en ningun tipo de impacto";
    }
}

string ClasificacionImpacto(bool a)
{
    if (a)
    {
        if (NivelProduccion == 3 || Duracion > 120 || (HoraProgramada >= 20 && HoraProgramada <= 23))
        {
            TipoImpacto = 1;
            Console.WriteLine();
            return ImprimirTipoImpacto(TipoImpacto);
        }
        else if (NivelProduccion == 2 || (Duracion >= 60 && Duracion <= 120))
        {
            TipoImpacto = 2;
            Console.WriteLine();
            return ImprimirTipoImpacto(TipoImpacto);
        }
        else if (NivelProduccion == 1 && Duracion<60)
        {
            TipoImpacto = 3;
            Console.WriteLine();
            return ImprimirTipoImpacto(TipoImpacto);
        }
    }
    else
    {
        return ImprimirTipoImpacto(TipoImpacto);
    }
    return null;
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

            ResultadoValidacionTecnica= ValidacionTecnica(entrarfuncion);

            
            ResultadoClasificacionImpacto= ClasificacionImpacto(ResultadoValidacionTecnica);
            Console.WriteLine(ResultadoClasificacionImpacto);

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