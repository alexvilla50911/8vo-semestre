// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

string folderPath = "D:\\Users\\Maurizio Patiño\\Desktop\\IDS 8 sem\\Proyectos de ingenieria de software\\Act2\\Act2\\Files";
string newFolderPath = "D:\\Users\\Maurizio Patiño\\Desktop\\IDS 8 sem\\Proyectos de ingenieria de software\\Act2\\Act2\\NewFiles";

string logFileName = "a2_matricula.txt";
string logFilePath = $"D:\\Users\\Maurizio Patiño\\Desktop\\IDS 8 sem\\Proyectos de ingenieria de software\\Act2\\Act2\\Log\\{logFileName}";


string[] files = Directory.GetFiles(folderPath);

// Inicializar el cronómetro global
Stopwatch tiempoTotal = Stopwatch.StartNew();


//foreach (string file in files)
//{
string file = "D:\\\\Users\\\\Maurizio Patiño\\\\Downloads\\\\CS13309_Archivos_HTML\\\\Files\\\\002.html";
if (File.Exists(file))
{
    string fileName = Path.GetFileName(file);
    string fileContent = File.ReadAllText(file);
    
    // Inicializar un cronómetro para cada archivo
    Stopwatch tiempoArchivo = Stopwatch.StartNew();

    if (!fileContent.Any())
    {
        Console.WriteLine("No hay contenido en el archivo.");
        
        // Detener el cronómetro del archivo
        tiempoArchivo.Stop();

        return;
    }

    RemoveHtmlTags(fileName);

    string logFile = GetOrCreateLogFile();
    
    // Imprimir la ruta del archivo y el tiempo de ejecución
    Console.WriteLine($"Archivo: {rutaArchivo}");
    Console.WriteLine($"Tiempo de ejecución: {tiempoArchivo.Elapsed.TotalSeconds} segundos");

}
//}

void RemoveHtmlTags(string fileName)
{
    string newFile = Path.Combine(newFolderPath, fileName);

    File.Copy(file, newFile);

    string newFileContent = File.ReadAllText(newFile);

    newFileContent = Regex.Replace(newFileContent, "<.*?>", string.Empty);

    File.WriteAllText(newFile, newFileContent);

}

string GetOrCreateLogFile()
{
    if (File.Exists(logFilePath))
        return logFilePath;

    File.Create(logFilePath);
    return logFilePath;

    // Detener el cronómetro global y mostrar el tiempo total
    tiempoTotal.Stop();

    Console.WriteLine($"\nTiempo total para eliminar etiquetas HTML para los {archivosEnCarpeta.Length} archivos: {tiempoTotal.Elapsed.TotalSeconds} segundos");

}




//File.ReadAllText(folderPath);

//if (!File.Exists(folderPath))
//{
//    Console.WriteLine($"El archivo ubicado en: {folderPath} no existe.");
//    return;
//}

