//Bloque de variables globales
using System.Globalization;
using System.Xml;

int opcion = -1;
string impactoPredominante = "Ninguno";
double porcentajeAprobacion = 0;
double totalAprobados = 0;

int TipoContenido = 0;
int Duracion = 0;
int Clasificacion = 0;
int HoraProgramada = 0;
int NivelProduccion = 0;

int ContadorTotalEvaluados = 0;
int ContadorPublicados = 0;
int ContadorRechazados = 0;
int ContadorEnRevision = 0;
int ContadorPublicadosAjustes = 0;
int ResultadoDescisionFinal; // 1 = Publicar, 2 = Publicar con ajustes, 3 = Enviar a revisión, 4 = Rechazar

int TipoImpacto = 0; // 1 = Impacto Alto, 2 = Impacto Medio, 3 = Impacto Bajo
string ResultadoClasificacionImpacto;
int ContadorImpactoAlto = 0;
int ContadorImpactoMedio = 0;
int ContadorImpactoBajo = 0;

bool ResultadoValidacionTecnica= false;
int entrarfuncion = 0;

bool RequiereAjustes = false;
//----------------------------

void Validacion()
{
    //Tipo de contenido
    do
    {
        Console.Clear();
        Console.WriteLine("---Evaluar nuevo contenido---");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Seleccione el tipo de contenido: ");
        Console.WriteLine();
        Console.WriteLine("1. Película");
        Console.WriteLine("2. Serie");
        Console.WriteLine("3. Documental");
        Console.WriteLine("4. Evento en vivo");
        Console.WriteLine();
        Console.Write("Selección: ");
        
        if (!int.TryParse(Console.ReadLine(), out TipoContenido))
        {
            TipoContenido = -1;
            Console.WriteLine();
        }
        
        if (TipoContenido < 1 || TipoContenido > 4)
        {
            Console.WriteLine("Opción inválida. Presiona cualquier tecla para reintentar...");
            Console.ReadKey();
        }

    } while (TipoContenido < 1 || TipoContenido > 4);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Presiona cualquier tecla para continuar");
    Console.WriteLine();
    Console.ReadKey();



    //Duración
    do
    {
        Console.Clear();
        Console.WriteLine("--- Evaluar nuevo contenido ---");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Ingrese la duración (minutos): ");

        if (!int.TryParse(Console.ReadLine(), out Duracion))
        {
            Duracion = -1;
            Console.WriteLine();
        }
        
        if (Duracion <= 0)
        {
            Console.WriteLine("Duración inválida. Presiona cualquier tecla para reintentar...");
            Console.ReadKey();
        }

    } while (Duracion <= 0);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Presiona cualquier tecla para continuar");
    Console.WriteLine();
    Console.ReadKey();


    //Tipo de clasificación
    do
    {
        Console.Clear();
        Console.WriteLine("--- Evaluar nuevo contenido ---");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Seleccione el tipo de clasificación: ");
        Console.WriteLine();
        Console.WriteLine("1. Todo público");
        Console.WriteLine("2. +13");
        Console.WriteLine("3. +18");
        Console.WriteLine();
        Console.Write("Selección: ");
        if (!int.TryParse(Console.ReadLine(), out Clasificacion))
        {
            Clasificacion = -1;
            Console.WriteLine();
        }
        
        if (Clasificacion < 1 || Clasificacion > 3)
        {
            Console.WriteLine("Opción inválida. Presiona cualquier tecla para reintentar...");
            Console.ReadKey();
        }
    } while (Clasificacion < 1 || Clasificacion > 3);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Presiona cualquier tecla para continuar");
    Console.WriteLine();
    Console.ReadKey();


    //Hora programada
    do
    {

        Console.Clear();
        Console.WriteLine("--- Evaluar nuevo contenido ---");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Ingrese la hora programada (0-23): ");

        if (!int.TryParse(Console.ReadLine(), out HoraProgramada))
        {
            HoraProgramada = -1;
            Console.WriteLine();
        }
        
        if (HoraProgramada < 0 || HoraProgramada > 23)
        {
            Console.WriteLine("Hora programada inválida. Presiona cualquier tecla para reintentar...");
            Console.ReadKey();
        }
    } while (HoraProgramada < 0 || HoraProgramada > 23);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Presiona cualquier tecla para continuar");
    Console.WriteLine();
    Console.ReadKey();


    //Nivel de proudcción
    do
    {


        Console.Clear();
        Console.WriteLine("--- Evaluar nuevo contenido ---");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Seleccione el nivel de producción: ");
        Console.WriteLine();
        Console.WriteLine("1. Bajo");
        Console.WriteLine("2. Medio");
        Console.WriteLine("3. Alto");
        Console.WriteLine();
        Console.Write("Selección: ");
        if (!int.TryParse(Console.ReadLine(), out NivelProduccion))
        {
            NivelProduccion = -1;
        }

        if (NivelProduccion < 1 || NivelProduccion > 3)
        {
            Console.WriteLine("Opción inválida. Presiona cualquier tecla para reintentar...");
            Console.ReadKey();
        }
    } while (NivelProduccion < 1 || NivelProduccion > 3);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Presiona cualquier tecla para continuar");
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();
}




