using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OutMethodKeyword
{
    public class OutKeyword
    {
        public static int Divide(int x, int y, out int remainder)
        {
            remainder = x % y;
            return x / y;
        }
    }

    public class RefKeyword
    {
        public static int Divide(int x, int y, ref int remainder)
        {
            remainder = x % y;
            return x / y;
        }
    }
}
