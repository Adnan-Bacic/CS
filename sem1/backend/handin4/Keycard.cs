using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handin4
{
    [Serializable] //important
    public class Keycard
    {
        //instance variables
        private int keynumber;

        //constructor
        public Keycard(int keynumber)
        {
            this.keynumber = keynumber;
        }

        //empty constructor xml
        public Keycard()
        {

        }

        //properties
        public int Keynumber
        {
            get { return keynumber; }
            set { keynumber = value;  }
        }

        //tostring
        public override string ToString()
        {
            return "Keynumber: " + keynumber;
        }
    }
}