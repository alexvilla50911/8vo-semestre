using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        // ruta de la carpeta donde estan los archivos
        string carpetaPath = "Files";

        // obtener la lista de archivos
        string[] archivosEnCarpeta = Directory.GetFiles(carpetaPath, "*.html");

        // Cronometro global
        Stopwatch tiempoTotal = Stopwatch.StartNew();

        foreach (string rutaArchivo in archivosEnCarpeta)
        {
            // Cronometro para cada archivo html
            Stopwatch tiempoArchivo = Stopwatch.StartNew();

            try
            {
                // StreamReader abre y lee cada archivo
                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    // leer archivio
                    string contenido = lector.ReadToEnd();

                    // aqui se detiene el cronometro
                    tiempoArchivo.Stop();

                    // se imprime la ruta del archivo y su tiempo de ejecucion
                    Console.WriteLine($"Archivo: {rutaArchivo}");
                    Console.WriteLine($"Tiempo de ejecución: {tiempoArchivo.Elapsed.TotalSeconds} segundos");
                    
                }
            }
            catch (Exception ex)
            {
                // mensaje en caso de que haya errores
                Console.WriteLine($"Ocurrió un error al abrir el archivo {rutaArchivo}: {ex.Message}");
            }
        }

        // se detiene el cronometro global
        tiempoTotal.Stop();
        Console.WriteLine($"\nTiempo total de ejecución para los {archivosEnCarpeta.Length} archivos: {tiempoTotal.Elapsed.TotalSeconds} segundos");
        Console.WriteLine("Alejandro Villarreal Carvajal");
        Console.WriteLine("Matricula 2839436");
    }
}
