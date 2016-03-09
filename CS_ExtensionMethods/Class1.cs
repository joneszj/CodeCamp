using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ExtensionMethods
{
    public static class StringExtensions
    {
        //extension methods give the appearance of a extending other objects using the this keyword
        public static void Show(this string s)
        {
            System.Console.WriteLine(s);
        }
    }
}
