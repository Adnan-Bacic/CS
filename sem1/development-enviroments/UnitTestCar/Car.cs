using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestCar
{
    public class Car
    {
        //instance variables
        private string model;
        private string color;

        //constructor
        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }

        //overload constructor with no color
        public Car(string model)
        {
            this.model = model;
            this.color = null;
            //if an interger has to be null it must be a "int?"
        }

        //model properties
        public string Model
        {
            get { return model; }
            //no set. set { model = value; }
        }
        //color property
        public string Color
        {
            get { return color; }
            //no set - set { color = value }
        }

        //method change color
        public void ChangeColor(string color)
        {
            if (color == "pink")
            {
                this.color = this.color + " unchanged";
            }
            else
            {
                this.color = color;
            }
        }

        //to string
        public override string ToString()
        {
            if (color == null) return model + "; color unknown";
            else return model + "; color : " + color;
        }

    }
}