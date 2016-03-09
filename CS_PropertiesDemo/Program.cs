using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_AutomaticProperties;

namespace CS_PropertiesDemo
{
    //lets reference the CS_AutomaticProperties class library to access the Human class
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Zachary", "Jones");
            Console.WriteLine("Hello, my name is " + h1.fullName);
            h1.age = 29;
            h1.bloodType = "A";
            h1.sex = "Male";
            Console.WriteLine(h1.sex);
            Console.WriteLine("I currently am a " + h1.GetOccupationByAge(h1.age));
        }
    }
}
