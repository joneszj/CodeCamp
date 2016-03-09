using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_LargestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int arrayCount = r.Next(10,100);
            //create and populate array
            int[] values = new int[arrayCount];
            for (int i = 0; i < arrayCount; i++)
            {
                values[i] = r.Next(0,50);
            }

            //determine top 3 highest values
            int highest = 0, secondHighest = 0, thirdHighest = 0;
            //check for highest
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > highest)
                {
                    highest = values[i];
                }
            }
            //check for second highest
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < highest && values[i] > secondHighest)
                {
                    secondHighest = values[i];
                }
            }
            //check for third highest
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < secondHighest && values[i] > thirdHighest)
                {
                    thirdHighest = values[i];
                }
            }

            Console.WriteLine("Highest: {0}, Second Highest {1}, Third Highest {2}", highest, secondHighest, thirdHighest);
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            Console.WriteLine("Sum: " + (highest + secondHighest + thirdHighest));
            Console.ReadKey();
        }
    }
}
