using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handin2
{
    public class Person
    {
        //declaring instance variables
        protected string name;
        protected int age;
        protected string email;

        //constructor
        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //method
        public virtual void ChangeEmail(string email)
        {
            
        }

        //tostring
        public override string ToString()
        {
            return "Name: " + name + " and age: " + age + " and email: " + email;
        }
    }
}