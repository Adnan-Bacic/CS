using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inheritance
{
    public class Songbird : Bird
    {
        //instance variable
        private int numberOfSongs;

        //constructor
        public Songbird(int numberOfSongs, string species, string colour) : base(species, colour)
        {
            this.numberOfSongs = numberOfSongs;
        }

        //property for numberOfSongs
        public int NumberOfSongs { get => numberOfSongs; set => numberOfSongs = value; }

        //old bird tostring
        public string OldToString()
        {
            return base.ToString();
        }

        //tostring
        public override string ToString()
        {
            return "The " + species + " is " + colour + " says " +
            SayTweet() + " and he knows " + numberOfSongs + " song" +
            ((numberOfSongs == 1) ? "" : "s"); //inline if statement
        }
    }
}