using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //by default classes are private, lets set it to public
    public class StaticCounter
    {
        private int _count;
        //notice the keyword static
        private static int _totalCount;
        public int GetNextValue()
        {
            _count += 1;
            _totalCount += 1;
            return _count;
        }
        public static int TotalCount
        {
            get
            {
                return _totalCount;
            }
        }
    }

    //we can create static classes
    //why would we create a static class? Well mainly for classes that have only static members.
    //For example, lets create a static multiplication class
    //often these classes are made as helper classes
    public static class Multiply
    {
        public static int MultiplyInts(int i1, int i2)
        {
            return i1 * i2;
        }
    }

    //a good rule for determining if we should use a static propery or class is to ask ourselves if the method or property should be specific to a class. If it is,
    //it should not be static. If it is not specific to a class, or it is shared between classes then we could make it static.

}
