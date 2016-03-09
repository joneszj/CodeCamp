using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_StaticMethods
{
    public static class BasicMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            //note that if an int has a remainder it will be cut off so lets overload it
            return x / y;
        }
        //overloaded divide
        public static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
