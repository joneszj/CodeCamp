using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//To use our class library, we need to bring it in using a using statement
//Alternatively, VS will help us if the using statement isn't there and it will create one for us
//by right clicking the red squigly indicating the error

//because our class library is in another project, we need to add a reference to that project namespace
//add > reference > solution > {project name}

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //after referencing our class library, we could also fully qualify the namespace without using the using statement like so:
            //ClassLibrary1.Counter c = new ClassLibrary1.Counter();

            //Classes are simply blueprints for objects. They do nothing until we instantiate (create) on object with that class
            //we do so very similar to regular variables
            //Declare the type (Counter) give it a name (c) use the assignment operator (=)
            //use the new keyword (different from intrinsic types) declare the type once more (Counter)
            //followed by its constructor (the open/closed parenthesis, we will cover constructors soon)
            Counter c1 = new Counter();
            //BOOM, there we have it! Our very own counter! Lets create another!!!
            Counter c2 = new Counter();

            //To help understand what we are doing, c1 and c2 are the same type (class Counter) but SEPERATE instances of that type
            Console.WriteLine("c1: " + c1.GetNextValue()); //0
            Console.WriteLine("c1: " + c1.GetNextValue()); //1
            Console.WriteLine("c1: " + c1.GetNextValue()); //2
            Console.WriteLine("c2: " + c2.GetNextValue()); //0
            Console.WriteLine("c1: " + c1.GetNextValue()); //3

            //Lets create a human object
            Human h1 = new Human();
            //lets call h1's set weight method
            h1.SetWeight(c1.GetNextValue() * (float)Math.PI); //oops lol
            h1.SetFirstName(Console.ReadLine());
            h1.SetLastName(Console.ReadLine());

            Console.WriteLine("Hello! My name is {0}", h1.GetFullName());

            //lets use the static class we created
            int result = Multiply.MultiplyInts(12, 156);

            //the system.math class also has static members on it usefull to us, such as pi
            double pi = Math.PI;
            Console.WriteLine(pi);
        }
    }
}
