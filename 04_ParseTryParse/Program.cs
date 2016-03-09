using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ParseTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int parsedValue = 0;
            Console.WriteLine("Enter a number: ");
            input = Console.ReadLine();
            //the try parse static method will accept a string, will attempt to parse the value, and if successful it will assign the out parameter with the parsed value and return true
            //int.TryParse(input, out parsedValue);
            //we will be going over the if else statement in the next lesson, this is here to demonstrate the tryparse method
            if (int.TryParse(input, out parsedValue))
            {
                //success
                //do something with an actual integer

                //the parse static method will only attempt to parse and retuern the passed parameter and throw an exception if it fails
                //there is no need to parse the input again, this is here simply to demonstrate the parse method 
                //(it wont throw an exception as we already know the input will parse successfully)
                int newParsedValue = int.Parse(input);
            }
            else
            {
                //failure
            }
            //generally, tryparse is preferred as it wont throw an exception and the out parameter can be used for further logic
        }
    }
}
