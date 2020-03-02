using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handin4
{
    [Serializable] //important
    public class Person
    {
        //declaring instance variables
        protected string name;
        protected int age;
        protected string email;

        protected Keycard card;

        //constructor
        public Person(string name, int age, string email, Keycard card)
        {
            this.name = name;
            this.age = age;
            this.email = email;

            this.card = card;
        }

        //emptry constructor for xml
        public Person()
        {

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

        public Keycard Card
        {
            get { return card; }
            set { card = value; }
        }

        //tostring
        public override string ToString()
        {
            return "Name: " + name + " and age: " + age + " and email: " + email + " and keynumber: " + card.ToString();
        }
    }
}