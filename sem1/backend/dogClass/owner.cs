using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogClass
{
    public class Owner
    {
        //instance variable
        private string name;

        //constructer
        public Owner(string name)
        {
            this.Name = name;
        }

        //property for name
        public string Name { get => name; set => name = value; }

        //tostring
        public override string ToString()
        {
            return "Owners name :" + name;
        }
    }
}