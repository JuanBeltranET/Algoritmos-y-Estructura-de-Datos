using System;
using System.IO;

string ruta = "diario.txt";
Console.WriteLine("Escribe tu nombre y una frase favorita para guardar en el archivo:");
Console.WriteLine("Nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Frase Favorita:");
string frase = Console.ReadLine();
using (StreamWriter escritor = new StreamWriter(ruta, append: false))
{
    escritor.WriteLine($"Nombre: {nombre}");
    escritor.WriteLine($"Frase Favorita: {frase}");
}
using (StreamWriter sw = new StreamWriter(ruta, true))

{
    sw.WriteLine($"Última actualización: {DateTime.Now}");
}
Console.WriteLine("Archivo guardado correctamente.");