using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15_FormFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 0;
            string firstName = "", lastName = "", city = "", state = "", zip = "", phoneNumber = "", dateOfBirth = "";
            DateTime parsedDateOfBirth = DateTime.MinValue;
            do
            {
                if (step == 0)
                {
                    Console.WriteLine("First Name: ");
                    firstName = Console.ReadLine();
                    if (firstName.Length >= 5 && firstName.Length <= 20)
                    {
                        if (firstName.IndexOf(" ") > -1)
                        {
                            //has space
                            Console.WriteLine("First Name cannot have a space");
                        }
                        else
                        {
                            bool noNumbers = true;
                            //check for numbers
                            for (int i = 0; i < 9; i++)
                            {
                                if (firstName.IndexOf(i.ToString()) > -1)
                                {
                                    //contains a number
                                    noNumbers = false;
                                }
                            }
                            if (noNumbers)
                            {
                                //passed validation
                                step++;
                            }
                            else
                            {
                                Console.WriteLine("First Name cannot have numbers");
                            }
                        }
                    }
                    else
                    {
                        //too small or too large
                        Console.WriteLine("First Name must be between 5 and 20 characters in length");
                    }
                }
                if (step == 1)
                {
                    Console.WriteLine("Last Name: ");
                    lastName = Console.ReadLine();
                    if (lastName.Length >= 5 && lastName.Length <= 20)
                    {
                        if (lastName.IndexOf(" ") > -1)
                        {
                            //has space
                            Console.WriteLine("Last Name cannot have a space");
                        }
                        else
                        {
                            bool noNumbers = true;
                            //check for numbers
                            for (int i = 0; i < 9; i++)
                            {
                                if (lastName.IndexOf(i.ToString()) > -1)
                                {
                                    //contains a number
                                    noNumbers = false;
                                }
                            }
                            if (noNumbers)
                            {
                                //passed validation
                                step++;
                            }
                            else
                            {
                                Console.WriteLine("Last Name cannot have numbers");
                            }
                        }
                    }
                    else
                    {
                        //too small or too large
                        Console.WriteLine("Last Name must be between 5 and 20 characters in length");
                    }
                }
                if (step == 2)
                {
                    Console.WriteLine("City: ");
                    city = Console.ReadLine();
                    if (!string.IsNullOrEmpty(city))
                    {
                        step++;
                    }
                }
                if (step == 3)
                {
                    Console.WriteLine("State: ");
                    state = Console.ReadLine();
                    if (!string.IsNullOrEmpty(state))
                    {
                        step++;
                    }
                }
                if (step == 4)
                {
                    Console.WriteLine("Zip: ");
                    zip = Console.ReadLine();
                    if (!string.IsNullOrEmpty(zip) && zip.Length == 5)
                    {
                        step++;
                    }
                    else
                    {
                        Console.WriteLine("Zip must be 5 characters in length");
                    }
                }
                if (step == 5)
                {
                    Console.WriteLine("Phone Number: ");
                    phoneNumber = Console.ReadLine();
                    if (!string.IsNullOrEmpty(phoneNumber))
                    {
                        Regex reg = new Regex(@"^[1-9]\d{2}-\d{3}-\d{4}");
                        if (reg.IsMatch(phoneNumber))
                        {
                            step++;
                        }
                        else
                        {
                            Console.WriteLine("Phone Number must match ###-###-####");
                        }
                    }
                }
                if (step == 6)
                {
                    Console.WriteLine("Date Of Birth: ");
                    dateOfBirth = Console.ReadLine();
                    if (!string.IsNullOrEmpty(dateOfBirth))
                    {
                        if (DateTime.TryParse(dateOfBirth, out parsedDateOfBirth))
                        {
                            if (parsedDateOfBirth.Year >= (DateTime.Today.Year - 120))
                            {

                                step++;
                            }
                            else
                            {
                                Console.WriteLine("Date Of Birth must have a year greater than {0}", (DateTime.Today.Year - 120));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Date Of Birth must be a valid date");
                        }
                    }
                }
            } while (step != 7);
            Console.WriteLine("First Name {0}, Last Name {1}, City {2}, State {3}, Zip {4}, Phone Number {5}, Date Of Birth {6}", firstName, lastName, city, state, zip, phoneNumber, parsedDateOfBirth);
            Console.ReadKey();
        }
    }
}
