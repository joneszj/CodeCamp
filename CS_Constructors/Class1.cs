using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Constructors
{
    public class Lumber
    {
        string type;

        public Lumber(string type)
        {
            this.type = type;
        }
    }

    public class Human
    {
        string _bloodType;
        int _iD;

        //a manually implemented default constructor
        public Human()
        {
            //we can use a ctor to do stuff as a class is generated
            this._iD = new Random().Next();
        }
        //a second constructor
        public Human(string bloodType)
        {
            this._bloodType = bloodType;
        }
    }

    public class ItemWithId
    {
        private static int _lastId;
        private int _id;
        private string _name;
        //ctor chaining
        public ItemWithId()
        {
            _id = ++_lastId;
        }
        public ItemWithId(string name)
        : this()
        {
            _name = name;
        }
        public ItemWithId(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public int GetID()
        {
            return this._id;
        }

        public string GetName()
        {
            return this._name;
        }

        public int GetStaticID()
        {
            return ItemWithId._lastId;
        }
    }
}
