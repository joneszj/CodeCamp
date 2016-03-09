using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit = 'a';
            string userInput = "";
            double calculatedValue = 0.0;
            double newValue = 0.0;
            string traceString = "";
            int step = 1;

            Console.WriteLine("Calculator: press x to exit, c to clear");

            do
            {
                //build user interface
                if (step == 1)
                {
                    Console.Write("Number: ");
                    userInput = Console.ReadLine();
                }
                else if (step == 2)
                {
                    Console.Write("Operator: ");
                    userInput = Console.ReadLine();
                }

                //parse user input
                if (step == 1)
                {
                    if (double.TryParse(userInput, out newValue))
                    {
                        traceString = newValue + " ";
                            calculatedValue = newValue;
                        step = 2;
                    }
                    else
                    {
                        if (userInput == "x")
                        {
                            exit = 'x';
                        }
                        else if (userInput == "c")
                        {
                            Console.Clear();
                            step = 1;
                            Console.WriteLine("-----RESET-----");
                            Console.WriteLine("Calculator: press x to exit, c to clear");
                        }
                        else
                        {
                            Console.WriteLine("NaN");
                        }
                    }
                }
                else if (step == 2)
                {
                    //what operator did the user pass
                    switch (userInput)
                    {
                        case "+":
                            //update trace string
                            traceString += userInput + " ";
                            //prompt user for next value to use the passed operator against
                            Console.Write("Number: ");
                            userInput = Console.ReadLine();
                            //parse new value
                            if (double.TryParse(userInput, out newValue))
                            {
                                //update trace string
                                traceString += newValue + " ";
                                //perform calculation
                                calculatedValue += newValue;
                            }
                            else
                            {
                                if (userInput == "x")
                                {
                                    //will exit
                                    exit = 'x';
                                }
                                else if (userInput == "c")
                                {
                                    //set step to 1 and reset
                                    Console.Clear();
                                    step = 1;
                                    Console.WriteLine("-----RESET-----");
                                    Console.WriteLine("Calculator: press x to exit, c to clear");
                                }
                                else
                                {
                                    Console.WriteLine("NaN");
                                }
                            }
                            break;
                        case "-":
                            traceString += userInput + " ";
                            Console.Write("Number: ");
                            userInput = Console.ReadLine();
                            if (double.TryParse(userInput, out newValue))
                            {
                                traceString += newValue + " ";
                                calculatedValue -= newValue;
                            }
                            else
                            {
                                if (userInput == "x")
                                {
                                    exit = 'x';
                                }
                                else if (userInput == "c")
                                {
                                    Console.Clear();
                                    step = 1;
                                    Console.WriteLine("-----RESET-----");
                                    Console.WriteLine("Calculator: press x to exit, c to clear");
                                }
                                else
                                {
                                    Console.WriteLine("NaN");
                                }
                            }
                            break;
                        case "*":
                            traceString += userInput + " ";
                            Console.Write("Number: ");
                            userInput = Console.ReadLine();
                            if (double.TryParse(userInput, out newValue))
                            {
                                traceString += newValue + " ";
                                calculatedValue *= newValue;
                            }
                            else
                            {
                                if (userInput == "x")
                                {
                                    exit = 'x';
                                }
                                else if (userInput == "c")
                                {
                                    Console.Clear();
                                    step = 1;
                                    Console.WriteLine("-----RESET-----");
                                    Console.WriteLine("Calculator: press x to exit, c to clear");
                                }
                                else
                                {
                                    Console.WriteLine("NaN");
                                }
                            }
                            break;
                        case "/":
                            traceString += userInput + " ";
                            Console.Write("Number: ");
                            userInput = Console.ReadLine();
                            if (double.TryParse(userInput, out newValue))
                            {
                                traceString += newValue + " ";
                                calculatedValue /= newValue;
                            }
                            else
                            {
                                if (userInput == "x")
                                {
                                    exit = 'x';
                                }
                                else if (userInput == "c")
                                {
                                    Console.Clear();
                                    step = 1;
                                    Console.WriteLine("-----RESET-----");
                                    Console.WriteLine("Calculator: press x to exit, c to clear");
                                }
                                else
                                {
                                    Console.WriteLine("NaN");
                                }
                            }
                            break;
                        case "%":
                            traceString += userInput + " ";
                            Console.Write("Number: ");
                            userInput = Console.ReadLine();
                            if (double.TryParse(userInput, out newValue))
                            {
                                traceString += newValue + " ";
                                calculatedValue %= newValue;
                            }
                            else
                            {
                                if (userInput == "x")
                                {
                                    exit = 'x';
                                }
                                else if (userInput == "c")
                                {
                                    Console.Clear();
                                    step = 1;
                                    Console.WriteLine("-----RESET-----");
                                    Console.WriteLine("Calculator: press x to exit, c to clear");
                                }
                                else
                                {
                                    Console.WriteLine("NaN");
                                }
                            }
                            break;
                        case "c":
                            Console.Clear();
                            step = 1;
                            Console.WriteLine("-----RESET-----");
                            Console.WriteLine("Calculator: press x to exit, c to clear");
                            break;
                        default:
                            Console.WriteLine("--Invalid Operator. Valid operators + - * / %");
                            break;
                    }
                }

                //print result, but not if reset
                if (userInput != "c")
                {
                    Console.WriteLine("--Trace: ({0}), {1}", calculatedValue, traceString);
                }
                else
                {
                    //reset trace
                    traceString = "";
                }

            } while (exit != 'x');
        }
    }
}
