using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handin2
{
    public class Administator : Person
    {
        protected int adminID;

        //constructor
        public Administator(string name, int age, string email, int adminID) : base(name, age, email)
        {
            this.adminID = adminID;
            this.email = email;
        }

        public int AdminID
        {
            get { return adminID; }
            set { adminID = value;  }
        }

        public override void ChangeEmail(string email)
        {
            //string emailAdmin = email;
            string emailAdminShow = "";

            foreach (char c in email)
            {
                emailAdminShow += c;

            }


            emailAdminShow = emailAdminShow.Remove(emailAdminShow.LastIndexOf("@") + 1);
            emailAdminShow = emailAdminShow + "pig.dk";
            base.email = emailAdminShow;
        }
        

        //tostring
        public override string ToString()
        {
            return "Name: " + name + " and age: " + age + " and email: " + email +
                " and administrator id: " + adminID;
        }
    }
}