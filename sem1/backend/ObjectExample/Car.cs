using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObjectExample
{
    public class Car
    {
        public string type;
        public int year;

        public Car(string type, int year)
        {
            this.type = type;
            this.year = year;
        }

        public override string ToString()
        {
            return "The type is: " + type + " and year is " + year;
        }
    }
}