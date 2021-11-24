using System;
using System.IO;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = $@"C:\Users\opilane\Samples\madis";
            Console.WriteLine("Kas tahate näha 'stars' või 'planet' faili sisu näha?");
            string userFile = Console.ReadLine();
            string fileDirect = $@"{rootdirect}\{userFile}.txt";
            bool exists = File.Exists(fileDirect);
            if (exists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirect);
                if (userFile == "planets" || userFile == "stars")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{userFile}.txt file does not exist.");
                }
            }
            else
            {
                Console.WriteLine($"{userFile}.txt file does not exist.");
            }
        }
    }
}
