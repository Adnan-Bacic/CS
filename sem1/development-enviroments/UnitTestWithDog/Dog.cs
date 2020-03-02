using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestWithDog
{
    public class Dog
    {
        private string name;
        private int? age;

        // constructor
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // overloaded constructor with no age (age = null requires type int?)
        public Dog(string name)
        {
            this.name = name;
            this.age = null;
        }

        // Name property; name cannot be changed
        public string Name
        {
            get { return name; }
            // no set
        }

        // Age property
        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        // Add one to age
        public void IncreaseAge()
        {
            if (age != null) age++;
        }

        // Say hello
        public string SayHello(string myname)
        {
            return "Woof ! " + myname;
        }

        // ToString
        public override string ToString()
        {
            if (age == null) return name + "; age unknown";
            else return name + " is " + age + " year" + ((age == 1) ? "" : "s") + " old";
        }
    }
}