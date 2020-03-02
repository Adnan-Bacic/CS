using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace personClass
{
    public class persons
    {
        //instance variables
        private int age;

        //constructor
        public persons(int age)
        {
            this.age = age;
        }

        //method
        public string talk()
        {
            return "i am " + age + " years old";
        }
    }
}