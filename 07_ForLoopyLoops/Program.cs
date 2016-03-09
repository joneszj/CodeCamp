using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ForLoopyLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randomNumber = r.Next(0,100);
            for (int i = 0; i < randomNumber; i++)
            {
                Console.WriteLine("iteration: {0}, randomnNumber: {1}", i, randomNumber);
                //notice the new nested variable name!
                for (int y = 0; y < 1; y++)
                {
                    Console.WriteLine("    -silly trivial nested for loop");
                }
            }

            Console.ReadKey();
        }
    }
}
