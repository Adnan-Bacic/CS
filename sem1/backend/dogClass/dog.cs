using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dogClass
{
    public class dog
    {
        //instane variables
        private string name;
        private string type;
        private int age;
        private Owner own;
        private int dogid;
        private static int mycounter;

        //constructor
        public dog(string name, string mytype, int age, owner own)
        {
            this.name = name;
            type = mytype;
            this.age = age;
            this.own = own;
            mycounter++;
            dogid = mycounter;
        }

        //property for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //propterty for type
        public string Type
        {
            get { return type + "-dog"; }
           // set { type = value; }
        }

        //proptery for age
        public int Age
        {
            get { return age; }
            set { if (value > 25) age = 25; else age = value; }
        }

        //property for owner
        public Owner own
        {
            get { return own; }
        }

        //property for dogid
        public int Dogid
        {
            get { return dogid; }
        }

        //tostring
        public override string ToString()
        {
            return "ID :" + dogid + name + " is a " + age + " year" + ((age == 1) ? "" : "s") + " old " + type + "Owner: " + own.toString();
        }
    }
}