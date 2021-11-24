using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So Interesting You'll say, 'OMG!'");

            string directoryPath = @"C:\users\opilane\samples\madis";
            string fileName = "funfacts.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);
            Random rnd = new Random();
            Console.WriteLine(dataFromFile[rnd.Next(dataFromFile.Length)]);

            Console.ReadLine();
        }
    }
}