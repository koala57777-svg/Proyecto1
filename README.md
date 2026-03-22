# Simulador de decisiones para plataforma de streaming

## Explicación del Proyecto
Este proyecto es una aplicación de consola desarrollada en C# hecha para automatizar el proceso de evaluación de contenidos en una plataforma de streaming. El sistema actúa como una herramienta de apoyo para el equipo de programación, permitiendo filtrar películas, series, documentales y eventos en vivo basándose en criterios técnicos, legales y de producción.

## Descripción del Sistema
El programa utiliza una lógica por etapas para que solo el contenido adecuado llegue a los usuarios:

1. **Validación Técnica:** El sistema verifica que el contenido cumpla con los rangos de duración permitidos por su tipo y que su clasificación sea coherente con el horario programado. También valida que el nivel de producción sea el adecuado para el público objetivo.
2. **Clasificación de Impacto:** Determina si un contenido tendrá un impacto Bajo, Medio o Alto analizando variables como la hora de emisión y la calidad de la producción.
3. **Decisión Final:** Emite uno de los cuatro decisiones posibles:
   - **Publicar:** Cumple todas las reglas y tiene impacto bajo o medio.
   - **Publicar con ajustes:** Cumple la base técnica pero requiere cambios en horario o duración.
   - **Enviar a revisión:** Contenidos de alto impacto que requieren supervisión.
   - **Rechazar:** Incumple reglas obligatorias del sistema.
4. **Panel de Estadísticas:** Ofrece un resumen de la sesión, incluyendo porcentajes de aprobación e identificación del impacto predominante.

## Instrucciones para la Ejecución
Para ejecutar este programa en tu computadora, sigue estas instrucciones:

1. **Preparación del entorno:** Asegúrate de tener instalado el SDK de .NET y un entorno de desarrollo como Visual Studio o Visual Studio Code.
2. **Descarga del código:** Clona este repositorio o descarga los archivos fuente del proyecto.
3. **Compilación:** Abre el proyecto en tu editor y compila la solución para verificar que no existan errores.
4. **Ejecución:** Inicia la aplicación. Verás un menú principal con 5 opciones numeradas.
5. **Uso:** - Selecciona la opción **1** para iniciar una evaluación de contenido.
   - Utiliza la opción **3** en cualquier momento para ver las  estadísticas de la sesión.
   - Utiliza la opción **5** para cerrar el programa y ver el resumen final de evaluaciones.