bool ValidacionTecnica(int a)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("----Validación técnica----");

    RequiereAjustes = false;

    if ((NivelProduccion == 1 && (Clasificacion == 1 || Clasificacion == 2)) || ((NivelProduccion == 2 || NivelProduccion == 3)))
    {
        if (Clasificacion == 1 || (Clasificacion == 2 && (HoraProgramada >= 6 || HoraProgramada <= 22)) || (Clasificacion == 3 && (HoraProgramada >= 22 || HoraProgramada <= 5)))
        {
            if ((TipoContenido == 1 && (Duracion >= 60 && Duracion <= 180)) || (TipoContenido == 2 && (Duracion >= 20 && Duracion <= 90)) || (TipoContenido == 3 && (Duracion >= 30 && Duracion <= 120)) || (TipoContenido == 4 && (Duracion >= 30 && Duracion <= 240)))
            {
                ContadorTotalEvaluados++;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Validación técnica satisfactoria");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                return true;
            }
            else
            {
                RequiereAjustes = true;
                ContadorTotalEvaluados++;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Validación técnica satisfactoria (Requiere ajustar duración)");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                return true;
            }
        }
        else
        {
            RequiereAjustes = true;
            ContadorTotalEvaluados++;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Validación técnica satisfactoria (Requiere ajustar horario)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            return true;
        }
    }
    else
    {
        ContadorTotalEvaluados++;
        ContadorRechazados++;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Validación técnica insatisfactoria");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("No entra al análisis de impacto");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Decisión final: Rechazar");
        Console.WriteLine();
        Console.WriteLine("Razón: Incumple regla obligatoria de nivel de producción");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Presiona cualquier tecla para continuar");
        Console.WriteLine();
        Console.ReadKey();
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
        return "No entra al análisis de impacto";
    }
}

string ClasificacionImpacto(bool a)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("----Clasificación de impacto----");
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


int DesicionFinal(int a, bool b)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Presiona cualquier tecla para continuar");
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("---- Decisión final ----");
    Console.WriteLine();
    Console.WriteLine();
    if (b) 
    {
        if (TipoImpacto == 1)
        {
            ContadorEnRevision++;
            Console.WriteLine("Decisión: Enviar a revisión");
            Console.WriteLine();
            Console.WriteLine("Razón: Cumple reglas técnicas, pero tiene impacto Alto.");
            return 3;
        }
        else if (RequiereAjustes)
        {
            ContadorPublicadosAjustes++;
            Console.WriteLine("Decisión: Publicar con ajustes");
            Console.WriteLine();
            Console.WriteLine("Razón: Cumple reglas técnicas, pero requiere modificación menor (horario o duración).");
            return 2;
        }
        else if (TipoImpacto == 2 || TipoImpacto == 3)
        {
            ContadorPublicados++;
            Console.WriteLine("Decisión: Publicar");
            Console.WriteLine();
            Console.WriteLine("Razón: Cumple todas las reglas técnicas y su impacto es Bajo o Medio.");
            return 1;
        }
    }
    else
    {
        return 4;
    }
    return -1;
}



