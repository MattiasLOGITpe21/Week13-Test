using System;
using System.IO;

namespace Week13_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\users\opilane\Samples";
            Console.WriteLine("Sisestage kausta nimi:");
            string kaustanimi = Console.ReadLine();

            string directoryfullpath = $@"{rootdirectory}\{kaustanimi}";
            bool directoryexists = Directory.Exists(directoryfullpath);

            if(directoryexists)
            {
                Console.WriteLine($"{kaustanimi} juba eksisteerib Samples kaustas.");               
            }
            else
            {
                Directory.CreateDirectory(directoryfullpath);
                Console.WriteLine($"{kaustanimi} tehti kausta Samples.");                                
            }
            Directory.CreateDirectory(directoryfullpath);
        }
        
    }
}
