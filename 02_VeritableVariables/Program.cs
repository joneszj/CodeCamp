using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VeritableVariables
{
    class Program
    {
        //binary decimal: 0.(1/2)(1/4)(1/8)(1/16)etc
        //Console.WriteLine("well.... 0.1 acually looks like this in binary: 0.0001100110011001100110011001100110011001100110011001100110011001");
        //fun http://www.exploringbinary.com/binary-converter/
        //https://www.youtube.com/watch?v=BSHFCqbU0fA
        //awesome https://www.youtube.com/watch?v=Y4Q9PnjKhac

        static void Main(string[] args)
        {
            #region floats
            //variable declaration
            float f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0;

            //lets print the initialized value for each float then using f1 lets add 0.1 to it 9 times to see if we can get the quirk
            Console.WriteLine("f1 is " + f1 + ", f2 is " + f2);
            f1 = f1 + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f;
            Console.WriteLine("f1 = (0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1) ? " + f1);

            //this form of repetition is lame. We will soon get into loops that will make repition code much easier
            f2 += 0.1f;
            f2 += 0.1f;
            f2 += 0.1f;
            f2 += 0.1f;
            f2 += 0.1f;
            f2 += 0.1f;
            f2 += 0.1f;
            f2 += 0.1f;
            f2 += 0.1f;
            //it seems the compiler does so trickery when adding 0.1 9 times and then assigning the result
            //as opposed to adding 0.1f and assigning it each time. 
            //I suppose the 0.1f when added 9 times and then assigned gets truncated before it is assigned.
            //But when adding and assigning 0.1 individually the true colors are seen.
            Console.WriteLine("Quirk: f2 += 0.1; f2 += 0.1; f2 += 0.1; f2 += 0.1; f2 += 0.1; f2 += 0.1; f2 += 0.1; f2 += 0.1; ? " + f2);

            //post increment and decrement operators
            f3++;
            f3++;
            Console.WriteLine("Post-Increment operator: f3++ twice gives us " + f3);
            f4--;
            f4--;
            Console.WriteLine("Post-Decrement operator: f4-- twice gives us " + f4);

            #endregion
            #region decimals
            //quirk testing with decimal types
            Console.WriteLine("Lets try the same operation that we did on f2 but with the decimal type");
            decimal d1 = 0;
            d1 += 0.1m;
            d1 += 0.1m;
            d1 += 0.1m;
            d1 += 0.1m;
            d1 += 0.1m;
            d1 += 0.1m;
            d1 += 0.1m;
            d1 += 0.1m;
            d1 += 0.1m;
            Console.WriteLine("d1 += 0.1m; d1 += 0.1m; d1 += 0.1m; d1 += 0.1m; d1 += 0.1m; d1 += 0.1m; d1 += 0.1m; d1 += 0.1m; d1 += 0.1m; ? " + d1);
            //So why not always use decimal? Well it takes significant more processing power to work with the decimal type so it is usually avoided unless necessary

            #endregion
            #region scope
            //lets examine scope
            int n1 = 0;
            {
                int n2 = 5;
                int n3 = n1 + n2;
            }
            //both of the below lines will fail as n2 and n3 are declared in the block above and thus are not in scope
            //Console.WriteLine(n2);
            //Console.WriteLine(n3); 
            #endregion

            /*
                click on the error tab... notice the warning? f5 is never used. This warning will not break our application
                but VS lets us know about it incase we meant to use it. For demonstration purposes we will leave it here, but I
                hate seeing warnings so I do my best to fix the warning
            */

            Console.ReadKey();
        }
    }
}
