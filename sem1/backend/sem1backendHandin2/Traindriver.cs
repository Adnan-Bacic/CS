using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backendHandin2
{
    //instance variables
    public class Traindriver : Person
    {
        protected int licenseNumber;

        //constructor
        public Traindriver(string name, int age, string email, int licenseNumber) : base(name, age, email)
        {
            this.licenseNumber = licenseNumber;
        }

        //tostring
        public override string ToString()
        {
            return "Name: " + name + " and age: " + age + " and email: " + email + " and license:" + licenseNumber;
        }
    }
}