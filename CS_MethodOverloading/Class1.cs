using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_MethodOverloading
{
    public static class Class1
    {
        //by using the same method name, but using differnt types passed or number of parameters we can overload methods
        //this offers the consumer options when calling the method
        public static void Blame(string perpetrator, string problem)
        {
            Console.WriteLine("I blame {0} for {1}.", perpetrator, problem);
        }
        public static void Blame(string perpetrator)
        {
            Blame(perpetrator, "the downfall of society");
        }
        public static void Blame()
        {
            Blame("the youth of today", "the downfall of society");
        }
    }
}
