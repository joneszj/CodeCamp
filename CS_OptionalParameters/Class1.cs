using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Fields;

namespace CS_OptionalParameters
{
    //lets reference the Persons class in our Fields class library
    public static class OptionalParameters
    {
        //by providing a value for lastName, if the calling method does not pass an argument it will set it to Jones
        public static Persons CreatePerson(string firstName, string lastName = "Jones")
        {
            Persons p = new Persons();
            p.SetName(firstName);
            p.SetLastName(lastName);
            return p;
        }
    }
}
