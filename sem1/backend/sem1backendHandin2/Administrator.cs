using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backendHandin2
{
    public class Administator : Person
    {
        protected int adminID;

        //constructor
        public Administator(string name, int age, string email, int adminID) : base(name, age, email)
        {
            this.adminID = adminID;
        }

        //tostring
        public override string ToString()
        {
            return "Name: " + name + " and age: " + age + " and email: " + email + " and administrator id: " + adminID;
        }
    }
}