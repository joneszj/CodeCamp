using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticCounter c1 = new StaticCounter();
            StaticCounter c2 = new StaticCounter();

            Console.WriteLine("c1: " + c1.GetNextValue()); //0
            Console.WriteLine("c1: " + c1.GetNextValue()); //1
            Console.WriteLine("c1: " + c1.GetNextValue()); //2
            Console.WriteLine("c2: " + c2.GetNextValue()); //0
            Console.WriteLine("c1: " + c1.GetNextValue()); //3

            //so we created some StaticCounters, but recall the totalCount is static, meaning that it is not tied to any particular
            //instantiated object. So what is c1.TotalCount? What is c2.TotalCount? Well because the TotalCount is static
            //we do not call it on c1 or c2, we call it directly from the class!
            Console.WriteLine(StaticCounter.TotalCount);

            //Console.WriteLine is also a static method! That is why we do not need to instantiate Console to use WriteLine
        }
    }
}
