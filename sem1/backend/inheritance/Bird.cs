using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inheritance
{
    public class Bird
    {
        //instance variable
        protected string species;
        protected string colour;

        //constructor
        public Bird(string species, string colour)
        {
            this.species = species;
            this.colour = colour;
        }

        //species property
        public string Species
        {
            get { return species + "-bird"; }
            //no set
        }
        //colour property
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        //method
        public virtual string SayTweet()
        {
            return "tweet tweet";
        }

        //tostring
        public override string ToString()
        {
            return "The species is: " + species + " is " + colour +
            " and it can say " + SayTweet();
        }
    }
}