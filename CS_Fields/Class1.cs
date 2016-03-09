using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Fields
{
    public class Persons
    {
        //private by default
        string _firstName;
        string _lastName;
        readonly string _social = new Guid().ToString();
        const string _species = "Human";

        public string GetName()
        {
            return this._firstName;
        }

        public void SetName(string firstName)
        {
            //one reason we expose fields via methods or properties is we can do logic when
            //accessing the class fields
            if (!string.IsNullOrEmpty(firstName))
            {
                this._firstName = firstName;
            }
            else
            {
                //do something else as the string was empty
            }
        }

        public string GetLastName()
        {
            return this._lastName;
        }

        public void SetLastName(string lastName)
        {
            if (!string.IsNullOrEmpty(lastName))
            {
                this._lastName = lastName;
            }
            else
            {

            }
        }

        public string GetSocial()
        {
            return this._social;
        }

        public string GetSpecies()
        {
            return _species;
        }
    }
}
