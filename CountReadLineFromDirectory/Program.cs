using System;
using System.Configuration;
using System.IO;

namespace CountReadLineFromDirectory
{
    class Program
    {
       private static void Main(string[] args)
       {

           var folderPath = ConfigurationManager.AppSettings["folderPath"]; 

            var files = Directory.GetFiles(folderPath, "*.txt", SearchOption.AllDirectories);

            var lineCount = 0;
            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);
                lineCount += lines.Length;
            }

            Console.WriteLine("Toplam Satır Sayısı"+" "+lineCount);
            Console.ReadLine();
        }
    }
}
