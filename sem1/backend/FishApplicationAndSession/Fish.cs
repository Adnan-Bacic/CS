using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishApplicationAndSession
{
    public class Fish
    {
        //instance variables
        private string type;
        private double length;

        //constructor - used when we make a new fish
        public Fish(string type, double length)
        {
            this.type = type;
            this.length = length;
        }

        //tostring
        public override string ToString()
        {
            return "The " + type + " is " + length + " cm long";
        }
    }
}