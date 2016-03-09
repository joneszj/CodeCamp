using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ArraysArraysArraysOhMy
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimension arrays
            string[] names = new string[4];

            //we can initialize the array values after the array is created
            names[0] = "Derek";
            names[1] = "Dom";
            names[2] = "Wayne";
            names[3] = "Zack";

            //we can also initialize array items at creation time
            string[] states = new string[3] {"FL","TN","GA"};

            //if we provide values for the array, the compiler can determine its size and we don't need to supply a value for the size
            string[] Cities = new string[] {"Tampa","West Palm Beach"};

            Console.WriteLine("Printing single dimension array names");
            for (int i = 0; i < names.GetLength(0); i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("next up, multidimensional arrays, press any key to continue");
            Console.ReadKey();

            //multidimensional arrays
            string[,] fullNames = new string[4, 3];

            fullNames[0, 0] = "Zachary";
            fullNames[0, 1] = "John";
            fullNames[0, 2] = "Jones";

            fullNames[1, 0] = "Ian";
            fullNames[1, 1] = "Joseph";
            fullNames[1, 2] = "Jones";

            fullNames[2, 0] = "John";
            fullNames[2, 1] = "Francis";
            fullNames[2, 2] = "Jones";

            fullNames[3, 0] = "NoMiddleName";
            fullNames[3, 1] = null;
            fullNames[3, 2] = "Jones";

            Console.WriteLine("We can loop through each item in each dimension");
            //loop through first dimension
            for (int i = 0; i < fullNames.GetLength(0); i++)
            {
                //loop through second dimension
                for (int y = 0; y < fullNames.GetLength(1); y++)
                {
                    Console.WriteLine("fullname row {0} col {1} is {2}", i,y, fullNames[i, y]);
                }
            }

            Console.WriteLine("We can use a variable in the first dimension to group and concatenate each item in the second dimension as we loop through the first dimension");
            //loop through first index
            for (int i = 0; i < fullNames.GetLength(0); i++)
            {
                string fullname = "";
                //loop through second index
                for (int y = 0; y < fullNames.GetLength(1); y++)
                {
                    fullname += fullNames[i, y] + ", ";
                }
                Console.WriteLine(fullname);
            }

            Console.WriteLine("next up jagged arrays, press any key to continue");
            Console.ReadKey();

            //jagged arrays
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[7] { 5, 6, 7, 8, 9, 10, 11};
            jaggedArray[2] = new int[2] { 12, 13 };

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int y = 0; y < jaggedArray[i].GetLength(0); y++)
                {
                    Console.WriteLine(jaggedArray[i][y]);
                }
            }

            Random r = new Random();
            int[][][] jaggedArray2 = new int[2][][];
            jaggedArray2[0] = new int[2][];
                jaggedArray2[0][0] = new int[4] { r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000) };
                jaggedArray2[0][1] = new int[3] { r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000) };

            jaggedArray2[1] = new int[3][];
                jaggedArray2[1][0] = new int[5] { r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000) };
                jaggedArray2[1][1] = new int[3] { r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000) };
                jaggedArray2[1][2] = new int[8] { r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000), r.Next(0, 1000) };


            for (int i = 0; i < jaggedArray2.GetLength(0); i++)
            {
                //notice how we can use the iteration variable to loop through the ranks of the second and third arrays without explicitly knowing the length
                for (int y = 0; y < jaggedArray2[i].GetLength(0); y++)
                {
                    for (int x = 0; x < jaggedArray2[i][y].GetLength(0); x++)
                    {
                        Console.WriteLine("array {0} > array {1} > array {2} is ? {3}",i,y,x, jaggedArray2[i][y][x]);
                    }
                }
            }

            int[][][,] jaggedArray3WithMDArray = new int[3][][,];
            //we get the point

            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
