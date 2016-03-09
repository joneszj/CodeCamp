using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MethodsPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = addVariables(1, 5);
            Console.WriteLine();
        }

        static int addNumbers()
        {
            return 1 + 1;
        }

        static int addVariables(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
