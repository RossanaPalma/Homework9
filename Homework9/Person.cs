using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9
{
    class Person
    {
        private String name;

        //Constructors
        public Person()
        {
            name = "Name";
        }
        public Person(string _name)
        {
            name = _name;
        }
        public Person(Person obj)
        {
            name = obj.name;
        }
        // Methods
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return String.Format("Owner: {0}", GetName());
        }
        public override bool Equals(object obj)
        {
            if(this == obj)
            {
                return true;
            }
            if(obj == null)
            {
                return false;
            }
            if(!(obj.GetType() == typeof(Person)))
            {
                return false;
            }
            Person other = (Person)obj;
            if(name == null)
            {
                if(other.name != name)
                {
                    return false;
                }
            }
            else if(! name.Equals(other.name))
            {
                return false;
            }
            return true;
        }

    }
}
