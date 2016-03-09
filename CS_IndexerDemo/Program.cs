using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_IndexerDemo
{
    //from https://msdn.microsoft.com/en-us/library/2549tw02(v=vs.80).aspx
    class TempRecord
    {
        // Array of temperature values
        private float[] temps = new float[10] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
                                            61.3F, 65.9F, 62.1F, 59.2F, 57.5F };
        // Auto-Implemented Property
        System.DateTime date { get; set; }
        // To enable client code to validate input 
        // when accessing your indexer.
        public int Length
        {
            get { return temps.Length; }
        }
        // Indexer declaration.
        // Input parameter is validated by client 
        // code before being passed to the indexer.
        public float this[int index]
        {
            get
            {
                return temps[index];
            }

            set
            {
                temps[index] = value;
            }
        }
    }

    class MainClass
    {
        static void Main()
        {
            TempRecord tempRecord = new TempRecord();
            // Use the indexer's set accessor
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;

            // Use the indexer's get accessor
            for (int i = 0; i < 10; i++)
            {
                // This example validates the input on the client side. You may
                // choose to validate it in the class that implements the indexer, and throw an
                // exception or return an error code in the case of invalid input.
                if (i < tempRecord.Length)
                {
                    System.Console.WriteLine("Element #{0} = {1}", i, tempRecord[i]);
                }
                else
                {
                    System.Console.WriteLine("Index value of {0} is out of range", i);
                }
            }

            //Uncomment this code to see how the .NET Framework handles indexer exceptions
            //try
            //{
            //    System.Console.WriteLine("Element #{0} = {1}", tempRecord[tempRecord.Length]);
            //}
            //catch (System.ArgumentOutOfRangeException e)
            //{
            //    System.Console.WriteLine(e);
            //}

            /*
                To provide the indexer with a name that other languages can use, use a name attribute in the declaration. For example:

                [System.Runtime.CompilerServices.IndexerName("TheItem")]
                public int this [int index]   // Indexer declaration
                {
                }
            */
        }
    }
}
