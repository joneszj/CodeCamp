using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //perhaps mention short circuiting

            //we can use this success boolean to track if a user receives or does not receive the DL
            bool success = false;

            Console.WriteLine("What is your age?");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            //age is under 16
            if (age < 16)
            {
                Console.WriteLine("You are not old enough to receive a drivers license");
            }
            //age is above 16 but below 18
            else if (age < 18)
            {
                Console.WriteLine("Do you have parental consent? Y/N");
                char parentalConcent = Console.ReadKey().KeyChar;
                //has parental consent
                if (parentalConcent == 'Y' || parentalConcent == 'y')
                {
                    success = true;
                }
                //does not have parental consent
                else if (parentalConcent == 'N' || parentalConcent == 'n')
                {

                }
                //used an invalid char
                else
                {
                    Console.WriteLine("You entered an invalid character!");
                }
            }
            //age is above 18
            else
            {
                success = true;
                Console.WriteLine("Here is your drivers license...");
            }

            //END
            if (success)
            {
                Console.WriteLine("Thank you for your cooperation");
            }
            else
            {
                Console.WriteLine("We apologize we were unable to assist you");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
