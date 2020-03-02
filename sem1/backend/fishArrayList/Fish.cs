using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fishArrayList
{
    public class Fish
    {
        private string type;
        private int length;

        //constructor
        public Fish(string type, int length)
        {
            this.type = type;
            this.length = length;
        }
        public override string ToString()
        {
            return "the class type: " + type + " class length: " + length + " long";
        }
    }
}