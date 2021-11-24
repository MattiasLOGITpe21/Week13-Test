using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorypath = @"C:\users\opilane\Samples\madis";
            string starsfile = "stars.txt";
            string planetsfile = "planets.txt";

            string starsfullpath = $@"{directorypath}\{starsfile}";
            string planetsfullpath = $@"{directorypath}\{planetsfile}";

            bool directoryexists = Directory.Exists(directorypath);
            bool starsfullpathexists = File.Exists(starsfullpath);
            bool planetsfullpathexists = File.Exists(planetsfullpath);

            if (directoryexists && starsfullpathexists && planetsfullpathexists)
            {
                Console.WriteLine($"{starsfile} and {planetsfile} already exist in {directorypath}");
            }
            else if (!directoryexists)
            {
                Console.WriteLine($"{directorypath} doesen't exist.");
                Directory.CreateDirectory(directorypath);
                Console.WriteLine($"{directorypath} has been created");

                File.Create(starsfullpath);
                File.Create(planetsfullpath);
                Console.WriteLine($"{planetsfile} and {starsfile} have been created in {directorypath}");
            }
            else
            {
                File.Create(starsfullpath);
                File.Create(planetsfullpath);
                Console.WriteLine($"{planetsfile} and {starsfile} have been created in {directorypath}");
            }
        }
    }
}