void MostrarEstadisticas()
{

    if (ContadorImpactoAlto > 0 || ContadorImpactoMedio > 0 || ContadorImpactoBajo > 0)
    {
        if (ContadorImpactoAlto >= ContadorImpactoMedio && ContadorImpactoAlto >= ContadorImpactoBajo)
        {
            impactoPredominante = "Alto";
        }
        else if (ContadorImpactoMedio >= ContadorImpactoAlto && ContadorImpactoMedio >= ContadorImpactoBajo)
        {
            impactoPredominante = "Medio";
        }
        else
        {
            impactoPredominante = "Bajo";
        }
    }

    if (ContadorTotalEvaluados > 0)
    {
        totalAprobados = ContadorPublicados + ContadorPublicadosAjustes + ContadorEnRevision;
        porcentajeAprobacion = ((totalAprobados*100) / ContadorTotalEvaluados);
    }

    Console.WriteLine($"Total evaluados: {ContadorTotalEvaluados}");
    Console.WriteLine($"Publicados: {ContadorPublicados}");
    Console.WriteLine($"Publicados con ajustes: {ContadorPublicadosAjustes}");
    Console.WriteLine($"Rechazados: {ContadorRechazados}");
    Console.WriteLine($"En revisión: {ContadorEnRevision}");
    Console.WriteLine($"Impacto predominante: {impactoPredominante}");
    Console.WriteLine($"Porcentaje de aprobación: {porcentajeAprobacion}%");

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
    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        opcion = -1;
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Presiona cualquier tecla para continuar");
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();

    switch (opcion)
    {
        case 1:
            Console.WriteLine();
            Console.WriteLine();

            Validacion();

            ResultadoValidacionTecnica= ValidacionTecnica(entrarfuncion);

            if (ResultadoValidacionTecnica)
            {
                ResultadoClasificacionImpacto = ClasificacionImpacto(ResultadoValidacionTecnica);
                Console.WriteLine(ResultadoClasificacionImpacto);

                ResultadoDescisionFinal = DesicionFinal(TipoImpacto, ResultadoValidacionTecnica);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            break;

        case 2:
            for (int i = 1; i <= 47; i++)
            {
                Console.Write("_");
            }
            Console.Write("Mostrar reglas del sistema");
            for (int i = 1; i <= 47; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i=1; i<=43; i++)
            {
                Console.Write("-");
            }
            Console.Write(" REGLAS OBLIGATORIAS DE EVALUACIÓN ");
            for (int i = 1; i <= 42; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Horarios permitidos según clasificación:");
            Console.WriteLine("   - Todo público: Cualquier hora");
            Console.WriteLine("   - +13: Entre 6 y 22 horas");
            Console.WriteLine("   - +18: Entre 22 y 5 horas");
            Console.WriteLine();
            Console.WriteLine("2. Duración permitida según contenido:");
            Console.WriteLine("   - Película: 60 - 180 minutos");
            Console.WriteLine("   - Serie: 20 - 90 minutos");
            Console.WriteLine("   - Documental: 30 - 120 minutos");
            Console.WriteLine("   - Evento en vivo: 30 - 240 minutos");
            Console.WriteLine();
            Console.WriteLine("3. Restricciones de producción:");
            Console.WriteLine("   - Producción Baja: Solo válida para Todo público o +13");
            Console.WriteLine("   - Producción Media/Alta: Válida para cualquier clasificación");
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            break;

        case 3:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- Mostrar estadísticas de la sesión ---");
            Console.WriteLine();

            MostrarEstadisticas();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            break;

        case 4:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- Reiniciando estadísticas ---");

            ContadorTotalEvaluados = 0;
            ContadorPublicados = 0;
            ContadorRechazados = 0;
            ContadorEnRevision = 0;
            ContadorPublicadosAjustes = 0;
            ContadorImpactoAlto = 0;
            ContadorImpactoMedio = 0;
            ContadorImpactoBajo = 0;
            impactoPredominante = "Ninguno";
            porcentajeAprobacion = 0;
            totalAprobados = 0;

            Console.WriteLine();
            Console.WriteLine("Las estadísticas de la sesión han sido reiniciadas a 0.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            break;

        case 5:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- Resumen final de la sesión ---");
            Console.WriteLine();

            MostrarEstadisticas();

            Console.WriteLine();
            Console.WriteLine("Saliendo del sistema...");
            break;

        default:
            Console.WriteLine("Opción inválida. Por favor elija una opción (1-5)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            break;
    }
}while (opcion != 5);