using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogClass
{
    public class Dog
    {
        // instance variables
        private string name;
        private string type;
        private int age;
        private Owner own;
        private int dogid;

        //class variable
        private static int mycounter;
        
        // constructor
        public Dog(string name, string mytype, int age, Owner own)
        {
            this.name = name;
            type = mytype;
            this.age = age;
            this.own = own;
            mycounter++;
            dogid = mycounter;
        }

        // property for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // properety for type
        public string Type
        {
            get { return type + "-dog"; }
            // set { type = value; }
        }

        // property for age
        public int Age
        {
            get { return age; }
            set { if (value > 25) age = 25; else age = value; }
        }

        // property for owner
        public Owner Own
        {
            get { return own; }
        }

        // property for dogid
        public int Dogid
        {
            get { return dogid; }
        }

        // ToString
        public override string ToString()
        {
            return "Id " + dogid + " : " + name + " is a " + age + " year" + ((age == 1) ? "" : "s") +" old " + type + ". " + own.ToString();
        }
    }
}