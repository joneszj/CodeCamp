using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//though we left the default namespace name, most developers call the namespace after the class or classes in it
namespace ClassLibrary1
{
    //notive the accessibility keywords public and private. These allow us to hide code from consumers that we don't want them to know
    //or perhaps edit. We can expose methods to edit fields that are hidden

    //By default, if not access qualifier is set, classes and fields are set to private

    //we can use FxCop to check naming conventions

    //rename class1 to counter
    public class Counter
    {
        //a private member of type int. Private members are also called fields
        private int _counter;

        //a public method to do something
        public int GetNextValue()
        {
            //notice the ++ after means that the iteration occurs AFTER the return
            //so if counter is 0, it will return 0 and then counter will be set to 1
            return _counter++;
        }

    }

    public class Human
    {
        private string _firstName;
        private string _lastName;
        private float _weight;

        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }

        public void SetWeight(float weight)
        {
            this._weight = weight;
        }

        public void SetFirstName(string name)
        {
            this._firstName = name;
        }

        public void SetLastName(string name)
        {
            this._lastName = name;
        }

        public float GetWeight()
        {
            return this._weight;
        }
    }

    //Now that we have created some classes. Lets use them!
}
