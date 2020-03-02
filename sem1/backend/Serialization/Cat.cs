using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Serialization
{
    [Serializable]
    public class Cat
    {
        private string name;
        private string colour;
        private Chip catchip;


        //constructor
        public Cat(string name, string colour, Chip catchip)
        {
            this.name = name;
            this.colour = colour;
            this.catchip = catchip;
        }

        //empty constructor
        public Cat()
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public Chip Catchip
        {
            get { return catchip; }
            set { catchip = value; }
        }

        public override string ToString()
        {
            return name + " is " + colour + "; the chip has " + catchip.ToString();
        }

    }
}
