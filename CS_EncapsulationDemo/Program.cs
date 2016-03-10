using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //notice we can call the internal class because it is in the same assembly
            IsInternal x = new IsInternal();
            x.IsPublic = 40;
            //notice we cannot access the member _isPrivate directly, even if we manually types the member name
            //x._isPrivate = 50;
        }
    }

    class IsInternal
    {
        int _isPrivate = 0;

        public int IsPublic { get; set; }

        public int SetIsPrivate()
        {
            return this._isPrivate++;
        }

        public int GetIsPrivate()
        {
            return this._isPrivate;
        }
    }
}
