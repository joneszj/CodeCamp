using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ModularFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int arrayCount = r.Next(10, 100);
            //create and populate array
            int[] values = new int[arrayCount];
            for (int i = 0; i < arrayCount; i++)
            {
                values[i] = r.Next(0, 50);
            }

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(i);
                //mod 2
                if (i % 2 == 0)
                {
                    Console.WriteLine("mod 2 {0}", values[i]);
                }
                //mod 3
                if (i % 3 == 0)
                {
                    Console.WriteLine("mod 3 {0}", values[i]);
                }
                //mod 5
                if (i % 5 == 0)
                {
                    Console.WriteLine("mod 5 {0}", values[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
