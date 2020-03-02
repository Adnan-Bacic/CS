using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inheritance
{
    public class Owl : Bird
    {

        //instance variable
        protected int numberOfMiceCaught;

        //constructor
        public Owl(string species, string colour, int numberOfMiceCaught) : base(species, colour)
        {
            this.numberOfMiceCaught = numberOfMiceCaught;
        }

        //overloaded constructor with default numberOfMiceCaught
        public Owl(string species, string colour) : base(species, colour)
        {
            numberOfMiceCaught = 0;
        }

        //numberOfMiceCaught property
        public int NumberOfMiceCaught
        {
            get { return numberOfMiceCaught; }
            set { numberOfMiceCaught = value; }
        }

        //say tweet
        public override string SayTweet()
        {
            return "hoot hoot";
        }

        //tostring
        public override string ToString()
        {
            return "The " + species + " is " + colour + " says " +
            SayTweet() + " and has caught " + numberOfMiceCaught +
            ((numberOfMiceCaught == 1) ? " mouse " : " mice"); //inline if statement
        }
    }
}