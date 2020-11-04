using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filläsare
{
    //Fas 1. Uppgift 3 - Rad/Tecken-räknare
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\oskar\exempelfil-sv.txt
            Console.WriteLine("Ange ett filnamn: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Öppnar {0}", fileName);
            //From: https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-read-a-text-file-in-C-Sharp/
            // Read file using StreamReader. Reads file line by line    
            using (StreamReader file = new StreamReader(fileName))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
    }
}
