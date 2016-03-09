using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Constructors;

//add reference to our class library
namespace CS_ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //notice when constructing we are forced to provide the value for Lumber.type
            Lumber wood = new Lumber("Oak");

            //notice the overload to have more than one construction
            Human h1 = new Human();

            Human h2 = new Human("A+");

            ItemWithId i1 = new ItemWithId();

            ItemWithId i2 = new ItemWithId("Computer");

            ItemWithId i3 = new ItemWithId("Windows", 1);

            Console.WriteLine(i1.GetID());
            Console.WriteLine(i1.GetName());
            Console.WriteLine(i1.GetStaticID());

            Console.WriteLine(i2.GetID());
            Console.WriteLine(i2.GetName());
            Console.WriteLine(i2.GetStaticID());

            Console.WriteLine(i3.GetID());
            Console.WriteLine(i3.GetName());
            Console.WriteLine(i3.GetStaticID());
        }
    }
}
