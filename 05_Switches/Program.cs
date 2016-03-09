using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SwitchesStiches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            switch (color.ToLower())
            {
                case "purple":
                    Console.WriteLine("You are awesome");
                    break;
                case "blue":
                case "green":
                case "red":
                    Console.WriteLine("Eh");
                    break;
                default:
                    Console.WriteLine("You need to question your existence...");
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
