using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CastsAndConversions
{

    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            //the below lines will fail because of a conversion or cast is required
            //int willFail = 42.0;
            //int willAlsoFail = i / 1.0;
            //int willFailAgain = 10 + 9.8;

            #region casts
            //using the cast method
            int i2 = (int)42.0;
            Console.WriteLine("casting 42.0 to int = " + i2);
            int i3 = (int)(i / 1.0);
            Console.WriteLine("casting (" + i + " / 1.0) to int = " + i3);
            #endregion

            #region convert
            //we can also use the convert method
            int i4 = System.Convert.ToInt32(0.64);
            Console.WriteLine("convert double 0.64 = " + i4);
            int i5 = System.Convert.ToInt32(0.14);
            Console.WriteLine("convert double 0.14 = " + i5);
            int i6 = System.Convert.ToInt32("17");
            Console.WriteLine("convert string 17 = " + i6);
            #endregion

            Console.ReadKey();
        }
    }
}
