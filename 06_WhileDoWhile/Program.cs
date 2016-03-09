using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit = 'a';
            do
            {
                //the random class allows us to generate random values
                //unlike the Console class that is static, the Random class is not so we need to create an instance of it to use it
                //we use the new keyword to create an instance {class} name = new {class}();
                Random r = new Random();
                int randomNumber = r.Next(0, 100);

                Console.WriteLine("Guess the random number: ");
                string input = Console.ReadLine();
                int iInput = int.Parse(input);

                while (iInput != randomNumber)
                {
                    //you are below
                    if (iInput < randomNumber)
                    {
                        Console.WriteLine("too low");
                    }
                    //you are above
                    else
                    {
                        Console.WriteLine("too high");
                    }
                    Console.WriteLine("guess again...");
                    input = Console.ReadLine();
                    iInput = int.Parse(input);
                }
                Console.WriteLine("good job! You guessd {0} and the number is {1}", iInput, randomNumber);
                //Console.WriteLine("good job! You guessd " + iInput + " and the number is " + randomNumber);
                //Console.WriteLine("Press any key to exit...");
                Console.WriteLine("Press the x key to exit, or any other key to resart");
                exit = Console.ReadKey().KeyChar;
            } while (exit != 'x');
        }
    }
}
